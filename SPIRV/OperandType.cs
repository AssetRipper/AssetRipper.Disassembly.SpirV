using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AssetRipper.Disassembly.SpirV;

public class OperandType
{
	public virtual bool ReadValue(IReadOnlyList<uint> words,
		out object value, out int wordsUsed)
	{
		// This returns the dynamic type
		value = GetType();
		wordsUsed = 1;

		return true;
	}

	public override string ToString()
	{
		return GetType().Name;
	}
}

public class Literal : OperandType
{

}

public class LiteralNumber : Literal
{
}

// The SPIR-V JSON file uses only literal integers
public class LiteralInteger : LiteralNumber
{
	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		value = words[0];
		wordsUsed = 1;

		return true;
	}
}

public class LiteralString : Literal
{
	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		// This is just a fail-safe -- the loop below must terminate
		wordsUsed = 1;

		List<byte> bytes = [];
		for (int i = 0; i < words.Count; ++i)
		{
			byte[] wordBytes = BitConverter.GetBytes(words[i]);

			int zeroOffset = -1;
			for (int j = 0; j < wordBytes.Length; ++j)
			{
				if (wordBytes[j] == 0)
				{
					zeroOffset = j;
					break;
				}
				else
				{
					bytes.Add(wordBytes[j]);
				}
			}

			if (zeroOffset != -1)
			{
				wordsUsed = i + 1;
				break;
			}
		}

		value = Encoding.UTF8.GetString(bytes.ToArray());

		return true;
	}
}

public class LiteralContextDependentNumber : Literal
{
	// This is handled during parsing by ConvertConstant
}

public class LiteralExtInstInteger : Literal
{
	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		value = words[0];
		wordsUsed = 1;

		return true;
	}
}

public class LiteralSpecConstantOpInteger : Literal
{
	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		List<ObjectReference> result = [];
		foreach (uint w in words)
		{
			result.Add(new ObjectReference(w));
		}

		value = result;
		wordsUsed = words.Count;

		return true;
	}
}

public class Parameter
{
	public virtual IReadOnlyList<OperandType> OperandTypes => [];
}

public class ParameterFactory
{
	public virtual Parameter? CreateParameter(object value) => null;
}

public class EnumType<T> : EnumType<T, ParameterFactory> where T : unmanaged, Enum
{
}

public class EnumType<T, U> : OperandType where T : unmanaged, Enum where U : ParameterFactory, new()
{
	private readonly U parameterFactory_ = new();
	public System.Type EnumerationType => typeof(T);

	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		int wordsUsedForParameters = 0;

		if (typeof(T).GetCustomAttributes<FlagsAttribute>().Any())
		{
			Dictionary<uint, List<object>> result = [];
			foreach (T enumValue in Enum.GetValues<T>())
			{
				uint bit = enumValue.ToUInt32();

				// bit == 0 and words [0] == 0 handles the 0x0 = None cases
				if ((words[0] & bit) != 0 || (bit == 0 && words[0] == 0))
				{
					Parameter? p = parameterFactory_.CreateParameter(bit);

					List<object> resultItems = [];

					if (p != null)
					{
						for (int j = 0; j < p.OperandTypes.Count; ++j)
						{
							p.OperandTypes[j].ReadValue(
								words.Skip(1 + wordsUsedForParameters).ToList(),
								out object pValue, out int pWordsUsed);
							wordsUsedForParameters += pWordsUsed;
							resultItems.Add(pValue);
						}
					}

					result[bit] = resultItems;
				}
			}

			value = new BitEnumOperandValue<T>(result);
		}
		else
		{
			List<object> resultItems = [];
			Parameter? p = parameterFactory_.CreateParameter(words[0]);
			if (p != null)
			{
				for (int j = 0; j < p.OperandTypes.Count; ++j)
				{
					p.OperandTypes[j].ReadValue(
						words.Skip(1 + wordsUsedForParameters).ToList(),
						out object pValue, out int pWordsUsed);
					wordsUsedForParameters += pWordsUsed;
					resultItems.Add(pValue);
				}
			}

			value = new ValueEnumOperandValue<T>((T)(object)words[0], resultItems);
		}

		wordsUsed = wordsUsedForParameters + 1;

		return true;
	}
}

public class IdScope : OperandType
{
	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		value = (Scope)words[0];
		wordsUsed = 1;

		return true;
	}
}

public class IdMemorySemantics : OperandType
{
	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		value = (MemorySemantics)words[0];
		wordsUsed = 1;

		return true;
	}
}

public class IdType : OperandType
{
	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		value = words[0];
		wordsUsed = 1;

		return true;
	}
}

public class IdResult : IdType
{
	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		value = new ObjectReference(words[0]);
		wordsUsed = 1;

		return true;
	}
}

public class IdResultType : IdType
{
}

public class IdRef : IdType
{
	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		value = new ObjectReference(words[0]);
		wordsUsed = 1;

		return true;
	}
}

public class PairIdRefIdRef : OperandType
{
	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		value = new { Variable = new ObjectReference(words[0]), Parent = new ObjectReference(words[1]) };
		wordsUsed = 2;
		return true;
	}
}

public class PairIdRefLiteralInteger : OperandType
{
	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		value = new { Type = new ObjectReference(words[0]), Member = words[1] };
		wordsUsed = 2;
		return true;
	}
}

public class PairLiteralIntegerIdRef : OperandType
{
	public override bool ReadValue(IReadOnlyList<uint> words, out object value, out int wordsUsed)
	{
		value = new { Selector = words[0], Label = new ObjectReference(words[1]) };
		wordsUsed = 2;
		return true;
	}
}
