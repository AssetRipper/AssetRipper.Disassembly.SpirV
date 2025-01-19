using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace SpirV;

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
