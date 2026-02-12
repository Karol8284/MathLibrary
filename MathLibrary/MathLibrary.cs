using MathLibrary.Algebra;
using MathLibrary.Arithmetic;
using System.Numerics;

namespace MathLibrary
{
    public static class Maty
    {
        // Start Aritmetic.Basic.cs
        public static T Sum<T>(params T[] values) where T : INumber<T>
        {
            return BasicArithmetic.Sum(values);
        }
        public static T Sub<T>(params T[] values) where T : INumber<T>
        {
            return BasicArithmetic.Sub(values);
        }
        public static T Mul<T>(params T[] values) where T : INumber<T>
        {
            return BasicArithmetic.Mul(values);
        }
        public static T Div<T>(params T[] values) where T : INumber<T>
        {
            return BasicArithmetic.Div(values);
        }
        public static T Min<T>(params T[] values) where T : INumber<T>
        {
            return BasicArithmetic.Min(values);
        }
        public static T Max<T>(params T[] values) where T : INumber<T>
        {
            return BasicArithmetic.Max(values);
        }
        public static T Abs<T>(T value) where T : INumber<T>
        {
            return BasicArithmetic.Abs(value);
        }
        // END Aritmetic.Basic.cs

        // START Algebra
        // START BasicAlgebra.cs
        public static T Sqrt<T>(T x) where T : INumber<T>
        {
            return BasicAlgebra.Sqrt(x);
        }
        public static T Pow<T>(T x, T y) where T : INumber<T>
        {
            return BasicAlgebra.Pow(x, y);
        }
        public static T Exp<T>(T x) where T : INumber<T>
        {
            return BasicAlgebra.Exp(x);
        }
        public static T Log<T>(T x) where T : INumber<T>
        {
            return BasicAlgebra.Log(x);
        }
        public static T Log10<T>(T x) where T : INumber<T>
        {
            return BasicAlgebra.Log10(x);
        }

        // END Algebra.Basic.cs

        // START Geometry
        // END Geometry

        // START Algebra.Basic.cs
        // END Algebra.Basic.cs

        // START Algebra.Basic.cs
        // END Algebra.Basic.cs



    }
}
