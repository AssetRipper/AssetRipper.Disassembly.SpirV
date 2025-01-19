using System.Text.Json;

namespace SpirV;

internal static class JsonElementExtensions
{
	public static uint ParseEnumValue(this JsonElement value)
	{
		if (value.ValueKind == JsonValueKind.String)
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
}
