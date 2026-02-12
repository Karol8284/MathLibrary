using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MathLibrary.Tests.Helper
{
    public class MatyLibraryAssert
    {
        public static void Sum<T>(T expected, params T[] values) where T : INumber<T>
        {
            var result = MathLibrary.Maty.Sum(values);
            Assert.Equal(expected, result);
        }
        public static void Sub<T>(T expected, params T[] values) where T : INumber<T>
        {
            var result = MathLibrary.Maty.Sub(values);
            Assert.Equal(expected, result);
        }
        public static void Mul<T>(T expected, params T[] values) where T : INumber<T>
        {
            var result = MathLibrary.Maty.Mul(values);
            Assert.Equal(expected, result);
        }
        public static void Div<T>(T expected, params T[] values) where T : INumber<T>
        {
            var result = MathLibrary.Maty.Div(values);
            Assert.Equal(expected, result);
        }
        public static void Min<T>(T expected, params T[] values) where T : INumber<T>
        {
            var result = MathLibrary.Maty.Min(values);
            Assert.Equal(expected, result);
        }
        public static void Max<T>(T expected, params T[] values) where T : INumber<T>
        {
            var result = MathLibrary.Maty.Max(values);
            Assert.Equal(expected, result);
        }
        public static void Abs<T>(T expected, T value) where T : INumber<T>
        {
            var result = MathLibrary.Maty.Abs(value);
            Assert.Equal(expected, result);
        }
        public static void Sqrt<T>(T expected, T value) where T : INumber<T>
        {
            var result = MathLibrary.Maty.Sqrt(value);
            Assert.Equal(expected, result);
        }
        public static void Pow<T>(T expected, T x, T y) where T : INumber<T>
        {
            var result = MathLibrary.Maty.Pow(x, y);
            Assert.Equal(expected, result);
        }
        public static void Exp<T>(T expected, T value) where T : INumber<T>
        {
            var result = MathLibrary.Maty.Exp(value);
            Assert.Equal(expected, result);
        }
        public static void Log<T>(T expected, T value) where T : INumber<T>
        {
            var result = MathLibrary.Maty.Log(value);
            Assert.Equal(expected, result);
        }
        public static void Log10<T>(T expected, T value) where T : INumber<T>
        {
            var result = MathLibrary.Maty.Log10(value);
            Assert.Equal(expected, result);
        }

    }
}
