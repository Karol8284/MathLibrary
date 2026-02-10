using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MathLibrary.Arithmetic
{
    public class Basic
    {
        public static T Sum<T>(params T[] values) where T : INumber<T>
        {
            T sum = T.Zero;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum;
        }
        public static T Sub<T>(params T[] values) where T : INumber<T>
        {
            if (values.Length == 0)
                return T.Zero;
            T result = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                result -= values[i];
            }
            return result;
        }
        public static T Mul<T>(params T[] values) where T : INumber<T>
        {
            if (values.Length == 0)
                return T.One;
            T result = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                result *= values[i];
            }
            return result;
        }
        public static T Div<T>(params T[] values) where T : INumber<T>
        {
            if (values.Length == 0)
                return T.One;
            T result = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                result /= values[i];
            }
            return result;
        }
        public static T Min<T>(params T[] values) where T : INumber<T>
        {
            if (values.Length == 0)
                return T.Zero;

            T min = values[0];
            foreach (var v in values)
                if (v < min)
                    min = v;

            return min;
        }
        public static T Max<T>(params T[] values) where T : INumber<T>
        {
            if (values.Length == 0)
                return T.Zero;

            T max = values[0];
            foreach (var v in values)
                if (v > max)
                    max = v;

            return max;
        }
        public static T Abs<T>(T value) where T : INumber<T>
        {
            return T.Abs(value);
        }
        public static T Pow<T>(T value, T power) where T : INumber<T>
        {
            double v = double.CreateChecked(value);
            double p = double.CreateChecked(power);
            
            double result = Math.Pow(v, p);
            return T.CreateChecked(result);
        }
    }
}