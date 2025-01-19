using System.Text.Json;

namespace SpirV;

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
