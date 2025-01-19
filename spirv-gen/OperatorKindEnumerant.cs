using System.Collections.Generic;

namespace SpirV;

class OperatorKindEnumerant
{
	public required string Name { get; set; }
	public required uint Value { get; set; }

	public List<string>? Parameters { get; set; }
}
