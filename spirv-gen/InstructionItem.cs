using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace SpirV;

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
