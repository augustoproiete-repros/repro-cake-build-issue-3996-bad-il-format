﻿using Java.Lang;

namespace Kotlin.Ranges
{
	unsafe partial class ULongRange : IClosedRange
	{
		Object IClosedRange.EndInclusive => (long)EndInclusive;

		Object IClosedRange.Start => (long)Start;

		bool IClosedRange.Contains(Object value) => Contains((ulong)(long)value);
	}

	unsafe partial class UIntRange : IClosedRange
	{
		Object IClosedRange.EndInclusive => (int)EndInclusive;

		Object IClosedRange.Start => (int)Start;

		bool IClosedRange.Contains(Object value) => Contains((uint)(int)value);
	}

	unsafe partial class UIntRange : IOpenEndRange
	{
		Object IOpenEndRange.EndExclusive => (int)EndInclusive;
		Object IOpenEndRange.Start => (int)Start;

		bool IOpenEndRange.Contains(Object value) => Contains((uint)(int)value);
	}

	unsafe partial class ULongRange : IOpenEndRange
	{
		Object IOpenEndRange.EndExclusive => (int)EndInclusive;
		Object IOpenEndRange.Start => (int)Start;

		bool IOpenEndRange.Contains(Object value) => Contains((uint)(int)value);
	}
}
