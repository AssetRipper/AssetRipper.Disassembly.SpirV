using System.Collections.Generic;

namespace SpirV;

public enum OperandQuantifier
{
	// 1
	Default,
	// 0 or 1
	Optional,
	// 0+
	Varying
}

public class Operand
{
	public string? Name { get; }
	public OperandType Type { get; }
	public OperandQuantifier Quantifier { get; }

	public Operand(OperandType kind, string? name, OperandQuantifier quantifier)
	{
		Name = name;
		Type = kind;
		Quantifier = quantifier;
	}
}

public abstract class Instruction
{
	public abstract string Name { get; }
	public abstract OpCode Code { get; }
	public virtual IReadOnlyList<Operand> Operands => [];

	private protected Instruction()
	{
	}
}
