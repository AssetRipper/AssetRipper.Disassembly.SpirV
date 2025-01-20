using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml;

namespace SpirV;

class Meta
{
	public Meta(JsonElement meta, XmlElement ids)
	{
		MagicNumber = meta.GetProperty(nameof(MagicNumber)).GetUInt32();
		Version = meta.GetProperty(nameof(Version)).GetUInt32();
		Revision = meta.GetProperty(nameof(Revision)).GetUInt32();
		OpCodeMask = meta.GetProperty(nameof(OpCodeMask)).GetUInt32();
		WordCountShift = meta.GetProperty(nameof(WordCountShift)).GetUInt32();

		foreach (XmlElement toolId in ids.SelectNodes("id")!)
		{
			ToolInfo ti = new()
			{
				vendor = toolId.GetAttribute("vendor")
			};

			if (toolId.HasAttribute("tool"))
			{
				ti.name = toolId.GetAttribute("tool");
			}

			toolInfos_.Add(int.Parse(toolId.GetAttribute("value")), ti);
		}
	}

	public ClassDeclarationSyntax ToClassDeclaration()
	{
		List<MemberDeclarationSyntax> members =
		[
			CreateProperty("MagicNumber", MagicNumber),
			CreateProperty("Version", Version),
			CreateProperty("Revision", Revision),
			CreateProperty("OpCodeMask", OpCodeMask),
			CreateProperty("WordCountShift", WordCountShift)
		];

		StringBuilder sb = new();

		sb.Append("public static IReadOnlyDictionary<int, ToolInfo> Tools { get; } = new Dictionary<int, ToolInfo>()\n{");

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

		sb.AppendLine("""
			public class ToolInfo { 
							public ToolInfo (string vendor)
							{
								Vendor = vendor;
								Name = null;
							}

							public ToolInfo (string vendor, string name)
							{
								Vendor = vendor;
								Name = name;
							}

							public string? Name {get;} 
							public string Vendor {get;} 
						}
			""");

		SyntaxTree tree = CSharpSyntaxTree.ParseText(sb.ToString());
		foreach (SyntaxNode node in tree.GetRoot().ChildNodes())
		{
			members.Add((MemberDeclarationSyntax)node);
		}

		return SyntaxFactory.ClassDeclaration("Meta").AddMembers(members.ToArray()).NormalizeWhitespace();
	}

	private static PropertyDeclarationSyntax CreateProperty(string name, uint value)
	{
		return SyntaxFactory.PropertyDeclaration(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.UIntKeyword)), name)
			.WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)))
			.WithExpressionBody(SyntaxFactory.ArrowExpressionClause(SyntaxFactory.LiteralExpression(SyntaxKind.NumericLiteralExpression, SyntaxFactory.Literal(value))))
			.WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));
	}

	public CompilationUnitSyntax ToCompilationUnit()
	{
		return SyntaxFactory.CompilationUnit()
			.WithUsings(SyntaxFactory.List([SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Collections.Generic"))]))
			.WithMembers(SyntaxFactory.List<MemberDeclarationSyntax>(
			[
				SyntaxFactory.FileScopedNamespaceDeclaration(SyntaxFactory.ParseName("AssetRipper.Disassembly.SpirV")),
				ToClassDeclaration(),
			]));
	}

	public static Meta Load()
	{
		JsonDocument doc = JsonDocument.Parse(File.ReadAllText("spirv.json"));

		XmlDocument xmlDoc = new();
		xmlDoc.Load("spir-v.xml");

		return new Meta(doc.RootElement.GetProperty("spv").GetProperty("meta"), (XmlElement)xmlDoc.SelectSingleNode("/registry/ids")!);
	}

	public uint MagicNumber { get; }
	public uint Version { get; }
	public uint Revision { get; }
	public uint OpCodeMask { get; }
	public uint WordCountShift { get; }

	class ToolInfo
	{
		public string? vendor;
		public string? name;
	}

	readonly Dictionary<int, ToolInfo> toolInfos_ = [];
}
