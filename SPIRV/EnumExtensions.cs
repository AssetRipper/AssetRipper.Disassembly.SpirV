using System;
using System.Runtime.CompilerServices;

namespace SpirV;

internal static class EnumExtensions
{
	public static uint ToUInt32<T>(this T value) where T : unmanaged, Enum
	{
		return Unsafe.SizeOf<T>() == sizeof(uint)
			? Unsafe.As<T, uint>(ref value)
			: ThrowInvalidCastException();

		static uint ThrowInvalidCastException()
		{
			throw new InvalidCastException();
		}
	}
}
