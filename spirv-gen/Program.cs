using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Formatting;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Xml;

namespace SpirV;

class Program
{
	static void Main()
	{
		AdhocWorkspace workspace = new();
		SyntaxGenerator generator = SyntaxGenerator.GetGenerator(workspace,
			LanguageNames.CSharp);

		ProcessSpirv(generator, workspace);
		ProcessGrammars(generator, workspace);
	}

	class OperandItem
	{
		public required string Kind { get; set; }
		public string? Quantifier { get; set; }
		public string? Name { get; set; }
	}

	class InstructionItem
	{
		public required string Name { get; set; }
		public required int Id { get; set; }
		public List<OperandItem>? Operands { get; set; }
	}

	private static void ProcessInstructions(JsonElement instructions,
		IReadOnlyDictionary<string, bool> knownEnumerands,
		List<SyntaxNode> nodes)
	{
		List<InstructionItem> ins = [];

		foreach (JsonElement instruction in instructions.EnumerateArray())
		{
			InstructionItem i = new()
			{
				Name = instruction.GetProperty("opname").GetString()!,
				Id = instruction.GetProperty("opcode").GetInt32()
			};

			if (instruction.TryGetProperty("operands", out JsonElement operands))
			{
				i.Operands = [];
				foreach (JsonElement operand in operands.EnumerateArray())
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

					i.Operands.Add(oe);
				}
			}

			ins.Add(i);
		}

		StringBuilder sb = new();

		foreach (InstructionItem instruction in ins)
		{
			CreateInstructionClass(sb, instruction, knownEnumerands);
		}

		sb.AppendLine("public static class Instructions {");
		sb.Append("public static IReadOnlyDictionary<int, Instruction> OpcodeToInstruction { get; } = new Dictionary<int, Instruction>() {");

		foreach (InstructionItem instruction in ins)
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

	private static void CreateInstructionClass(StringBuilder sb, InstructionItem instruction, IReadOnlyDictionary<string, bool> knownEnumerands)
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
				if (operand.Name == null)
				{
					sb.AppendLine($"new Operand({constructorParameter}, null, OperandQuantifier.{operand.Quantifier}),");
				}
				else
				{
					sb.AppendLine($"new Operand({constructorParameter}, \"{operand.Name}\", OperandQuantifier.{operand.Quantifier}),");
				}
			}
			sb.AppendLine("] )");
		}

		sb.AppendLine("{}");

		sb.AppendLine("}");
	}

	class OperatorKindEnumerant
	{
		public required string Name { get; set; }
		public required uint Value { get; set; }

		public List<string>? Parameters { get; set; }
	}

	private static IReadOnlyDictionary<string, bool> ProcessOperandTypes(JsonElement OperandTypes, IList<SyntaxNode> nodes)
	{
		Dictionary<string, bool> result = [];

		// We gather all of the types up-front as we need them in the loop
		foreach (JsonElement n in OperandTypes.EnumerateArray())
		{
			// We only handle the Enums here, the others are handled 
			// manually
			if (n.GetProperty("category").GetString() != "ValueEnum"
				&& n.GetProperty("category").GetString() != "BitEnum") continue;

			string kind = n.GetProperty("kind").GetString()!;

			bool hasParameters = false;

			foreach (JsonElement enumerant in n.GetProperty("enumerants").EnumerateArray())
			{
				if (enumerant.TryGetProperty("parameters", out _))
				{
					hasParameters = true;
					break;
				}
			}

			result.Add(kind, hasParameters);
		}

		foreach (JsonElement n in OperandTypes.EnumerateArray())
		{
			// We only handle the Enums here, the others are handled 
			// manually
			if (n.GetProperty("category").GetString() != "ValueEnum"
				&& n.GetProperty("category").GetString() != "BitEnum") continue;

			string kind = n.GetProperty("kind").GetString()!;

			EnumType enumType = n.GetProperty("category").GetString() == "ValueEnum"
				? EnumType.Value : EnumType.Bit;

			IList<OperatorKindEnumerant> enumerants = [];

			foreach (JsonElement enumerant in n.GetProperty("enumerants").EnumerateArray())
			{
				OperatorKindEnumerant oke = new()
				{
					Name = enumerant.GetProperty("enumerant").GetString()!,
					Value = ParseEnumValue(enumerant.GetProperty("value"))
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

			StringBuilder sb = new();

			if (enumType == EnumType.Bit)
			{
				sb.AppendLine("[Flags]");
			}
			sb.AppendLine($"public enum {kind} : uint");
			sb.AppendLine("{");
			foreach (OperatorKindEnumerant e in enumerants)
			{
				sb.Append($"{e.Name} = {e.Value},\n");
			}
			sb.AppendLine("}");

			sb.AppendLine($"public class {kind}ParameterFactory : ParameterFactory");
			sb.AppendLine("{");
			foreach (OperatorKindEnumerant e in enumerants)
			{
				if (e.Parameters == null) continue;
				sb.AppendLine($"public class {e.Name}Parameter : Parameter");
				sb.AppendLine("{");
				sb.AppendLine("public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }");
				sb.AppendLine("private static readonly OperandType[] operandTypes_ =");
				sb.AppendLine("[");

				foreach (string p in e.Parameters)
				{
					if (result.ContainsKey(p))
					{
						if (result[p])
						{
							sb.AppendLine($"new EnumType<{p},{p}Parameters> (),");
						}
						else
						{
							sb.AppendLine($"new EnumType<{p}> (),");
						}
					}
					else
					{
						sb.AppendLine($"new {p} (),");
					}
				}

				sb.AppendLine("];");
				sb.AppendLine("}");
			}

			if (result[kind])
			{
				OperandTypeCreateParameterMethod(kind, enumerants, sb);
			}

			sb.AppendLine("}");

			SyntaxTree tree = CSharpSyntaxTree.ParseText(sb.ToString());
			foreach (SyntaxNode node in tree.GetRoot().ChildNodes())
			{
				nodes.Add(node.NormalizeWhitespace());
			}
		}

		return result;
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

	private static uint ParseEnumValue(JsonElement value)
	{
		if (value.ValueKind == System.Text.Json.JsonValueKind.String)
		{
			string s = value.ToString();

			if (s.StartsWith("0x"))
			{
				return uint.Parse(s[2..], System.Globalization.NumberStyles.HexNumber);
			}
			else
			{
				return uint.Parse(s);
			}
		}
		else
		{
			return value.GetUInt32();
		}
	}

	private static void ProcessGrammars(
		SyntaxGenerator generator,
		Workspace workspace)
	{
		JsonDocument doc = System.Text.Json.JsonDocument.Parse(System.IO.File.ReadAllText(
				"spirv.core.grammar.json"));

		List<SyntaxNode> nodes = [];

		IReadOnlyDictionary<string, bool> knownEnumerands = ProcessOperandTypes(doc.RootElement.GetProperty("operand_kinds"), nodes);
		ProcessInstructions(doc.RootElement.GetProperty("instructions"), knownEnumerands, nodes);

		SyntaxNode cu = generator.CompilationUnit([
			generator.NamespaceImportDeclaration("System"),
			generator.NamespaceImportDeclaration("System.Collections.Generic"),
			SyntaxFactory.FileScopedNamespaceDeclaration(SyntaxFactory.ParseName("SpirV")),
			..nodes]);

		GenerateCode(cu, workspace, "../../../../SPIRV/SpirV.Core.Grammar.cs");
	}

	private static void ProcessSpirv(SyntaxGenerator generator, Workspace workspace)
	{
		JsonDocument doc = System.Text.Json.JsonDocument.Parse(System.IO.File.ReadAllText(
				"spirv.json"));

		XmlDocument xmlDoc = new();
		xmlDoc.Load("spir-v.xml");

		List<SyntaxNode> nodes = [];

		CreateSpirvMeta(doc.RootElement, xmlDoc, nodes);

		SyntaxNode cu = generator.CompilationUnit([
			generator.NamespaceImportDeclaration("System.Collections.Generic"),
			SyntaxFactory.FileScopedNamespaceDeclaration(SyntaxFactory.ParseName("SpirV")),
			..nodes]);
		GenerateCode(cu, workspace, "../../../../SPIRV/SpirV.Meta.cs");
	}

	private static void GenerateCode(SyntaxNode node, Workspace workspace,
		string path)
	{
		node = Formatter.Format(node, workspace);

		System.IO.File.WriteAllText(path,
			node.ToFullString().Replace("    ", "\t"));
	}

	private static void CreateSpirvMeta(JsonElement jr,
		XmlDocument doc, List<SyntaxNode> nodes)
	{
		Meta meta = new(jr.GetProperty("spv").GetProperty("meta"), (XmlElement)doc.SelectSingleNode("/registry/ids")!);

		nodes.Add(meta.ToSourceFragment());
	}
}
