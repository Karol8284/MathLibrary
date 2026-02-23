using System.Numerics;

namespace MathLibrary.Algebra
{
    public class BasicAlgebra
    {
        public static T Sqrt<T>(T x) where T : INumber<T>
        {
            double v = double.CreateChecked(x);
            return T.CreateChecked(Math.Sqrt(v));
        }

        public static T Pow<T>(T x, T y) where T : INumber<T>
        {
            double a = double.CreateChecked(x);
            double b = double.CreateChecked(y);
            return T.CreateChecked(Math.Pow(a, b));
        }

        public static T Exp<T>(T x) where T : INumber<T>
        {
            double v = double.CreateChecked(x);
            return T.CreateChecked(Math.Exp(v));
        }

        public static T Log<T>(T x) where T : INumber<T>
        {
            double v = double.CreateChecked(x);
            return T.CreateChecked(Math.Log(v));
        }

        public static T Log10<T>(T x) where T : INumber<T>
        {
            double v = double.CreateChecked(x);
            return T.CreateChecked(Math.Log10(v));
        }

    }
}
