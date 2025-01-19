using System;

namespace SpirV;

class Reader
{
	public Reader(System.IO.BinaryReader reader)
	{
		reader_ = reader;

		uint magicNumber = reader_.ReadUInt32();

		if (magicNumber == Meta.MagicNumber)
		{
			littleEndian_ = true;
		}
		else if (Reverse(magicNumber) == Meta.MagicNumber)
		{
			littleEndian_ = false;
		}
		else
		{
			throw new Exception("Invalid magic number");
		}
	}

	public uint ReadWord()
	{
		if (littleEndian_)
		{
			return reader_.ReadUInt32();
		}
		else
		{
			return Reverse(reader_.ReadUInt32());
		}
	}

	private static uint Reverse(uint u)
	{
		return (u & 0xFFU) << 24 |
				(u & 0xFF00U) << 8 |
				(u >> 8) & 0xFF00U |
				(u >> 24);
	}

	private readonly System.IO.BinaryReader reader_;
	readonly bool littleEndian_;
}
