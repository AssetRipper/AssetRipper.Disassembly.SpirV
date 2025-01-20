using System.Collections.Generic;
using System.Diagnostics;

namespace AssetRipper.Disassembly.SpirV;

public enum OperandQuantifier
{
	/// <summary>
	/// 1
	/// </summary>
	Default,
	/// <summary>
	/// 0 or 1
	/// </summary>
	Optional,
	/// <summary>
	/// 0+
	/// </summary>
	Varying
}

public record Operand(OperandType Type, string? Name, OperandQuantifier Quantifier)
{
	public override string ToString()
	{
		return Name is null ? Type.ToString() : $"{Type} {Name}";
	}
}

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public abstract class Instruction
{
	public abstract string Name { get; }
	public abstract OpCode Code { get; }
	public virtual IReadOnlyList<Operand> Operands => [];

	private protected Instruction()
	{
	}

	private string GetDebuggerDisplay()
	{
		return Name;
	}
}
