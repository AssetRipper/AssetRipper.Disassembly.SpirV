using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
		GenerateCode(Meta.Load().ToCompilationUnit(), "../../../../SPIRV/SpirV.Meta.cs");
		ProcessGrammars();
	}

	private static void ProcessInstructions(IReadOnlyList<InstructionItem> instructions,
		IReadOnlyDictionary<string, OperatorKind> knownEnumerands,
		List<SyntaxNode> nodes)
	{
		StringBuilder sb = new();

		sb.AppendLine("public enum OpCode {");
		foreach (InstructionItem instruction in instructions)
		{
			sb.AppendLine($"{instruction.Name} = {instruction.Id},");
		}
		sb.AppendLine("}");

		sb.AppendLine("public static class Instructions {");

		sb.Append("public static Instruction ToInstruction(this OpCode code) => code switch {");
		foreach (InstructionItem instruction in instructions)
		{
			sb.AppendLine($"OpCode.{instruction.Name} => {instruction.Name}.Instance,");
		}
		sb.AppendLine("_ => throw new ArgumentOutOfRangeException(nameof(code)),");
		sb.AppendLine("};");

		sb.AppendLine("}");

		foreach (InstructionItem instruction in instructions)
		{
			CreateInstructionClass(sb, instruction, knownEnumerands);
		}

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
		sb.AppendLine($"public sealed class {instruction.Name} : Instruction");
		sb.AppendLine("{");

		sb.AppendLine($"private {instruction.Name}() {{}}");

		sb.AppendLine($"public override string Name => nameof({instruction.Name});");
		sb.AppendLine($"public override OpCode Code => OpCode.{instruction.Name};");

		sb.AppendLine($"public static {instruction.Name} Instance {{ get; }} = new();");

		if (instruction.Operands != null)
		{
			sb.AppendLine("public override IReadOnlyList<Operand> Operands => _operands;");
			sb.AppendLine("private static readonly Operand[] _operands = [");
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
			sb.AppendLine("];");
		}

		sb.AppendLine("}");
	}

	private static void ProcessEnumTypes(IReadOnlyDictionary<string, OperatorKind> knownEnumerands, List<SyntaxNode> nodes)
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

			SyntaxTree tree = CSharpSyntaxTree.ParseText(sb.ToString());
			foreach (SyntaxNode node in tree.GetRoot().ChildNodes())
			{
				nodes.Add(node.NormalizeWhitespace());
			}
		}
	}

	private static void ProcessParameterTypes(IReadOnlyDictionary<string, OperatorKind> knownEnumerands, List<SyntaxNode> nodes)
	{
		foreach (OperatorKind ok in knownEnumerands.Values)
		{
			StringBuilder sb = new();

			sb.AppendLine($"public class {ok.Kind}ParameterFactory : ParameterFactory");
			sb.AppendLine("{");
			foreach (OperatorKindEnumerant e in ok.Enumerants)
			{
				if (e.Parameters == null)
					continue;
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
		IReadOnlyList<OperatorKindEnumerant> enumerants, StringBuilder sb)
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

	private static void ProcessGrammars()
	{
		JsonDocument doc = JsonDocument.Parse(File.ReadAllText("spirv.core.grammar.json"));

		IReadOnlyDictionary<string, OperatorKind> knownEnumerands = OperatorKind.ParseList(doc.RootElement.GetProperty("operand_kinds")).ToDictionary(a => a.Kind, a => a);
		IReadOnlyList<InstructionItem> instructions = InstructionItem.ParseList(doc.RootElement.GetProperty("instructions"));

		// Enums
		{
			List<SyntaxNode> nodes = [];
			ProcessEnumTypes(knownEnumerands, nodes);

			CompilationUnitSyntax cu = CreateCompilationUnit(
				[
					SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")),
				],
				[
					SyntaxFactory.FileScopedNamespaceDeclaration(SyntaxFactory.ParseName("SpirV")),
					..nodes.Cast<MemberDeclarationSyntax>()
				]);

			GenerateCode(cu, "../../../../SPIRV/SpirV.Enums.cs");
		}

		// Parameters
		{
			List<SyntaxNode> nodes = [];
			ProcessParameterTypes(knownEnumerands, nodes);

			CompilationUnitSyntax cu = CreateCompilationUnit(
				[
					SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Collections.Generic")),
				],
				[
					SyntaxFactory.FileScopedNamespaceDeclaration(SyntaxFactory.ParseName("SpirV")),
					..nodes.Cast<MemberDeclarationSyntax>()
				]);

			GenerateCode(cu, "../../../../SPIRV/SpirV.Parameters.cs");
		}

		// Instructions
		{
			List<SyntaxNode> nodes = [];
			ProcessInstructions(instructions, knownEnumerands, nodes);

			CompilationUnitSyntax cu = CreateCompilationUnit(
				[
					SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")),
					SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Collections.Generic")),
				],
				[
					SyntaxFactory.FileScopedNamespaceDeclaration(SyntaxFactory.ParseName("SpirV")),
					..nodes.Cast<MemberDeclarationSyntax>()
				]);

			GenerateCode(cu, "../../../../SPIRV/SpirV.Instructions.cs");
		}
	}

	private static void GenerateCode(SyntaxNode node, string path)
	{
		SyntaxNode formatted = Formatter.Format(node, new AdhocWorkspace());
		string formattedCode = formatted.ToFullString();
		string code = formattedCode.Replace("    ", "\t");

		File.WriteAllText(path, code);
	}

	private static CompilationUnitSyntax CreateCompilationUnit(IEnumerable<UsingDirectiveSyntax> usingDirectives, IEnumerable<MemberDeclarationSyntax> members)
	{
		return SyntaxFactory.CompilationUnit()
			.WithUsings(SyntaxFactory.List(usingDirectives))
			.WithMembers(SyntaxFactory.List(members));
	}
}
