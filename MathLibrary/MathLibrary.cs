using MathLibrary.Arithmetic;
using System.Numerics;

namespace MathLibrary
{
    public static class Maty
    {
        public static T Sum<T>(params T[] values) where T : INumber<T>
        {
            return Basic.Sum(values);
        }
        public static T Sub<T>(params T[] values) where T : INumber<T>
        {
            return Basic.Sub(values);
        }
        public static T Mul<T>(params T[] values) where T : INumber<T>
        {
            return Basic.Mul(values);
        }
        public static T Div<T>(params T[] values) where T : INumber<T>
        {
            return Basic.Div(values);
        }
        public static T Min<T>(params T[] values) where T : INumber<T>
        {
            return Basic.Min(values);
        }
        public static T Max<T>(params T[] values) where T : INumber<T>
        {
            return Basic.Max(values);
        }
        public static T Abs<T>(T value) where T : INumber<T>
        {
            return Basic.Abs(value);
        }

    }
}
