using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Formatting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Xml;

namespace SpirV
{
	enum EnumType
	{
		Value,
		Bit
	}

	class Meta
	{
		public Meta(JsonElement meta, XmlElement ids)
		{
			MagicNumber = meta.GetProperty(nameof(MagicNumber)).GetUInt32();
			Version = meta.GetProperty(nameof(Version)).GetUInt32();
			Revision = meta.GetProperty(nameof(Revision)).GetUInt32();
			OpCodeMask = meta.GetProperty(nameof(OpCodeMask)).GetUInt32();
			WordCountShift = meta.GetProperty(nameof(WordCountShift)).GetUInt32();

			foreach (XmlElement toolId in ids.SelectNodes("id"))
			{
				ToolInfo ti = new ToolInfo
				{
					vendor = toolId.GetAttribute("vendor")
				};

				if (toolId.HasAttribute("tool"))
				{
					ti.name = toolId.GetAttribute("tool");
				}

				toolInfos_.Add(Int32.Parse(toolId.GetAttribute("value")), ti);
			}
		}

		public SyntaxNode ToSourceFragment(SyntaxGenerator generator)
		{
			IList<SyntaxNode> members =
			[
				CreateProperty(generator, "MagicNumber", MagicNumber),
				CreateProperty(generator, "Version", Version),
				CreateProperty(generator, "Revision", Revision),
				CreateProperty(generator, "OpCodeMask", OpCodeMask),
				CreateProperty(generator, "WordCountShift", WordCountShift)
			];

			StringBuilder sb = new StringBuilder();

			sb.Append("""
				public class ToolInfo { 
								public ToolInfo (string vendor)
								{
									Vendor = vendor;
								}

								public ToolInfo (string vendor, string name)
								{
									Vendor = vendor;
									Name = name;
								}

								public String Name {get;} 
								public String Vendor {get;} 
							}
				""");
			sb.Append("private readonly static Dictionary<int, ToolInfo> toolInfos_ = new Dictionary<int, ToolInfo> {");

			foreach (KeyValuePair<int, ToolInfo> kv in toolInfos_)
			{
				if (kv.Value.name == null)
				{
					sb.Append($"{{ {kv.Key}, new ToolInfo (\"{kv.Value.vendor}\") }},");
				}
				else
				{

					sb.Append($"{{ {kv.Key}, new ToolInfo (\"{kv.Value.vendor}\", \"{kv.Value.name}\") }},");
				}
			}

			sb.Append("};\n");
			sb.Append("public static IReadOnlyDictionary<int, ToolInfo> Tools {get => toolInfos_;}\n");

			SyntaxTree tree = CSharpSyntaxTree.ParseText(sb.ToString());
			foreach (SyntaxNode node in tree.GetRoot().ChildNodes())
			{
				members.Add(node.NormalizeWhitespace());
			}

			SyntaxNode n = generator.ClassDeclaration("Meta", members: members);

			return n;
		}

		private static SyntaxNode CreateProperty(SyntaxGenerator generator,
			string name, uint value)
		{
			return SyntaxFactory.PropertyDeclaration(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.UIntKeyword)), name)
				.WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)))
				.WithExpressionBody(SyntaxFactory.ArrowExpressionClause(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal(value))))
				.WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));
		}

		public uint MagicNumber { get; }
		public uint Version { get; }
		public uint Revision { get; }
		public uint OpCodeMask { get; }
		public uint WordCountShift { get; }

		class ToolInfo
		{
			public string vendor;
			public string name;
		}

		Dictionary<int, ToolInfo> toolInfos_ = [];
	}

	class Program
	{
		static void Main(string[] args)
		{
			AdhocWorkspace workspace = new AdhocWorkspace();
			SyntaxGenerator generator = SyntaxGenerator.GetGenerator(workspace,
				LanguageNames.CSharp);

			ProcessSpirv(generator, workspace);
			ProcessGrammars(generator, workspace);
		}

		class OperandItem
		{
			public string Kind;
			public string Quantifier;
			public string Name;
		}

		class InstructionItem
		{
			public string Name;
			public int Id;
			public IList<OperandItem> Operands;
		}

		private static void ProcessInstructions(JsonElement instructions,
			IReadOnlyDictionary<string, bool> knownEnumerands,
			SyntaxGenerator generator, IList<SyntaxNode> nodes)
		{
			List<InstructionItem> ins = [];

			foreach (JsonElement instruction in instructions.EnumerateArray())
			{
				InstructionItem i = new()
				{
					Name = instruction.GetProperty("opname").GetString(),
					Id = instruction.GetProperty("opcode").GetInt32()
				};

				if (instruction.TryGetProperty("operands", out JsonElement operands))
				{
					i.Operands = new List<OperandItem>();
					foreach (JsonElement operand in operands.EnumerateArray())
					{
						OperandItem oe = new OperandItem()
						{
							Kind = operand.GetProperty("kind").GetString()
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
							string operandName = name.GetString();

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

			StringBuilder sb = new StringBuilder();

			foreach (InstructionItem instruction in ins)
			{
				CreateInstructionClass(sb, instruction, knownEnumerands);
			}

			sb.AppendLine("public static class Instructions {");
			sb.Append("private static readonly Dictionary<int, Instruction> instructions_ = new Dictionary<int, Instruction> {");

			foreach (InstructionItem instruction in ins)
			{
				sb.AppendLine($"{{ {instruction.Id}, new {instruction.Name}() }},");
			}

			sb.Append("""
				};

							public static IReadOnlyDictionary<int, Instruction> OpcodeToInstruction { get => instructions_; }
							}
				""");

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
				sb.AppendLine($" : base(\"{instruction.Name}\")");
			}
			else
			{
				sb.AppendLine($" : base(\"{instruction.Name}\", new List<Operand>() {{");
				foreach (OperandItem operand in instruction.Operands)
				{
					string? constructorParameter = null;
					if (knownEnumerands.ContainsKey(operand.Kind))
					{
						constructorParameter = $"new EnumType<{operand.Kind}, {operand.Kind}ParameterFactory>()";
					}
					else
					{
						constructorParameter = $"new {operand.Kind} ()";
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
				sb.AppendLine("} )");
			}

			sb.AppendLine("{}");

			sb.AppendLine("}");
		}

		class OperatorKindEnumerant
		{
			public string Name;
			public uint Value;

			public IList<string> Parameters;
		}

		private static IReadOnlyDictionary<string, bool> ProcessOperandTypes(JsonElement OperandTypes,
			SyntaxGenerator generator, IList<SyntaxNode> nodes)
		{
			Dictionary<string, bool> result = [];

			// We gather all of the types up-front as we need them in the loop
			foreach (JsonElement n in OperandTypes.EnumerateArray())
			{
				// We only handle the Enums here, the others are handled 
				// manually
				if (n.GetProperty("category").GetString() != "ValueEnum"
					&& n.GetProperty("category").GetString() != "BitEnum") continue;

				string kind = n.GetProperty("kind").GetString();

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

				string kind = n.GetProperty("kind").GetString();

				EnumType enumType = n.GetProperty("category").GetString() == "ValueEnum"
					? EnumType.Value : EnumType.Bit;

				IList<OperatorKindEnumerant> enumerants = [];

				foreach (JsonElement enumerant in n.GetProperty("enumerants").EnumerateArray())
				{
					OperatorKindEnumerant oke = new OperatorKindEnumerant
					{
						Name = enumerant.GetProperty("enumerant").GetString(),
						Value = ParseEnumValue(enumerant.GetProperty("value"))
					};

					if (char.IsDigit(oke.Name[0]))
					{
						oke.Name = kind + oke.Name;
					}

					if (enumerant.TryGetProperty("parameters", out JsonElement parameters))
					{

						oke.Parameters = new List<string>();

						foreach (JsonElement parameter in parameters.EnumerateArray())
						{
							oke.Parameters.Add(parameter.GetProperty("kind").GetString());
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
					sb.AppendLine("private static readonly List<OperandType> operandTypes_ = new List<OperandType> () {");

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

					sb.AppendLine("};");
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
			sb.AppendLine($"public override Parameter CreateParameter (object value)");
			sb.AppendLine("{");
			sb.AppendLine($"switch (({enumName})value) {{");
			foreach (OperatorKindEnumerant e in enumerants)
			{
				if (e.Parameters == null)
					continue;

				sb.AppendLine($"case {enumName}.{e.Name}: return new {e.Name}Parameter ();");
			}
			sb.AppendLine("}");
			sb.AppendLine("return null;");
			sb.AppendLine("}");
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

			List<SyntaxNode> nodes = new List<SyntaxNode>();

			IReadOnlyDictionary<string, bool> knownEnumerands = ProcessOperandTypes(doc.RootElement.GetProperty("operand_kinds"), generator, nodes);
			ProcessInstructions(doc.RootElement.GetProperty("instructions"), knownEnumerands, generator, nodes);

			SyntaxNode cu = generator.CompilationUnit(
				generator.NamespaceImportDeclaration("System"),
				generator.NamespaceImportDeclaration("System.Collections.Generic"),
				generator.NamespaceDeclaration("SpirV", nodes));

			GenerateCode(cu, workspace, "../../../../SPIRV/SpirV.Core.Grammar.cs");
		}

		private static void ProcessSpirv(SyntaxGenerator generator, Workspace workspace)
		{
			JsonDocument doc = System.Text.Json.JsonDocument.Parse(System.IO.File.ReadAllText(
					"spirv.json"));

			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("spir-v.xml");

			List<SyntaxNode> nodes = new List<SyntaxNode>();

			CreateSpirvMeta(doc.RootElement, xmlDoc, generator, nodes);

			SyntaxNode cu = generator.CompilationUnit(
				generator.NamespaceImportDeclaration("System"),
				generator.NamespaceImportDeclaration("System.Collections.Generic"),
				generator.NamespaceDeclaration("SpirV", nodes));

			GenerateCode(cu, workspace, "../../../../SPIRV/SpirV.Meta.cs");
		}

		private static void GenerateCode(SyntaxNode node, Workspace workspace,
			string path)
		{
			node = Formatter.Format(node, workspace);

			System.IO.File.WriteAllText(path,
				node.ToFullString());
		}

		private static void CreateSpirvMeta(JsonElement jr,
			XmlDocument doc, SyntaxGenerator generator, IList<SyntaxNode> nodes)
		{
			Meta meta = new Meta(jr.GetProperty("spv").GetProperty("meta"), doc.SelectSingleNode("/registry/ids") as XmlElement);

			nodes.Add(meta.ToSourceFragment(generator));
		}
	}
}
