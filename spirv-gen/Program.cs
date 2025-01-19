using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Formatting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace SpirV;

class Program
{
	static void Main()
	{
		AdhocWorkspace workspace = new();
		SyntaxGenerator generator = SyntaxGenerator.GetGenerator(workspace,
			LanguageNames.CSharp);

		GenerateCode(Meta.Load().ToCompilationUnit(), workspace, "../../../../SPIRV/SpirV.Meta.cs");
		ProcessGrammars(generator, workspace);
	}

	class OperandItem
	{
		public required string Kind { get; set; }
		public string? Quantifier { get; set; }
		public string? Name { get; set; }

		public string GetNameLiteral()
		{
			return Name is null ? "null" : $"\"{Name}\"";
		}

		public static OperandItem Parse(JsonElement operand)
		{
			OperandItem oe = new()
			{
				Kind = operand.GetProperty("kind").GetString()!
			};

			if (operand.TryGetProperty("quantifier", out JsonElement quantifier))
			{
				switch (quantifier.GetString())
				{
					case "*": oe.Quantifier = "Varying"; break;
					case "?": oe.Quantifier = "Optional"; break;
				}
			}
			else
			{
				oe.Quantifier = "Default";
			}

			if (operand.TryGetProperty("name", out JsonElement name))
			{
				string operandName = name.GetString()!;

				if (operandName.StartsWith('\''))
				{
					operandName = operandName.Replace("\'", "");
				}

				operandName = operandName.Replace("\n", "");

				oe.Name = operandName;
			}

			return oe;
		}
	}

	class InstructionItem
	{
		public required string Name { get; set; }
		public required int Id { get; set; }
		public List<OperandItem>? Operands { get; set; }

		public static InstructionItem Parse(JsonElement instruction)
		{
			InstructionItem i = new()
			{
				Name = instruction.GetProperty("opname").GetString()!,
				Id = instruction.GetProperty("opcode").GetInt32()
			};

			if (instruction.TryGetProperty("operands", out JsonElement operands))
			{
				i.Operands = operands.EnumerateArray().Select(OperandItem.Parse).ToList();
			}

			return i;
		}

		public static List<InstructionItem> ParseList(JsonElement instructions)
		{
			return instructions.EnumerateArray().Select(Parse).ToList();
		}
	}

	class OperatorKind
	{
		public required string Kind { get; init; }
		public required EnumType Category { get; init; }
		public required List<OperatorKindEnumerant> Enumerants { get; init; }

		public bool HasParameters => Enumerants.Any(e => e.Parameters != null);

		public static OperatorKind ParseEnum(JsonElement n)
		{
			EnumType enumType = n.GetProperty("category").GetString() switch
			{
				"ValueEnum" => EnumType.Value,
				"BitEnum" => EnumType.Bit,
				_ => throw new System.Exception("Unknown enum type"),
			};

			string kind = n.GetProperty("kind").GetString()!;

			List<OperatorKindEnumerant> enumerants = [];

			foreach (JsonElement enumerant in n.GetProperty("enumerants").EnumerateArray())
			{
				OperatorKindEnumerant oke = new()
				{
					Name = enumerant.GetProperty("enumerant").GetString()!,
					Value = enumerant.GetProperty("value").ParseEnumValue(),
				};

				if (char.IsDigit(oke.Name[0]))
				{
					oke.Name = kind + oke.Name;
				}

				if (enumerant.TryGetProperty("parameters", out JsonElement parameters))
				{

					oke.Parameters = [];

					foreach (JsonElement parameter in parameters.EnumerateArray())
					{
						oke.Parameters.Add(parameter.GetProperty("kind").GetString()!);
					}
				}

				enumerants.Add(oke);
			}

			return new OperatorKind
			{
				Kind = kind,
				Category = enumType,
				Enumerants = enumerants
			};
		}

		public static List<OperatorKind> ParseList(JsonElement operandTypes)
		{
			List<OperatorKind> result = [];

			foreach (JsonElement n in operandTypes.EnumerateArray())
			{
				// We only handle the Enums here; the others are handled manually.
				if (n.GetProperty("category").GetString() is not "ValueEnum" and not "BitEnum")
					continue;

				OperatorKind ok = ParseEnum(n);

				result.Add(ok);
			}

			return result;
		}
	}

	class OperatorKindEnumerant
	{
		public required string Name { get; set; }
		public required uint Value { get; set; }

		public List<string>? Parameters { get; set; }
	}

	private static void ProcessInstructions(IReadOnlyList<InstructionItem> instructions,
		IReadOnlyDictionary<string, OperatorKind> knownEnumerands,
		List<SyntaxNode> nodes)
	{
		StringBuilder sb = new();

		foreach (InstructionItem instruction in instructions)
		{
			CreateInstructionClass(sb, instruction, knownEnumerands);
		}

		sb.AppendLine("public static class Instructions {");
		sb.Append("public static IReadOnlyDictionary<int, Instruction> OpcodeToInstruction { get; } = new Dictionary<int, Instruction>() {");

		foreach (InstructionItem instruction in instructions)
		{
			sb.AppendLine($"{{ {instruction.Id}, new {instruction.Name}() }},");
		}

		sb.AppendLine("};");
		sb.AppendLine("}");

		string s = sb.ToString();

		SyntaxTree tree = CSharpSyntaxTree.ParseText(s);
		IEnumerable<SyntaxNode> tn = tree.GetRoot().ChildNodes();
		foreach (SyntaxNode n in tn)
		{
			nodes.Add(n.NormalizeWhitespace());
		}
	}

	private static void CreateInstructionClass(StringBuilder sb, InstructionItem instruction, IReadOnlyDictionary<string, OperatorKind> knownEnumerands)
	{
		sb.AppendLine($"public class {instruction.Name} : Instruction");
		sb.AppendLine("{");

		sb.AppendLine($"public {instruction.Name} ()");

		if (instruction.Operands == null)
		{
			sb.AppendLine($" : base(nameof({instruction.Name}))");
		}
		else
		{
			sb.AppendLine($" : base(nameof({instruction.Name}), [");
			foreach (OperandItem operand in instruction.Operands)
			{
				string constructorParameter;
				if (knownEnumerands.ContainsKey(operand.Kind))
				{
					constructorParameter = $"new EnumType<{operand.Kind}, {operand.Kind}ParameterFactory>()";
				}
				else
				{
					constructorParameter = $"new {operand.Kind}()";
				}
				sb.AppendLine($"new Operand({constructorParameter}, {operand.GetNameLiteral()}, OperandQuantifier.{operand.Quantifier}),");
			}
			sb.AppendLine("] )");
		}

		sb.AppendLine("{}");

		sb.AppendLine("}");
	}

	private static void ProcessOperandTypes(IReadOnlyDictionary<string, OperatorKind> knownEnumerands, List<SyntaxNode> nodes)
	{
		foreach (OperatorKind ok in knownEnumerands.Values)
		{
			StringBuilder sb = new();

			if (ok.Category == EnumType.Bit)
			{
				sb.AppendLine("[Flags]");
			}
			sb.AppendLine($"public enum {ok.Kind} : uint");
			sb.AppendLine("{");
			foreach (OperatorKindEnumerant e in ok.Enumerants)
			{
				sb.Append($"{e.Name} = {e.Value},\n");
			}
			sb.AppendLine("}");

			sb.AppendLine($"public class {ok.Kind}ParameterFactory : ParameterFactory");
			sb.AppendLine("{");
			foreach (OperatorKindEnumerant e in ok.Enumerants)
			{
				if (e.Parameters == null) continue;
				sb.AppendLine($"public class {e.Name}Parameter : Parameter");
				sb.AppendLine("{");
				sb.AppendLine("public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }");
				sb.AppendLine("private static readonly OperandType[] operandTypes_ =");
				sb.AppendLine("[");

				foreach (string p in e.Parameters)
				{
					if (knownEnumerands.ContainsKey(p))
					{
						if (knownEnumerands[p].HasParameters)
						{
							sb.AppendLine($"new EnumType<{p},{p}Parameters>(),");
						}
						else
						{
							sb.AppendLine($"new EnumType<{p}>(),");
						}
					}
					else
					{
						sb.AppendLine($"new {p}(),");
					}
				}

				sb.AppendLine("];");
				sb.AppendLine("}");
			}

			if (knownEnumerands[ok.Kind].HasParameters)
			{
				OperandTypeCreateParameterMethod(ok.Kind, ok.Enumerants, sb);
			}

			sb.AppendLine("}");

			SyntaxTree tree = CSharpSyntaxTree.ParseText(sb.ToString());
			foreach (SyntaxNode node in tree.GetRoot().ChildNodes())
			{
				nodes.Add(node.NormalizeWhitespace());
			}
		}
	}

	private static void OperandTypeCreateParameterMethod(string enumName,
		IList<OperatorKindEnumerant> enumerants, StringBuilder sb)
	{
		sb.AppendLine($"public override Parameter? CreateParameter(object value) => ({enumName})value switch");
		sb.AppendLine("{");
		foreach (OperatorKindEnumerant e in enumerants)
		{
			if (e.Parameters == null)
				continue;

			sb.AppendLine($"{enumName}.{e.Name} => new {e.Name}Parameter(),");
		}
		sb.AppendLine("_ => null,");
		sb.AppendLine("};");
	}

	private static void ProcessGrammars(
		SyntaxGenerator generator,
		Workspace workspace)
	{
		JsonDocument doc = JsonDocument.Parse(File.ReadAllText("spirv.core.grammar.json"));

		List<SyntaxNode> nodes = [];

		IReadOnlyDictionary<string, OperatorKind> knownEnumerands = OperatorKind.ParseList(doc.RootElement.GetProperty("operand_kinds")).ToDictionary(a => a.Kind, a => a);
		IReadOnlyList<InstructionItem> instructions = InstructionItem.ParseList(doc.RootElement.GetProperty("instructions"));

		ProcessOperandTypes(knownEnumerands, nodes);
		ProcessInstructions(instructions, knownEnumerands, nodes);

		SyntaxNode cu = generator.CompilationUnit([
			generator.NamespaceImportDeclaration("System"),
			generator.NamespaceImportDeclaration("System.Collections.Generic"),
			SyntaxFactory.FileScopedNamespaceDeclaration(SyntaxFactory.ParseName("SpirV")),
			..nodes]);

		GenerateCode(cu, workspace, "../../../../SPIRV/SpirV.Core.Grammar.cs");
	}

	private static void GenerateCode(SyntaxNode node, Workspace workspace, string path)
	{
		SyntaxNode formatted = Formatter.Format(node, workspace);
		string formattedCode = formatted.ToFullString();
		string code = formattedCode.Replace("    ", "\t");

		File.WriteAllText(path, code);
	}
}
