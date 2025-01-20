using System;
using System.Collections.Generic;
using System.Text;

namespace SpirV;

public struct ModuleHeader
{
	public Version Version { get; set; }
	public string GeneratorVendor { get; set; }
	public string? GeneratorName { get; set; }
	public int GeneratorVersion { get; set; }
	public uint Bound { get; set; }
	public uint Reserved { get; set; }
}

[Flags]
public enum DisassemblyOptions
{
	None,
	ShowTypes,
	ShowNames,
	Default = ShowTypes | ShowNames
}

public static class Disassembler
{
	public static string Disassemble(Module module)
	{
		return Disassemble(module, DisassemblyOptions.Default);
	}

	public static string Disassemble(Module module, DisassemblyOptions options)
	{
		StringBuilder sb = new();

		sb.Append("; SPIR-V\n");
		sb.Append($"; Version: {module.Header.Version}\n");
		if (module.Header.GeneratorName == null)
		{
			sb.Append($"; Generator: {module.Header.GeneratorName}; {module.Header.GeneratorVersion}\n");
		}
		else
		{
			sb.Append($"; Generator: {module.Header.GeneratorVendor} {module.Header.GeneratorName}; {module.Header.GeneratorVersion}\n");
		}
		sb.Append($"; Bound: {module.Header.Bound}\n");
		sb.Append($"; Schema: {module.Header.Reserved}\n");

		List<string> lines = [];
		foreach (ParsedInstruction i in module.Instructions)
		{
			PrintInstruction(sb, i, options);
			lines.Add(sb.ToString());
			sb.Clear();
		}

		int longestPrefix = 0;
		foreach (string line in lines)
		{
			longestPrefix = Math.Max(longestPrefix, line.IndexOf('='));
		}

		foreach (string line in lines)
		{
			if (line.StartsWith(';'))
			{
				sb.AppendLine(line);
			}
			else
			{
				if (line.Contains('='))
				{
					string[] parts = line.Split('=');
					System.Diagnostics.Debug.Assert(parts.Length == 2);
					sb.Append(parts[0].PadLeft(longestPrefix));
					sb.Append(" = ");
					sb.Append(parts[1]);
				}
				else
				{
					sb.Append("".PadLeft(longestPrefix + 4));
					sb.Append(line);
				}

				sb.AppendLine();
			}
		}

		return sb.ToString();
	}

	private static void PrintInstruction(StringBuilder sb, ParsedInstruction instruction, DisassemblyOptions options)
	{
		if (instruction.Operands.Count == 0)
		{
			sb.Append(instruction.Instruction.Name);
			return;
		}

		int currentOperand = 0;
		if (instruction.Instruction.Operands[currentOperand].Type is IdResultType)
		{
			if (options.HasFlag(DisassemblyOptions.ShowTypes))
			{
				sb.Append(instruction.ResultType.ToString());
				sb.Append(' ');
			}

			++currentOperand;
		}

		if (currentOperand < instruction.Operands.Count &&
			instruction.Instruction.Operands[currentOperand].Type is IdResult)
		{
			if (!options.HasFlag(DisassemblyOptions.ShowNames) || string.IsNullOrWhiteSpace(instruction.Name))
			{
				PrintOperandValue(sb, instruction.Operands[currentOperand].Value, options);
			}
			else
			{
				sb.Append(instruction.Name);
			}
			sb.Append(" = ");

			++currentOperand;
		}

		sb.Append(instruction.Instruction.Name);
		sb.Append(' ');

		for (; currentOperand < instruction.Operands.Count; ++currentOperand)
		{
			PrintOperandValue(sb, instruction.Operands[currentOperand].Value, options);
			sb.Append(' ');
		}
	}

	private static void PrintOperandValue(StringBuilder sb, object value, DisassemblyOptions options)
	{
		if (value is System.Type t)
		{
			sb.Append(t.Name);
		}
		else if (value is string s)
		{
			sb.Append($"\"{s}\"");
		}
		else if (value is ObjectReference or)
		{
			if (options.HasFlag(DisassemblyOptions.ShowNames) && or.Reference != null && !string.IsNullOrWhiteSpace(or.Reference.Name))
			{
				sb.Append(or.Reference.Name);
			}
			else
			{
				sb.Append(or);
			}
		}
		else if (value is IBitEnumOperandValue beov)
		{
			PrintBitEnumValue(sb, beov, options);
		}
		else if (value is IValueEnumOperandValue veov)
		{
			PrintValueEnumValue(sb, veov, options);
		}
		else
		{
			sb.Append(value);
		}
	}

	private static void PrintBitEnumValue(StringBuilder sb, IBitEnumOperandValue enumOperandValue, DisassemblyOptions options)
	{
		foreach (uint key in enumOperandValue.Values.Keys)
		{
			sb.Append(enumOperandValue.EnumerationType.GetEnumName(key));

			List<object> value = enumOperandValue.Values[key];

			if (value.Count != 0)
			{
				sb.Append(' ');
				foreach (object v in value)
				{
					PrintOperandValue(sb, v, options);
				}
			}
		}
	}

	private static void PrintValueEnumValue(StringBuilder sb, IValueEnumOperandValue valueOperandValue, DisassemblyOptions options)
	{
		sb.Append(valueOperandValue.Key);
		if (valueOperandValue.Value is IReadOnlyList<object> valueList && valueList.Count > 0)
		{
			sb.Append(' ');
			foreach (object v in valueList)
			{
				PrintOperandValue(sb, v, options);
			}
		}
	}
}
