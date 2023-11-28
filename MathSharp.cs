using System;
using System.Collections.Generic;
using System.Linq;
// Derivation
// Differentiation
// Integration
// Functions
// Gamma
// Cubic Functions Solving
// e ^ Matrix
// Perpendicular Vector3D
// Eigenvalues
// Eigenvectors
// Circle
// Ellipse
// Parabola
// Hyperbola
// RGB + RGB
// CMYK + CMYK
// RGB + CMYK
// RGB & CMYK are broken
// Numeric System descriptions are broken
// planes
/// <summary>
/// A well devoloped Mathematics library that contains almost
/// everything you may need, done by "@Griny".
/// </summary>
namespace MathSharp
{
    /// <summary>
    /// Contains all the basics of Mathematics.
    /// </summary>
    public static class Mathematics
    {
        #region #Constants
        /// <summary>
        /// The irrational number π, (180 in Degrees).
        /// </summary>
        public const decimal Pi = 3.1415926535897932384626433832795028841971m;
        /// <summary>
        /// The irrational number π, (180 in Degrees).
        /// </summary>
        public const decimal π = Pi;
        /// <summary>
        /// The irrational number τ, (360 in Degrees).
        /// </summary>
        public const decimal Tau = π * 2;
        /// <summary>
        /// The irrational number τ, (360 in Degrees).
        /// </summary>
        public const decimal τ = Tau;

        /// <summary>
        /// The irrational number of Euler, e.
        /// </summary>
        public const decimal Euler = 2.71828182845904523536m;
        /// <summary>
        /// The irrational number of Euler, e.
        /// </summary>
        public const decimal e = Euler;

        /// <summary>
        /// The Golden Ratio of the Fibonacci Serie.
        /// </summary>
        public const decimal GoldenRatio = 1.61803398874989m;

        /// <summary>
        /// Natural Logarithm of 2, used in calculating Natural Logarithm for the rest of the numbers.
        /// </summary>
        private const decimal Ln2 = 0.69314718055994530941723212145818m;

        /// <summary>
        /// Represents the value of 'Not a Number'.
        /// </summary>
        public const double NaN = 0.0d / 0.0d;
        /// <summary>
        /// Represents the highest value.
        /// </summary>
        public const double PositiveInfinity = +1.0d / 0d;
        /// <summary>
        /// Represents the lowest value.
        /// </summary>
        public const double NegativeInfinity = -1.0d / 0d;

        /// <summary>
        /// Represents the lowest value that is greater than Zero.
        /// </summary>
        public const double Epsilon = 4.94065645841247E-324;
        /// <summary>
        /// Represents the lowest value that is greater than Zero.
        /// </summary>
        public const double ε = Epsilon;

        /// <summary>
        /// Represents the value of 1 on the Imaginary Numbers Axis, or in other words,
        /// the squrare root of -1 in the Real Numbers Axis.
        /// </summary>
        public static Imaginary i { get { return Imaginary.i; } }
        /// <summary>
        /// Represents the value of 1 on the Lateral Numbers Axis, or in other words,
        /// the squrare root of -1 in the Real Numbers Axis.
        /// </summary>
        public static Lateral j { get { return Lateral.j; } }
        /// <summary>
        /// Represents the value of 1 on the Lateral Numbers Axis, or in other words,
        /// the squrare root of -1 in the Real Numbers Axis.
        /// </summary>
        public static Lateral k { get { return Lateral.k; } }

        /// <summary>
        /// A Square Diagonal Matrix were all its diagonal elements are ones.
        /// </summary>
        /// <typeparam name="Type">The type of the Matrix.</typeparam>
        /// <param name="rank">The size of the Matrix, (both width and height).</param>
        /// <returns>A Square Diagonal Matrix were all its diagonal elements are ones.</returns>
        public static Matrix<Type> IdenticalMatrix<Type>(int rank) where Type : IFormattable
        => Matrix<Type>.IdenticalMatrix(rank);
        /// <summary>
        /// A Square Matrix that represents the meaning of 'dx/x', or the Derivation in genral.
        /// </summary>
        /// <param name="rank">The size of the Matrix, (both width and height).</param>
        /// <returns>A Square Matrix that represents the meaning of 'dx/x', or the Derivation in genral.</returns>
        public static Matrix<Type> DerivationMatrix<Type>(int rank) where Type : IFormattable
        => Matrix<Type>.DerivationMatrix(rank);
        /// <summary>
        /// A two-by-two Matrix that represents the Imaginary Number 'i', which stands for the square root of -1, or in that case square root of -I, (minus the two-by-two Identical Matrix).
        /// </summary>
        public static Matrix2<double> iMatrix => Matrix2<double>.iMatrix;
        #endregion

        #region #Numeric Functions
        /// <summary>
        /// Summates a function from a point A into a point B.
        /// </summary>
        /// <param name="start">The point A.</param>
        /// <param name="end">The point B.</param>
        /// <param name="function">The function that will be multicalculated.</param>
        /// <returns>The value of the function multicalculated (B - A) times.</returns>
        public static double Summation(int start, int end, Func<double, double, double> function)
        {
            double value = 0.0d;
            for (int i = start, j = start; i <= end; i++, j++)
            { value += function(i, j); }
            return value;
        }
        /// <summary>
        /// Summates a function from a point A into a point B.
        /// </summary>
        /// <param name="start">The point A.</param>
        /// <param name="end">The point B.</param>
        /// <param name="function">The function that will be multicalculated.</param>
        /// <returns>The value of the function multicalculated (B - A) times.</returns>
        public static double Summation(int start, int end, Func<double, double> function)
        {
            double value = 0.0d;
            for (int i = start; i <= end; i++)
            { value += function(i); }
            return value;
        }
        /// <summary>
        /// Summates numbers from a point A into a point B.
        /// </summary>
        /// <param name="start">The point A.</param>
        /// <param name="end">The point B.</param>
        /// <returns>The value of the numbers multicalculated (B - A) times.</returns>
        public static double Summation(int start, int end)
        {
            double value = 0.0d;
            for (int i = start; i <= end; i++)
            { value += i; }
            return value;
        }
        /// <summary>
        /// Productes a function from a point A into a point B.
        /// </summary>
        /// <param name="start">The point A.</param>
        /// <param name="end">The point B.</param>
        /// <param name="function">The function that will be multicalculated.</param>
        /// <returns>The value of the function multicalculated (B - A) times.</returns>
        public static double Production(int start, int end, Func<double, double, double> function)
        {
            double value = 1.0d;
            for (int i = start, j = start; i <= end; i++, j++)
            { value *= function(i, j); }
            return value;
        }
        /// <summary>
        /// Productes a function from a point A into a point B.
        /// </summary>
        /// <param name="start">The point A.</param>
        /// <param name="end">The point B.</param>
        /// <param name="function">The function that will be multicalculated.</param>
        /// <returns>The value of the function multicalculated (B - A) times.</returns>
        public static double Production(int start, int end, Func<double, double> function)
        {
            double value = 1.0d;
            for (int i = start; i <= end; i++)
            { value *= function(i); }
            return value;
        }
        /// <summary>
        /// Productes numbers from a point A into a point B.
        /// </summary>
        /// <param name="start">The point A.</param>
        /// <param name="end">The point B.</param>
        /// <returns>The value of the numbers multicalculated (B - A) times.</returns>
        public static double Production(int start, int end)
        {
            double value = 1.0d;
            for (int i = start; i <= end; i++)
            { value *= i; }
            return value;
        }
        /// <summary>
        /// Sigma Function is used to summate a function from a point A into a point B.
        /// </summary>
        /// <param name="start">The point A.</param>
        /// <param name="end">The point B.</param>
        /// <param name="function">The function that will be multicalculated.</param>
        /// <returns>The value of the function multicalculated (B - A) times.</returns>
        public static double SigmaFunction(int start, int end, Func<double, double, double> function)
        => Summation(start, end, function);
        /// <summary>
        /// Sigma Function is used to summate a function from a point A into a point B.
        /// </summary>
        /// <param name="start">The point A.</param>
        /// <param name="end">The point B.</param>
        /// <param name="function">The function that will be multicalculated.</param>
        /// <returns>The value of the function multicalculated (B - A) times.</returns>
        public static double SigmaFunction(int start, int end, Func<double, double> function)
        => Summation(start, end, function);
        /// <summary>
        /// Sigma Function is used to summate numbers from a point A into a point B.
        /// </summary>
        /// <param name="start">The point A.</param>
        /// <param name="end">The point B.</param>
        /// <returns>The value of the numbers multicalculated (B - A) times.</returns>
        public static double SigmaFunction(int start, int end)
        => Summation(start, end);
        /// <summary>
        /// Pi Function is used to producte a function from a point A into a point B.
        /// </summary>
        /// <param name="start">The point A.</param>
        /// <param name="end">The point B.</param>
        /// <param name="function">The function that will be multicalculated.</param>
        /// <returns>The value of the function multicalculated (B - A) times.</returns>
        public static double PiFunction(int start, int end, Func<double, double, double> function)
        => Production(start, end, function);
        /// <summary>
        /// Pi Function is used to producte a function from a point A into a point B.
        /// </summary>
        /// <param name="start">The point A.</param>
        /// <param name="end">The point B.</param>
        /// <param name="function">The function that will be multicalculated.</param>
        /// <returns>The value of the function multicalculated (B - A) times.</returns>
        public static double PiFunction(int start, int end, Func<double, double> function)
        => Production(start, end, function);
        /// <summary>
        /// Pi Function is used to producte numbers from a point A into a point B.
        /// </summary>
        /// <param name="start">The point A.</param>
        /// <param name="end">The point B.</param>
        /// <returns>The value of the numbers multicalculated (B - A) times.</returns>
        public static double PiFunction(int start, int end)
        => Production(start, end);
        #endregion

        #region #Simple Functions
        /// <summary>
        /// Accurates a number into a one digit number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The number with a one digit.</returns>
        public static decimal Accurate(decimal number)
        {
            int negative = number < 0 ? -1 : +1;
            number = Absolute(number);
            if (!number.ToString().Contains('.'))
            { return Convert.ToDecimal(number) * negative; }
            string real = number.ToString().Split('.')[0];
            string fraction = number.ToString().Split('.')[1];
            if (fraction.Length == 1)
            { return Convert.ToDecimal(real + "." + fraction) * negative; }
            fraction = fraction.Remove(2, fraction.Length - 2);
            if (fraction[0] == '9')
            {
                if (int.Parse(fraction[1].ToString()) >= 5)
                { return Round(number * negative); }
                else
                {
                    return int.Parse(fraction[1].ToString()) >= 5 ?
                        Convert.ToDecimal(real + "." + (int.Parse(fraction[0].ToString()) + 1).ToString()) * negative :
                        Convert.ToDecimal(real + "." + fraction[0]) * negative;
                }
            }
            else if (fraction[0] == '0' && int.Parse(fraction[1].ToString()) < 5)
            { return Convert.ToDecimal(real) * negative; }
            else
            {
                return int.Parse(fraction[1].ToString()) >= 5 ?
                       Convert.ToDecimal(real + "." + (int.Parse(fraction[0].ToString()) + 1).ToString()) * negative :
                       Convert.ToDecimal(real + "." + fraction[0]) * negative;
            }
        }
        /// <summary>
        /// Accurates a number into a one digit number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Accurate(ref decimal number)
        => number = Accurate(number);
        /// <summary>
        /// Accurates a number into the closest value.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="accuracy">The amount of accuracy.</param>
        /// <returns>A number that represents the accurate value of the selected number.</returns>
        public static decimal Accurate(decimal number, decimal accuracy)
        => Absolute(number - Accurate(number)) < accuracy ? Accurate(number) : number;
        /// <summary>
        /// Accurates a number into the closest value.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="accuracy">The amount of accuracy.</param>
        public static void Accurate(ref decimal number, decimal accuracy)
        => number = Accurate(number, accuracy);
        /// <summary>
        /// Accurates a number into a one digit number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The number with a one digit.</returns>
        public static double Accurate(double number)
        {
            int negative = number < 0 ? -1 : +1;
            number = Absolute(number);
            if (!number.ToString().Contains('.'))
            { return number * negative; }
            string real = number.ToString().Split('.')[0];
            string fraction = number.ToString().Split('.')[1];
            if (fraction.Length == 1)
            { return Convert.ToDouble(real + "." + fraction) * negative; }
            fraction = fraction.Remove(2, fraction.Length - 2);
            if (fraction[0] == '9')
            {
                if (int.Parse(fraction[1].ToString()) >= 5)
                { return Round(number * negative); }
                else
                {
                    return int.Parse(fraction[1].ToString()) >= 5 ?
                        Convert.ToDouble(real + "." + (int.Parse(fraction[0].ToString()) + 1).ToString()) * negative :
                        Convert.ToDouble(real + "." + fraction[0]) * negative;
                }
            }
            else if (fraction[0] == '0' && int.Parse(fraction[1].ToString()) < 5)
            { return Convert.ToDouble(real) * negative; }
            else
            {
                return int.Parse(fraction[1].ToString()) >= 5 ?
                       Convert.ToDouble(real + "." + (int.Parse(fraction[0].ToString()) + 1).ToString()) * negative :
                       Convert.ToDouble(real + "." + fraction[0]) * negative;
            }
        }
        /// <summary>
        /// Accurates a number into a one digit number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Accurate(ref double number)
        => number = Accurate(number);
        /// <summary>
        /// Accurates a number into the closest value.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="accuracy">The amount of accuracy.</param>
        /// <returns>A number that represents the accurate value of the selected number.</returns>
        public static double Accurate(double number, double accuracy)
        => Absolute(number - Accurate(number)) < accuracy ? Accurate(number) : number;
        /// <summary>
        /// Accurates a number into the closest value.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="accuracy">The amount of accuracy.</param>
        public static void Accurate(ref double number, double accuracy)
        => number = Accurate(number, accuracy);
        /// <summary>
        /// Returns the smallest integer that is close to a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The smallest integer that is close to the selected number.</returns>
        public static long Floor(decimal number)
        {
            if (IsFraction(number))
            {
                string stringValue = number.ToString().Split('.')[0];
                while (stringValue.Length > 16) { stringValue = stringValue.Remove(stringValue.Length - 1, 1); }
                return long.Parse(stringValue);
            }
            string value = number.ToString();
            if (value.EndsWith(".0")) { value = value.Remove(value.Length - 2, 2); }
            while (value.Length > 16) { value = value.Remove(value.Length - 1, 1); }
            return long.Parse(value);
        }
        /// <summary>
        /// Returns the smallest integer that is close to a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The smallest integer that is close to the selected number.</returns>
        public static long Floor(double number)
        {
            if (IsFraction(number))
            {
                string stringValue = number.ToString().Split('.')[0];
                while (stringValue.Length > 16) { stringValue = stringValue.Remove(stringValue.Length - 1, 1); }
                return long.Parse(stringValue);
            }
            string value = number.ToString();
            if (value.EndsWith(".0")) { value = value.Remove(value.Length - 2, 2); }
            while (value.Length > 16) { value = value.Remove(value.Length - 1, 1); }
            long outter;
            long.TryParse(value, out outter);
            return outter;
        }
        /// <summary>
        /// Returns the largest integer that is close to a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The largest integer that is close to the selected number.</returns>
        public static long Ceiling(decimal number)
        {
            if (!IsFraction(number))
            { return long.Parse(number.ToString()); }
            return !IsNegative(number) ? Floor(number) + 1 : Floor(number);
        }
        /// <summary>
        /// Returns the largest integer that is close to a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The largest integer that is close to the selected number.</returns>
        public static long Ceiling(double number)
        {
            if (!IsFraction(number))
            { return long.Parse(number.ToString()); }
            return !IsNegative(number) ? Floor(number) + 1 : Floor(number) - 1;
        }
        /// <summary>
        /// Splits a number into a real and fraction part, and returns the fraction part.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The fraction part of the number without its real part.</returns>
        public static long GetFractionPart(decimal number)
        {
            if (!IsFraction(number))
            { return 0; }
            return long.Parse(number.ToString().Split('.')[1]);
        }
        /// <summary>
        /// Substracts a number from its value leaving only its fractions.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The fraction part of the number without its real part.</returns>
        public static decimal GetFraction(decimal number)
        {
            if (!IsFraction(number))
            { return 0; }
            return decimal.Parse("0." + number.ToString().Split('.')[1]);
        }
        /// <summary>
        /// Splits a number into a real and fraction part, and returns the fraction part.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The fraction part of the number without its real part.</returns>
        public static long GetFractionPart(double number)
        {
            if (!IsFraction(number))
            { return 0; }
            return long.Parse(number.ToString().Split('.')[1]);
        }
        /// <summary>
        /// Substracts a number from its value leaving only its fractions.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The fraction part of the number without its real part.</returns>
        public static double GetFraction(double number)
        {
            if (!IsFraction(number))
            { return 0; }
            try { return double.Parse("0." + number.ToString().Split('.')[1]); } catch { return 0; }
        }
        /// <summary>
        /// Adds spaces to a number to organize its look.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="space">The selected space character.</param>
        /// <returns>A string represents the selected number with spaces added to it.</returns>
        public static string Arrange(decimal number, char space)
        {
            string afterDot = Floor(number).ToString(),
                   beforeDot = IsFraction(number) ? GetFraction(number).ToString().Split('.')[1] : "",
                   spacedAfter = afterDot,
                   spacedBefore = beforeDot;
            for (int i = 0, k = 0; i < afterDot.Length; i++)
            {
                if (IsDivisibleBy(i, 3) && i < afterDot.Length && i > 0)
                {
                    spacedAfter = spacedAfter.Insert(spacedAfter.Length - (i + k), space.ToString());
                    k++;
                }
            }
            for (int i = 0, k = 0; i < beforeDot.Length; i++)
            {
                if (IsDivisibleBy(i, 3) && i < beforeDot.Length && i > 0)
                {
                    spacedBefore = spacedBefore.Insert(i + k, space.ToString());
                    k++;
                }
            }
            return spacedBefore == "" ? spacedAfter : spacedAfter + "." + spacedBefore;
        }
        /// <summary>
        /// Adds commas to a number to organize its look.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A string represents the selected number with commas added to it.</returns>
        public static string Arrange(decimal number)
        => Arrange(number, ',');
        /// <summary>
        /// Adds spaces to a number to organize its look.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="space">The selected space character.</param>
        /// <returns>A string represents the selected number with spaces added to it.</returns>
        public static string Arrange(double number, char space)
        {
            string afterDot = Floor(number).ToString(),
                   beforeDot = IsFraction(number) ? GetFraction(number).ToString().Split('.')[1] : "",
                   spacedAfter = afterDot,
                   spacedBefore = beforeDot;
            for (int i = 0, k = 0; i < afterDot.Length; i++)
            {
                if (IsDivisibleBy(i, 3) && i < afterDot.Length && i > 0)
                {
                    spacedAfter = spacedAfter.Insert(spacedAfter.Length - (i + k), space.ToString());
                    k++;
                }
            }
            for (int i = 0, k = 0; i < beforeDot.Length; i++)
            {
                if (IsDivisibleBy(i, 3) && i < beforeDot.Length && i > 0)
                {
                    spacedBefore = spacedBefore.Insert(i + k, space.ToString());
                    k++;
                }
            }
            return spacedBefore == "" ? spacedAfter : spacedAfter + "." + spacedBefore;
        }
        /// <summary>
        /// Adds commas to a number to organize its look.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A string represents the selected number with commas added to it.</returns>
        public static string Arrange(double number)
        => Arrange(number, ',');
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The absolute value of the number.</returns>
        public static int Absolute(int number)
        => number >= 0 ? number : -number;
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Absolute(ref int number)
        => number = Absolute(number);
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The absolute value of the number.</returns>
        public static long Absolute(long number)
        => number >= 0 ? number : -number;
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Absolute(ref long number)
        => number = Absolute(number);
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The absolute value of the number.</returns>
        public static decimal Absolute(decimal number)
        => number >= 0 ? number : -number;
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Absolute(ref decimal number)
        => number = Absolute(number);
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The absolute value of the number.</returns>
        public static double Absolute(double number)
        => number >= 0 ? number : -number;
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Absolute(ref double number)
        => number = Absolute(number);
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The absolute value of the number.</returns>
        public static int Abs(int number)
        => Absolute(number);
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Abs(ref int number)
        => Absolute(ref number);
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The absolute value of the number.</returns>
        public static long Abs(long number)
        => Absolute(number);
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Abs(ref long number)
        => Absolute(ref number);
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The absolute value of the number.</returns>
        public static decimal Abs(decimal number)
        => Absolute(number);
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Abs(ref decimal number)
        => Absolute(ref number);
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The absolute value of the number.</returns>
        public static double Abs(double number)
        => Absolute(number);
        /// <summary>
        /// Sets the absolute value of a number, if positive nothing changes,
        /// else negative will give the same value but positive.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Abs(ref double number)
        => Absolute(ref number);
        /// <summary>
        /// Rounds a number into the nearest integer.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The nearest integer of the selected number.</returns>
        public static int Round(decimal number)
        {
            int negative = number < 0 ? -1 : +1;
            number = Absolute(number);
            decimal fraction = number;
            int i = 0;
            for (i = 0; i < number - 1; i++) { }
            fraction -= i;
            return fraction >= 0.5m ? negative * (i + 1) : negative * i;
        }
        /// <summary>
        /// Rounds a number into the nearest integer.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The nearest integer of the selected number.</returns>
        public static int Round(double number)
        {
            int negative = number < 0 ? -1 : +1;
            number = Absolute(number);
            double fraction = number;
            int i = 0;
            for (i = 0; i < number - 1; i++) { }
            fraction -= i;
            return fraction >= 0.5d ? negative * (i + 1) : negative * i;
        }
        /// <summary>
        /// Clamps a number between a range of numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        /// <returns>The selected number clammped between the selected range.</returns>
        public static int Clamp(int number, int start, int end)
        {
            if (start > end)
            {
                var z = start;
                start = end;
                end = z;
            }
            if (number < start)
            { number = start; }
            else if (number > end)
            { number = end; }
            return number;
        }
        /// <summary>
        /// Clamps a number between a range of numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        public static void Clamp(ref int number, int start, int end)
        => number = Clamp(number, start, end);
        /// <summary>
        /// Clamps a number between a range of numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        /// <returns>The selected number clammped between the selected range.</returns>
        public static decimal Clamp(decimal number, decimal start, decimal end)
        {
            if (start > end)
            {
                var z = start;
                start = end;
                end = z;
            }
            if (number < start)
            { number = start; }
            else if (number > end)
            { number = end; }
            return number;
        }
        /// <summary>
        /// Clamps a number between a range of numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        public static void Clamp(ref decimal number, decimal start, decimal end)
        => number = Clamp(number, start, end);
        /// <summary>
        /// Clamps a number between a range of numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        /// <returns>The selected number clammped between the selected range.</returns>
        public static double Clamp(double number, double start, double end)
        {
            if (start > end)
            {
                var z = start;
                start = end;
                end = z;
            }
            if (number < start)
            { number = start; }
            else if (number > end)
            { number = end; }
            return number;
        }
        /// <summary>
        /// Clamps a number between a range of numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        public static void Clamp(ref double number, double start, double end)
        => number = Clamp(number, start, end);
        /// <summary>
        /// Calculates the amount of numbers between point A and point B.
        /// </summary>
        /// <param name="a">Point A.</param>
        /// <param name="b">Point B.</param>
        /// <returns>The amount of numbers between the two points.</returns>
        public static int Between(int a, int b)
        {
            if (a > b)
            {
                var z = a;
                a = b;
                b = z;
            }
            if (a == b)
            { return 0; }
            if (b >= 0)
            {
                if (a >= 0)
                { return b - a - 1; }
                else
                {
                    int positive = b == 1 ? 1 : b - 1;
                    int negative = Absolute(a);
                    return positive + negative;
                }
            }
            else
            { return Absolute(a) - Absolute(b) - 1; }
        }
        /// <summary>
        /// Calculates the amount of numbers between point A and point B.
        /// </summary>
        /// <param name="a">Point A.</param>
        /// <param name="b">Point B.</param>
        /// <returns>The amount of numbers between the two points.</returns>
        public static int Between(decimal a, decimal b)
        {
            if (a > b)
            {
                var z = a;
                a = b;
                b = z;
            }
            a = Floor(a);
            b = Ceiling(b);
            return Between((int)a, (int)b);
        }
        /// <summary>
        /// Calculates the amount of numbers between point A and point B.
        /// </summary>
        /// <param name="a">Point A.</param>
        /// <param name="b">Point B.</param>
        /// <returns>The amount of numbers between the two points.</returns>
        public static int Between(double a, double b)
        {
            if (a > b)
            {
                var z = a;
                a = b;
                b = z;
            }
            a = Floor(a);
            b = Ceiling(b);
            return Between((int)a, (int)b);
        }
        /// <summary>
        /// Circles a number between a range of numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        /// <returns>The selected number circled to fit in the selected range.</returns>
        public static int Circle(int number, int start, int end)
        {
            if (start > end)
            {
                var z = start;
                start = end;
                end = z;
            }
            while (number < start)
            { number += Between(start, end) + 2; }
            while (number > end)
            { number -= Between(start, end) + 2; }
            return number;
        }
        /// <summary>
        /// Circles a number between a range of numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        public static void Circle(ref int number, int start, int end)
        => number = Circle(number, start, end);
        /// <summary>
        /// Circles a number between a range of numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        /// <returns>The selected number circled to fit in the selected range.</returns>
        public static decimal Circle(decimal number, decimal start, decimal end)
        {
            if (start > end)
            {
                var z = start;
                start = end;
                end = z;
            }
            while (number < start)
            { number += Between(start, end) + 2; }
            while (number > end)
            { number -= Between(start, end) + 2; }
            return number;
        }
        /// <summary>
        /// Circles a number between a range of numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        public static void Circle(ref decimal number, decimal start, decimal end)
        => number = Circle(number, start, end);
        /// <summary>
        /// Circles a number between a range of numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        /// <returns>The selected number circled to fit in the selected range.</returns>
        public static double Circle(double number, double start, double end)
        {
            if (start > end)
            {
                var z = start;
                start = end;
                end = z;
            }
            while (number < start)
            { number += Between(start, end) + 2; }
            while (number > end)
            { number -= Between(start, end) + 2; }
            return number;
        }
        /// <summary>
        /// Circles a number between a range of numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        public static void Circle(ref double number, double start, double end)
        => number = Circle(number, start, end);
        /// <summary>
        /// Gives the sign of a number, (+1 if positive, -1 if negative and 0 if nuteral).
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The sign of the selected number.</returns>
        public static int Sign(int number)
        => IsNegative(number) ? -1 : IsNuteral(number) ? 0 : +1;
        /// <summary>
        /// Gives the sign of a number, (+1 if positive, -1 if negative and 0 if nuteral).
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The sign of the selected number.</returns>
        public static int Sign(decimal number)
        => IsNegative(number) ? -1 : IsNuteral(number) ? 0 : +1;
        /// <summary>
        /// Gives the sign of a number, (+1 if positive, -1 if negative and 0 if nuteral).
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The sign of the selected number.</returns>
        public static int Sign(double number)
        => IsNegative(number) ? -1 : IsNuteral(number) ? 0 : +1;
        /// <summary>
        /// Calculates the Greatest Common Divisor of two numbers.
        /// </summary>
        /// <param name="number1">The first selected number.</param>
        /// <param name="number2">The second selected number.</param>
        /// <returns>A number that represents the Greatest Common Divisor of two selected numbers.</returns>
        public static int GreatestCommonDivisor(int number1, int number2)
        {
            int mod;
            if (number2 == 0 || number1 == 0) { return 0; }
            while (!IsDivisibleBy(number1, number2))
            {
                // num1 % num2 = mod
                // 300 % 105 = 90
                // 105 % 90 = 15
                // 90 % 15 = 0
                mod = number1 % number2;
                number1 = number2;
                number2 = mod;
            }
            return number2;
        }
        /// <summary>
        /// Calculates the Greatest Common Divisor of two numbers.
        /// </summary>
        /// <param name="number1">The first selected number.</param>
        /// <param name="number2">The second selected number.</param>
        /// <returns>A number that represents the Greatest Common Divisor of two selected numbers.</returns>
        public static int GCD(int number1, int number2)
        => GreatestCommonDivisor(number1, number2);
        /// <summary>
        /// Calculates the Least Common Multiplier of two numbers.
        /// </summary>
        /// <param name="number1">The first selected number.</param>
        /// <param name="number2">The second selected number.</param>
        /// <returns>A number that represents the Least Common Multiplier of two selected numbers.</returns>
        public static int LeastCommonMultiplier(int number1, int number2)
        => (number1 * number2) / GreatestCommonDivisor(number1, number2);
        /// <summary>
        /// Calculates the Least Common Multiplier of two numbers.
        /// </summary>
        /// <param name="number1">The first selected number.</param>
        /// <param name="number2">The second selected number.</param>
        /// <returns>A number that represents the Least Common Multiplier of two selected numbers.</returns>
        public static int LCM(int number1, int number2)
        => LeastCommonMultiplier(number1, number2);
        /// <summary>
        /// Gives a random integer number.
        /// </summary>
        /// <returns>A random integer number.</returns>
        public static int RandomInteger()
        {
            System.Threading.Thread.Sleep(1);
            int num1 = DateTime.Now.Millisecond != 0 ? DateTime.Now.Millisecond : 52151,
                num2 = Square(num1);
            num1 *= num2 >> (num2 % num1);
            num1 <<= num1 * num2;
            num1 += (num1 % num2);
            return Abs(num1 * num1);
        }
        /// <summary>
        /// Gives a random integer number between two numbers.
        /// </summary>
        /// <param name="min">The selected minimum value of the number.</param>
        /// <param name="max">The selected maximum value of the number.</param>
        /// <returns>A random integer number between the two selected numbers.</returns>
        public static int RandomInteger(int min, int max)
        => Round(RandomDouble(min, max));
        /// <summary>
        /// Gives a random integer number between two numbers.
        /// </summary>
        /// <param name="min">The selected minimum value of the number.</param>
        /// <param name="max">The selected maximum value of the number.</param>
        /// <returns>A random integer number between the two selected numbers.</returns>
        public static Type RandomInteger<Type>(int min, int max) where Type : IFormattable
        => Value<Type>(RandomInteger(min, max));
        /// <summary>
        /// Gives a random double number.
        /// </summary>
        /// <returns>A random double number.</returns>
        public static double RandomDouble()
        {
            int num1 = RandomInteger();
            double num2 = num1 / Power(10d, num1.ToString().Length);
            num2 *= 3;
            return GetFraction(num2);
        }
        /// <summary>
        /// Gives a random double number between two numbers.
        /// </summary>
        /// <param name="min">The selected minimum value of the number.</param>
        /// <param name="max">The selected maximum value of the number.</param>
        /// <returns>A random double number between the two selected numbers.</returns>
        public static double RandomDouble(double min, double max)
        {
            if (min > max)
            {
                var z = min;
                min = max;
                max = z;
            }
            double num1 = RandomDouble() * (max - min);
            return num1 + min;
        }
        /// <summary>
        /// Gives a random double number between two numbers.
        /// </summary>
        /// <param name="min">The selected minimum value of the number.</param>
        /// <param name="max">The selected maximum value of the number.</param>
        /// <returns>A random double number between the two selected numbers.</returns>
        public static Type RandomDouble<Type>(double min, double max) where Type : IFormattable
        => Value<Type>(RandomDouble(min, max));
        #endregion

        #region #Basic Functions
            /// <summary>
            /// Calculates the product of all integers from One up to a number.
            /// </summary>
            /// <param name="number">The selected number.</param>
            /// <returns>The value of all numbers between One and the selected number multiplied.</returns>
        public static long Factorial(int number)
        => number > 17 ? long.MaxValue / 2 : number >= 0 ? Convert.ToInt64(Production(1, number).ToString()) : 0;
        /// <summary>
        /// Raises a number into a specified number.
        /// </summary>
        /// <param name="number">The selected number to raise.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        /// <returns>The number multiplied by itself power number of times.</returns>
        public static double Power(decimal number, long power)
        {
            if (number == 0) { return power == 0 ? NaN : 0; }
            if (number < 0 && power == 0) { return 1; }
            double value = 1.0d;
            for (int i = 1; i <= Absolute(power); i++)
            { value *= (double)number; }
            return power >= 0 ? value : 1 / value;
        }
        /// <summary>
        /// Raises a number into a specified number.
        /// </summary>
        /// <param name="number">The selected number to raise.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        public static void Power(ref decimal number, long power)
        => number = (decimal)Power(number, power);
        /// <summary>
        /// Raises a number into a specified number.
        /// </summary>
        /// <param name="number">The selected number to raise.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        /// <returns>The number multiplied by itself power number of times.</returns>
        public static double Power(decimal number, decimal power)
        {
            if (number < 0 && IsFraction(power) && IsBetween(power, -1, 1, false))
            { if (IsEven(int.Parse((1 / power).ToString().Last().ToString()))) { return NaN; } }
            if (number < 0 && power == 0) { return 1; }
            if (number == 0) { return power == 0 ? NaN : 0; }
            if (!IsFraction(power)) { return Power(number, Round(power)); }
            if (number > 0)
            { return Exp(GetFraction(power) * (decimal)Ln(number) + Floor(power) * (decimal)Ln(number)); }
            else
            {
                if (power >= 0) { return -Exp(GetFraction(power) * (decimal)Ln(-number) + Floor(power) * (decimal)Ln(-number)); }
                else { return 1 / -Exp(GetFraction(power) * (decimal)Ln(-number) + Floor(power) * (decimal)Ln(-number)); }
            }
        }
        /// <summary>
        /// Raises a number into a specified number.
        /// </summary>
        /// <param name="number">The selected number to raise.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        public static void Power(ref decimal number, decimal power)
        => number = (decimal)Power(number, power);
        /// <summary>
        /// Raises a number into a specified number.
        /// </summary>
        /// <param name="number">The selected number to raise.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        /// <returns>The number multiplied by itself power number of times.</returns>
        public static double Power(double number, long power)
        {
            if (number == 0) { return power == 0 ? NaN : 0; }
            if (number < 0 && power == 0) { return 1; }
            double value = 1.0d;
            for (int i = 1; i <= Absolute(power); i++)
            { value *= number; }
            return power >= 0 ? value : 1 / value;
        }
        /// <summary>
        /// Raises a number into a specified number.
        /// </summary>
        /// <param name="number">The selected number to raise.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        public static void Power(ref double number, long power)
        => number = Power(number, power);
        /// <summary>
        /// Raises a number into a specified number.
        /// </summary>
        /// <param name="number">The selected number to raise.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        /// <returns>The number multiplied by itself power number of times.</returns>
        public static double Power(double number, double power)
        {
            if (number < 0 && IsFraction(power) && IsBetween(power, -1, 1, false))
            { if (IsEven(int.Parse((1 / power).ToString().Last().ToString()))) { return NaN; } }
            if (number == 0) { return power == 0 ? NaN : 0; }
            if (number < 0 && power == 0) { return 1; }
            if (!IsFraction(power)) { return Power(number, Round(power)); }
            if (number > 0)
            { return Exp((decimal)GetFraction(power) * (decimal)Ln(number) + Floor(power) * (decimal)Ln(number)); }
            else
            {
                if (power >= 0) { return -Exp(GetFraction(power) * Ln(-number) + Floor(power) * Ln(-number)); }
                else { return 1 / -Exp(GetFraction(power) * Ln(-number) + Floor(power) * Ln(-number)); }
            }
        }
        /// <summary>
        /// Raises a number into a specified number.
        /// </summary>
        /// <param name="number">The selected number to raise.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        public static void Power(ref double number, double power)
        => number = Power(number, power);
        /// <summary>
        /// Raises an Imaginary Number into a specified number.
        /// </summary>
        /// <param name="number">The selected Imaginary Number to raise.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        /// <returns>The Imaginary Number multiplied by itself power number of times.</returns>
        public static Imaginary Power(Imaginary inumber, long power)
        {
            if (power == 0) { return inumber == i * 0 ? i * NaN : i * i * i * i; }
            if (inumber < i * 0 && power == 0) { return i * i * i * i; }
            Imaginary value = inumber;
            if (power > 0)
            {
                for (int i = 2; i <= power; i++)
                { value *= inumber; }
            }
            else if (power < 0)
            {
                for (int i = 0; i <= Absolute(power); i++)
                { value /= inumber; }
            }
            return value;
        }
        /// <summary>
        /// Raises an Imaginary Number into a specified number.
        /// </summary>
        /// <param name="number">The selected Imaginary Number to raise.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        public static void Power(ref Imaginary inumber, long power)
        => inumber = Power(inumber, power);
        /// <summary>
        /// Raises a Matrix into a specified number.
        /// </summary>
        /// <typeparam name="Type">The type of the selected Matrix to raise.</typeparam>
        /// <param name="matrix">The selected Matrix.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        /// <returns>The Matrix multiplied by itself power number of times.</returns>
        public static Matrix<Type> Power<Type>(Matrix<Type> matrix, int power) where Type : IFormattable
        {
            int negative = Sign(power);
            Abs(ref power);
            if (power == 1) { return negative < 0 ? matrix.Inverse : matrix; }
            for (int i = 1; i < power; i++) { matrix *= matrix; }
            return negative < 0 ? matrix.Inverse : matrix;
        }
        /// <summary>
        /// Raises a Matrix into a specified number.
        /// </summary>
        /// <typeparam name="Type">The type of the selected Matrix to raise.</typeparam>
        /// <param name="matrix">The selected Matrix.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        public static void Power<Type>(ref Matrix<Type> matrix, int power) where Type : IFormattable
        => matrix = Power(matrix, power);
        /// <summary>
        /// Raises a two-by-two Matrix into a specified number.
        /// </summary>
        /// <typeparam name="Type">The type of the selected two-by-two Matrix to raise.</typeparam>
        /// <param name="matrix">The selected two-by-two Matrix.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        /// <returns>The two-by-two multiplied by itself power number of times.</returns>
        public static Matrix2<Type> Power<Type>(Matrix2<Type> matrix, int power) where Type : IFormattable
        => new Matrix2<Type>().Fill(Power(new Matrix<Type>(2).Fill(matrix.ToList()), power).ToList());
        /// <summary>
        /// Raises a two-by-two Matrix into a specified number.
        /// </summary>
        /// <typeparam name="Type">The type of the selected two-by-two Matrix to raise.</typeparam>
        /// <param name="matrix">The selected two-by-two Matrix.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        public static void Power<Type>(ref Matrix2<Type> matrix, int power) where Type : IFormattable
        => matrix = Power(matrix, power);
        /// <summary>
        /// Raises a three-by-three Matrix into a specified number.
        /// </summary>
        /// <typeparam name="Type">The type of the selected three-by-three Matrix to raise.</typeparam>
        /// <param name="matrix">The selected three-by-three Matrix.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        /// <returns>The three-by-three multiplied by itself power number of times.</returns>
        public static Matrix3<Type> Power<Type>(Matrix3<Type> matrix, int power) where Type : IFormattable
        => new Matrix3<Type>().Fill(Power(new Matrix<Type>(3).Fill(matrix.ToList()), power).ToList());
        /// <summary>
        /// Raises a three-by-three Matrix into a specified number.
        /// </summary>
        /// <typeparam name="Type">The type of the selected three-by-three Matrix to raise.</typeparam>
        /// <param name="matrix">The selected three-by-three Matrix.</param>
        /// <param name="power">The selected power number to be raised to.</param>
        public static void Power<Type>(ref Matrix3<Type> matrix, int power) where Type : IFormattable
        => matrix = Power(matrix, power);
        /// <summary>
        /// Squares a number, (Raises it into 2).
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that represents the square of the selected number.</returns>
        public static double Square(decimal number)
        => Power(number, 2);
        /// <summary>
        /// Squares a number, (Raises it into 2).
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Square(ref decimal number)
        => number = (decimal)Square(number);
        /// <summary>
        /// Squares a number, (Raises it into 2).
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that represents the square of the selected number.</returns>
        public static int Square(int number)
        => (int)Power((double)number, 2);
        /// <summary>
        /// Squares a number, (Raises it into 2).
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Square(ref int number)
        => number = Square(number);
        /// <summary>
        /// Squares a number, (Raises it into 2).
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that represents the square of the selected number.</returns>
        public static double Square(double number)
        => Power(number, 2);
        /// <summary>
        /// Squares a number, (Raises it into 2).
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Square(ref double number)
        => number = Square(number);
        /// <summary>
        /// Squares a Matrix, (Raises it into 2).
        /// </summary>
        /// <typeparam name="Type">The type of the selected Matrix.</typeparam>
        /// <param name="matrix">The selected Matrix.</param>
        /// <returns>A Matrix that represents the square of the selected Matrix.</returns>
        public static Matrix<Type> Square<Type>(Matrix<Type> matrix) where Type : IFormattable
        => Power(matrix, 2);
        /// <summary>
        /// Squares a Matrix, (Raises it into 2).
        /// </summary>
        /// <typeparam name="Type">The type of the selected Matrix.</typeparam>
        /// <param name="matrix">The selected Matrix.</param>
        public static void Square<Type>(ref Matrix<Type> matrix) where Type : IFormattable
        => matrix = Square(matrix);
        /// <summary>
        /// Squares a two-by-two Matrix, (Raises it into 2).
        /// </summary>
        /// <typeparam name="Type">The type of the selected two-by-two Matrix.</typeparam>
        /// <param name="matrix">The selected two-by-two Matrix.</param>
        /// <returns>A two-by-two Matrix that represents the square of the selected two-by-two Matrix.</returns>
        public static Matrix2<Type> Square<Type>(Matrix2<Type> matrix) where Type : IFormattable
        => Power(matrix, 2);
        /// <summary>
        /// Squares a two-by-two Matrix, (Raises it into 2).
        /// </summary>
        /// <typeparam name="Type">The type of the selected two-by-two Matrix.</typeparam>
        /// <param name="matrix">The selected two-by-two Matrix.</param>
        public static void Square<Type>(ref Matrix2<Type> matrix) where Type : IFormattable
        => matrix = Square(matrix);
        /// <summary>
        /// Squares a three-by-three Matrix, (Raises it into 2).
        /// </summary>
        /// <typeparam name="Type">The type of the selected three-by-three Matrix.</typeparam>
        /// <param name="matrix">The selected three-by-three Matrix.</param>
        /// <returns>A three-by-three Matrix that represents the square of the selected three-by-three Matrix.</returns>
        public static Matrix3<Type> Square<Type>(Matrix3<Type> matrix) where Type : IFormattable
        => Power(matrix, 2);
        /// <summary>
        /// Squares a three-by-three Matrix, (Raises it into 2).
        /// </summary>
        /// <typeparam name="Type">The type of the selected three-by-three Matrix.</typeparam>
        /// <param name="matrix">The selected three-by-three Matrix.</param>
        public static void Square<Type>(ref Matrix3<Type> matrix) where Type : IFormattable
        => matrix = Square(matrix);
        /// <summary>
        /// Cubes a number, (Raises it into 3).
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that represents the cube of the selected number.</returns>
        public static double Cube(decimal number)
        => Power(number, 3);
        /// <summary>
        /// Cubes a number, (Raises it into 3).
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Cube(ref decimal number)
        => number = (decimal)Cube(number);
        /// <summary>
        /// Cubes a number, (Raises it into 3).
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that represents the cube of the selected number.</returns>
        public static int Cube(int number)
        => (int)Power((double)number, 3);
        /// <summary>
        /// Cubes a number, (Raises it into 3).
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Cube(ref int number)
        => number = Cube(number);
        /// <summary>
        /// Cubes a number, (Raises it into 3).
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that represents the cube of the selected number.</returns>
        public static double Cube(double number)
        => Power(number, 3);
        /// <summary>
        /// Cubes a number, (Raises it into 3).
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Cube(ref double number)
        => number = Cube(number);
        /// <summary>
        /// Cubes a Matrix, (Raises it into 3).
        /// </summary>
        /// <typeparam name="Type">The type of the selected Matrix.</typeparam>
        /// <param name="matrix">The selected Matrix.</param>
        /// <returns>A Matrix that represents the square of the selected Matrix.</returns>
        public static Matrix<Type> Cube<Type>(Matrix<Type> matrix) where Type : IFormattable
        => Power(matrix, 3);
        /// <summary>
        /// Cubes a Matrix, (Raises it into 3).
        /// </summary>
        /// <typeparam name="Type">The type of the selected Matrix.</typeparam>
        /// <param name="matrix">The selected Matrix.</param>
        public static void Cube<Type>(ref Matrix<Type> matrix) where Type : IFormattable
        => matrix = Cube(matrix);
        /// <summary>
        /// Cubes a two-by-two Matrix, (Raises it into 3).
        /// </summary>
        /// <typeparam name="Type">The type of the selected two-by-two Matrix.</typeparam>
        /// <param name="matrix">The selected two-by-two Matrix.</param>
        /// <returns>A two-by-two Matrix that represents the square of the selected two-by-two Matrix.</returns>
        public static Matrix2<Type> Cube<Type>(Matrix2<Type> matrix) where Type : IFormattable
        => Power(matrix, 3);
        /// <summary>
        /// Cubes a two-by-two Matrix, (Raises it into 3).
        /// </summary>
        /// <typeparam name="Type">The type of the selected two-by-two Matrix.</typeparam>
        /// <param name="matrix">The selected two-by-two Matrix.</param>
        public static void Cube<Type>(ref Matrix2<Type> matrix) where Type : IFormattable
        => matrix = Cube(matrix);
        /// <summary>
        /// Cubes a three-by-three Matrix, (Raises it into 3).
        /// </summary>
        /// <typeparam name="Type">The type of the selected three-by-three Matrix.</typeparam>
        /// <param name="matrix">The selected three-by-three Matrix.</param>
        /// <returns>A three-by-three Matrix that represents the square of the selected three-by-three Matrix.</returns>
        public static Matrix3<Type> Cube<Type>(Matrix3<Type> matrix) where Type : IFormattable
        => Power(matrix, 3);
        /// <summary>
        /// Cubes a three-by-three Matrix, (Raises it into 3).
        /// </summary>
        /// <typeparam name="Type">The type of the selected three-by-three Matrix.</typeparam>
        /// <param name="matrix">The selected three-by-three Matrix.</param>
        public static void Cube<Type>(ref Matrix3<Type> matrix) where Type : IFormattable
        => matrix = Cube(matrix);
        /// <summary>
        /// Calculates the nth root of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="_base">The base of root.</param>
        /// <returns>The nth root of the selected number.</returns>
        public static double Root(decimal number, decimal _base)
        {
            if (number == 0)
            { return _base == 0 ? NaN : 0; }
            if (_base == 0)
            { return 1; }
            return Power(number, 1 / _base);
        }
        /// <summary>
        /// Calculates the nth root of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="_base">The base of root.</param>
        public static void Root(ref double number, decimal _base)
        => number = Root((decimal)number, _base);
        /// <summary>
        /// Calculates the nth root of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="_base">The base of root.</param>
        /// <returns>The nth root of the selected number.</returns>
        public static double Root(double number, double _base)
        {
            if (number == 0)
            { return _base == 0 ? NaN : 0; }
            if (_base == 0)
            { return 1; }
            return Power(number, 1 / _base);
        }
        /// <summary>
        /// Calculates the nth root of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="_base">The base of root.</param>
        public static void Root(ref double number, double _base)
        => number = Root(number, _base);
        /// <summary>
        /// Calculates the square root value of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The square root of the selected number.</returns>
        public static double SquareRoot(decimal number)
        => Root(number, 2);
        /// <summary>
        /// Calculates the square root value of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void SquareRoot(ref double number)
        => number = SquareRoot((decimal)number);
        /// <summary>
        /// Calculates the square root value of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The square root of the selected number.</returns>
        public static double SquareRoot(double number)
        => Root(number, 2);
        /// <summary>
        /// Calculates the two different square root value of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="result1">The first square root of the selected number.</param>
        /// <param name="result2">The second square root of the selected number.</param>
        /// <returns>The square root of the selected number.</returns>
        public static double SquareRoot(decimal number, out double result1, out double result2)
        {
            result1 = Root(number, 2);
            result2 = -Root(number, 2);
            return result1;
        }
        /// <summary>
        /// Calculates the two different square root value of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="result1">The first square root of the selected number.</param>
        /// <param name="result2">The second square root of the selected number.</param>
        /// <returns>The square root of the selected number.</returns>
        public static double SquareRoot(double number, out double result1, out double result2)
        {
            result1 = Root(number, 2);
            result2 = -Root(number, 2);
            return result1;
        }
        /// <summary>
        /// Calculates the two different square root value of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="result1">The first square root of the selected number.</param>
        /// <param name="result2">The second square root of the selected number.</param>
        /// <returns>The square root of the selected number.</returns>
        public static Imaginary SquareRoot(decimal number, out Imaginary result1, out Imaginary result2)
        {
            number *= -1;
            result1 = i * Root(number, 2);
            result2 = -i * Root(number, 2);
            return result1;
        }
        /// <summary>
        /// Calculates the two different square root value of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="result1">The first square root of the selected number.</param>
        /// <param name="result2">The second square root of the selected number.</param>
        /// <returns>The square root of the selected number.</returns>
        public static Imaginary SquareRoot(double number, out Imaginary result1, out Imaginary result2)
        {
            number *= -1;
            result1 = i * Root(number, 2);
            result2 = -i * Root(number, 2);
            return result1;
        }
        /// <summary>
        /// Calculates the two different square root value of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="result1">The first square root of the selected number.</param>
        /// <param name="result2">The second square root of the selected number.</param>
        /// <returns>The square root of the selected number.</returns>
        public static string SquareRoot(decimal number, out string result1, out string result2)
        {
            if (number < 0)
            {
                number *= -1;
                result1 = (i * Root(number, 2)).ToString();
                result2 = (-i * Root(number, 2)).ToString();
                return result1;
            }
            else
            {
                result1 = (Root(number, 2)).ToString();
                result2 = (-Root(number, 2)).ToString();
                return result1;
            }
        }
        /// <summary>
        /// Calculates the two different square root value of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="result1">The first square root of the selected number.</param>
        /// <param name="result2">The second square root of the selected number.</param>
        /// <returns>The square root of the selected number.</returns>
        public static string SquareRoot(double number, out string result1, out string result2)
        {
            if (number < 0)
            {
                number *= -1;
                result1 = (i * Root(number, 2)).ToString();
                result2 = (-i * Root(number, 2)).ToString();
                return result1;
            }
            else
            {
                result1 = (Root(number, 2)).ToString();
                result2 = (-Root(number, 2)).ToString();
                return result1;
            }
        }
        /// <summary>
        /// Calculates the cube root value of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The cube root of the selected number.</returns>
        public static double CubeRoot(decimal number)
        => Root(number, 3);
        /// <summary>
        /// Calculates the cube root value of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The cube root of the selected number.</returns>
        public static double CubeRoot(double number)
        => Root(number, 3);
        /// <summary>
        /// Calculates the cube root value of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void CubeRoot(ref double number)
        => number = SquareRoot((decimal)number);
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static double NaturalLogarithm(decimal number)
        {
            if (number == 0)
            { return NegativeInfinity; }
            if (number < 0)
            { return NaN; }
            int division = 0;
            while (number >= 1.5m)
            { number /= 2; division++; }
            while (number < 0.1m)
            { number *= 2; division--; }
            number--;
            double value = 0.0d;
            for (int i = 1; i < (number >= 1 ? 20 : 300); i++)
            { value += Power(-1, (decimal)i + 1) * Power(number, i) / i; }
            return value + division * (double)Ln2;
        }
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static double NaturalLogarithm(double number)
        {
            if (number == 0)
            { return NegativeInfinity; }
            if (number < 0)
            { return NaN; }
            int division = 0;
            while (number >= 1.5d)
            { number /= 2; division++; }
            while (number < 0.1d)
            { number *= 2; division--; }
            number--;
            double value = 0.0d;
            for (int i = 1; i < (number >= 1 ? 20 : 300); i++)
            { value += Power(-1, (double)i + 1) * Power(number, i) / i; }
            return value + division * (double)Ln2;
        }
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void NaturalLogarithm(ref double number)
        => number = NaturalLogarithm(number);
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="result">In case the selected number is outta the range ] 0, inf [ we
        /// might get complex result, so this variable to store their values.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static double NaturalLogarithm(decimal number, out Complex result)
        {
            result = new Complex(NaturalLogarithm(number), i * 0);
            if (number < 0)
            { result = new Complex(NaturalLogarithm(-number), (double)π * i); }
            return NaturalLogarithm(number);
        }
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="result">In case the selected number is outta the range ] 0, inf [ we
        /// might get complex result, so this variable to store their values.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static double NaturalLogarithm(double number, out Complex result)
        {
            result = new Complex(NaturalLogarithm(number), i * 0);
            if (number < 0)
            { result = new Complex(NaturalLogarithm(-number), (double)π * i); }
            return NaturalLogarithm(number);
        }
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="result">In case the selected number is outta the range ] 0, inf [ we
        /// might get complex result, so this variable to store their values.</param>
        public static void NaturalLogarithm(ref double number, out Complex result)
        => number = NaturalLogarithm(number, out result);
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static Complex NaturalLogarithm(Imaginary inumber)
        {
            if (inumber > 0 * i)
            { return new Complex(NaturalLogarithm(inumber.Proverbs), (double)π / 2 * i); }
            else if (inumber < 0 * i)
            { return new Complex(NaturalLogarithm(-inumber.Proverbs), -(double)π / 2 * i); }
            else return new Complex(NaN, 0 * i);
        }
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static Complex NaturalLogarithm(Complex complex)
        {
            double a = complex.RealPart,
                   b = complex.ImaginaryPart.Proverbs;
            if (complex.Angle == 0 || complex.Angle == 180)
            { Complex result; NaturalLogarithm(a, out result); return result; }
            else if (complex.Angle == 90 || complex.Angle == 270)
            { return NaturalLogarithm(b * i); }
            int negative = Sign(b);
            return new Complex(0.5 * NaturalLogarithm(Square(a) + Square(b)), negative * i * ToRadian(Arctan(negative * b / a)));
        }
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="complex">The selected Complex Number.</param>
        public static void NaturalLogarithm(ref Complex complex)
        => NaturalLogarithm(complex);
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static double Ln(decimal number)
        => NaturalLogarithm(number);
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static double Ln(double number)
        => NaturalLogarithm(number);
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        public static void Ln(ref double number)
        => number = NaturalLogarithm(number);
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="result">In case the selected number is outta the range ] 0, inf [ we
        /// might get complex result, so this variable to store their values.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static double Ln(decimal number, out Complex result)
        => NaturalLogarithm(number, out result);
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="result">In case the selected number is outta the range ] 0, inf [ we
        /// might get complex result, so this variable to store their values.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static double Ln(double number, out Complex result)
        => NaturalLogarithm(number, out result);
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="result">In case the selected number is outta the range ] 0, inf [ we
        /// might get complex result, so this variable to store their values.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static void Ln(ref double number, out Complex result)
        => NaturalLogarithm(ref number, out result);
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static Complex Ln(Imaginary inumber)
        => NaturalLogarithm(inumber);
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A value that if Euler's number is raised to, it'll return the selected number.</returns>
        public static Complex Ln(Complex complex)
        => NaturalLogarithm(complex);
        /// <summary>
        /// Calculates the Natural Logarithm (based on Euler's number) of a number.
        /// </summary>
        /// <param name="number">The selected Complex Number.</param>
        public static void Ln(ref Complex complex)
        => NaturalLogarithm(complex);
        /// <summary>
        /// Raises Euler's number into a specified power.
        /// </summary>
        /// <param name="power">The selected power.</param>
        /// <returns>The value of Euler's number raised into the selected power.</returns>
        public static double Exp(decimal power)
        {
            double value = 0.0d;
            if (!IsFraction(power))
            { return Power(e, Floor(power)); }
            bool negative = power < 0;
            Absolute(ref power);
            for (int i = 0; i < 18; i++)
            { value += Power(GetFraction(power) * (power < 0 ? -1 : +1), i) / Factorial(i); }
            value *= Power(e, Floor(power));
            value = negative ? 1 / value : value;
            try { return (double)Accurate((decimal)value, 0.00001m); } catch { return value; }
        }
        /// <summary>
        /// Raises Euler's number into a specified power.
        /// </summary>
        /// <param name="power">The selected power.</param>
        /// <returns>The value of Euler's number raised into the selected power.</returns>
        public static double Exp(double power)
        {
            double value = 0.0d;
            if (!IsFraction(power))
            { return Power(e, Floor(power)); }
            bool negative = power < 0;
            Absolute(ref power);
            for (int i = 0; i < 18; i++)
            { value += Power(GetFraction(power) * (power < 0 ? -1 : +1), i) / Factorial(i); }
            value *= Power(e, Floor(power));
            value = negative ? 1 / value : value;
            try { return Accurate(value, 0.00001d); } catch { return value; }
        }
        /// <summary>
        /// Raises Euler's number into a specified power.
        /// </summary>
        /// <param name="power">The selected power.</param>
        public static void Exp(ref double power)
        => power = Exp(power);
        /// <summary>
        /// Raises Euler's number into a specified power.
        /// </summary>
        /// <param name="ipower">The selected Imaginary Power.</param>
        /// <returns>The value of Euler's number raised into the selected power.</returns>
        public static Complex Exp(Imaginary ipower)
        => new Complex(Cos(ToDegree(ipower.Proverbs)), i * Sin(ToDegree(ipower.Proverbs)));
        /// <summary>
        /// Raises Euler's number into a specified power.
        /// </summary>
        /// <param name="power">The selected Complex Power.</param>
        /// <returns>The value of Euler's number raised into the selected power.</returns>
        public static Complex Exp(Complex power)
        => Exp(power.RealPart) * Exp(power.ImaginaryPart);
        /// <summary>
        /// Raises Euler's number into a specified power.
        /// </summary>
        /// <param name="power">The selected power.</param>
        /// <returns>The value of Euler's number raised into the selected power.</returns>
        public static double RaiseEulerTo(decimal power)
        => Exp(power);
        /// <summary>
        /// Raises Euler's number into a specified power.
        /// </summary>
        /// <param name="power">The selected power.</param>
        /// <returns>The value of Euler's number raised into the selected power.</returns>
        public static double RaiseEulerTo(double power)
        => Exp(power);
        /// <summary>
        /// Raises Euler's number into a specified power.
        /// </summary>
        /// <param name="power">The selected power.</param>
        public static void RaiseEulerTo(ref double power)
        => power = Exp(power);
        /// <summary>
        /// Raises Euler's number into a specified power.
        /// </summary>
        /// <param name="ipower">The selected Imaginary Power.</param>
        /// <returns>The value of Euler's number raised into the selected power.</returns>
        public static Complex RaiseEulerTo(Imaginary ipower)
        => Exp(ipower);
        /// <summary>
        /// Raises Euler's number into a specified power.
        /// </summary>
        /// <param name="power">The selected Complex Power.</param>
        /// <returns>The value of Euler's number raised into the selected power.</returns>
        public static Complex RaiseEulerTo(Complex power)
        => Exp(power);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected base of the logarithm.</param>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static double Logarithm(decimal _base, decimal number)
        => _base == 0 ? NaN : NaturalLogarithm(number) / NaturalLogarithm(_base);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected base of the logarithm.</param>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static double Log(decimal _base, decimal number)
        => Logarithm(_base, number);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected base of the logarithm.</param>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static double Logarithm(double _base, double number)
        => _base == 0 ? NaN : NaturalLogarithm(number) / NaturalLogarithm(_base);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected base of the logarithm.</param>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static double Log(double _base, double number)
        => Logarithm(_base, number);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="ibase">The selected Imaginary Base of the logarithm.</param>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Logarithm(Imaginary ibase, decimal number)
        => ibase == 0 * i ? NaN * i : NaturalLogarithm(number) / NaturalLogarithm(ibase);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="ibase">The selected Imaginary Base of the logarithm.</param>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Log(Imaginary ibase, decimal number)
        => Logarithm(ibase, number);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="ibase">The selected Imaginary Base of the logarithm.</param>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Logarithm(Imaginary ibase, double number)
        => ibase == 0 * i ? NaN * i : NaturalLogarithm(number) / NaturalLogarithm(ibase);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="ibase">The selected Imaginary Base of the logarithm.</param>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Log(Imaginary ibase, double number)
        => Logarithm(ibase, number);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="ibase">The selected Imaginary Base of the logarithm.</param>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Logarithm(Imaginary ibase, Complex complex)
        => ibase == 0 * i ? NaN * i : NaturalLogarithm(complex) / NaturalLogarithm(ibase);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="ibase">The selected Imaginary Base of the logarithm.</param>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Log(Imaginary ibase, Complex complex)
        => Logarithm(ibase, complex);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected base of the logarithm.</param>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Logarithm(decimal _base, Imaginary inumber)
        => _base == 0 ? NaN * i : NaturalLogarithm(inumber) / NaturalLogarithm(_base);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected base of the logarithm.</param>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Log(decimal _base, Imaginary inumber)
        => Logarithm(_base, inumber);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected base of the logarithm.</param>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Logarithm(double _base, Imaginary inumber)
        => _base == 0 ? NaN * i : NaturalLogarithm(inumber) / NaturalLogarithm(_base);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected base of the logarithm.</param>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Log(double _base, Imaginary inumber)
        => Logarithm(_base, inumber);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="ibase">The selected Imaginary Base of the logarithm.</param>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Logarithm(Imaginary ibase, Imaginary inumber)
        => ibase == 0 * i ? NaN * i : NaturalLogarithm(inumber) / NaturalLogarithm(ibase);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="ibase">The selected Imaginary Base of the logarithm.</param>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Log(Imaginary ibase, Imaginary inumber)
        => Logarithm(ibase, inumber);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected Complex Base of the logarithm.</param>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Logarithm(Complex _base, Imaginary inumber)
        => _base == new Complex() ? NaN * i : NaturalLogarithm(inumber) / NaturalLogarithm(_base);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected Complex Base of the logarithm.</param>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Log(Complex _base, Imaginary inumber)
        => Logarithm(_base, inumber);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected Complex Base of the logarithm.</param>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Logarithm(Complex _base, decimal number)
        => _base == new Complex() ? NaN * i : NaturalLogarithm(number) / NaturalLogarithm(_base);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected Complex Base of the logarithm.</param>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Log(Complex _base, decimal number)
        => Logarithm(_base, number);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected Complex Base of the logarithm.</param>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Logarithm(Complex _base, double number)
        => _base == new Complex() ? NaN * i : NaturalLogarithm(number) / NaturalLogarithm(_base);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected Complex Base of the logarithm.</param>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Log(Complex _base, double number)
        => Logarithm(_base, number);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected Complex Base of the logarithm.</param>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Logarithm(Complex _base, Complex complex)
        => _base == new Complex() ? NaN * i : NaturalLogarithm(complex) / NaturalLogarithm(_base);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected Complex Base of the logarithm.</param>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Log(Complex _base, Complex complex)
        => Logarithm(_base, complex);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected base of the logarithm.</param>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Logarithm(decimal _base, Complex complex)
        => _base == 0 ? NaN * i : NaturalLogarithm(complex) / NaturalLogarithm(_base);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected base of the logarithm.</param>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Log(decimal _base, Complex complex)
        => Logarithm(_base, complex);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected base of the logarithm.</param>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Logarithm(double _base, Complex complex)
        => _base == 0 ? NaN * i : NaturalLogarithm(complex) / NaturalLogarithm(_base);
        /// <summary>
        /// Calculates the Logarithm of a number in a specified base.
        /// </summary>
        /// <param name="_base">The selected base of the logarithm.</param>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A value that if based number is raised to, it'll return the selected number.</returns>
        public static Complex Log(double _base, Complex complex)
        => Logarithm(_base, complex);
        /// <summary>
        /// Calculates the Tenth Logarithm (based on 10) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if 10 is raised to, it'll return the selected number.</returns>
        public static double TenthLogarithm(decimal number)
        => Logarithm(10, number);
        /// <summary>
        /// Calculates the Tenth Logarithm (based on 10) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if 10 is raised to, it'll return the selected number.</returns>
        public static double Log10(decimal number)
        => TenthLogarithm(number);
        /// <summary>
        /// Calculates the Tenth Logarithm (based on 10) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if 10 is raised to, it'll return the selected number.</returns>
        public static double TenthLogarithm(double number)
        => Logarithm(10, number);
        /// <summary>
        /// Calculates the Tenth Logarithm (based on 10) of a number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A value that if 10 is raised to, it'll return the selected number.</returns>
        public static double Log10(double number)
        => TenthLogarithm(number);
        /// <summary>
        /// Calculates the amount of ways of the selection and the arrangement of items, in which order matters.
        /// </summary>
        /// <param name="all">The number of all the items.</param>
        /// <param name="taken">The number of the taken items at a time.</param>
        /// <returns>A number that represents the amount of ways of the selection and the arrangement of the selected items, in which order matters.</returns>
        public static long Permutation(int all, int taken)
        => Factorial(all) / Factorial(all - taken);
        /// <summary>
        /// Calculates the amount of ways of only the selection of items, in which order doesn't matter.
        /// </summary>
        /// <param name="all">The number of all the items.</param>
        /// <param name="taken">The number of the taken items at a time.</param>
        /// <returns>A number that represents the amount of ways of only the selection of the selected items, in which order doesn't matter.</returns>
        public static long Combination(int all, int taken)
        => Permutation(all, taken) / Factorial(taken);
        /// <summary>
        /// Calculates the product of all integers from One up to a number that have the same parity as the number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The value of all numbers between One and the selected number that have the same parity as the selected number multiplied.</returns>
        public static long SemiFactorial(int number)
        {
            if (number > 33)
            { return long.MaxValue; }
            long result = 1;
            for (int i = IsOdd(number) ? 1 : 2; i <= number; i += 2)
            { result *= i; }
            return result;
        }
        /// <summary>
        /// Calculates the product of all integers from One up to a number that have the same parity as the number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The value of all numbers between One and the selected number that have the same parity as the selected number multiplied.</returns>
        public static long DoubleFactorial(int number)
        => SemiFactorial(number);
        /// <summary>
        /// Calculates the product of all integers from One up to a number that are Prime Numbers.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>The value of all numbers between One and the selected number that are Prime Numbers multiplied.</returns>
        public static long Primorial(int number)
        {
            if (number > 52)
            { return long.MaxValue; }
            long result = 1;
            for (int i = 1; i <= number; i++)
            { if (IsPrime(i)) { result *= i; } }
            return result;
        }
        #endregion

        #region #Booleans
        /// <summary>
        /// Checks if the a number is divisble by another number.
        /// </summary>
        /// <param name="firstNumber">The first selected number.</param>
        /// <param name="secondNumber">The second selected number.</param>
        /// <returns>A boolean that represents wether or not the first selected number is
        /// divisble by the second selected number.</returns>
        public static bool IsDivisibleBy(int firstNumber, int secondNumber)
        => firstNumber != 0 && secondNumber != 0 && firstNumber % secondNumber == 0;
        /// <summary>
        /// Checks if the a number is divisble by another number.
        /// </summary>
        /// <param name="firstNumber">The first selected number.</param>
        /// <param name="secondNumber">The second selected number.</param>
        /// <returns>A boolean that represents wether or not the first selected number is
        /// divisble by the second selected number.</returns>
        public static bool IsDivisibleBy(decimal firstNumber, decimal secondNumber)
        => firstNumber != 0 && secondNumber != 0 && firstNumber % secondNumber == 0;
        /// <summary>
        /// Checks if the a number is divisble by another number.
        /// </summary>
        /// <param name="firstNumber">The first selected number.</param>
        /// <param name="secondNumber">The second selected number.</param>
        /// <returns>A boolean that represents wether or not the first selected number is
        /// divisble by the second selected number.</returns>
        public static bool IsDivisibleBy(double firstNumber, double secondNumber)
        => firstNumber != 0 && secondNumber != 0 && firstNumber % secondNumber == 0;
        /// <summary>
        /// Checks if a number is a multiple of Two.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A boolean that represents wether or
        /// not the selected number is even.</returns>
        public static bool IsEven(int number)
        => number == 0 ? true : IsDivisibleBy(number, 2);
        /// <summary>
        /// Checks if a number is not a multiple of Two.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A boolean that represents wether or
        /// not the selected number is even.</returns>
        public static bool IsOdd(int number)
        => number == 0 ? false : !IsDivisibleBy(number, 2);
        /// <summary>
        /// Checks if a number is only divisible of One and itself.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A boolean that represents wether or not the
        /// selected number is a prime number or not.</returns>
        public static bool IsPrime(int number)
        {
            if (number < 2)
            { return false; }
            else if (number == 2)
            { return true; }
            double half = (number + 1) / 2;
            for (int i = 2; i <= half; i++)
            {
                if (IsDivisibleBy(number, i))
                { return false; }
            }
            return true;
        }
        /// <summary>
        /// Checks if a number is not a whole number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A boolean that represents wether or not the
        /// selected number contains a dot.</returns>
        public static bool IsFraction(decimal number)
        {
            string value = number.ToString();
            return value.Contains('.') && !value.EndsWith(".0");
        }
        /// <summary>
        /// Checks if a number is not a whole number.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A boolean that represents wether or not the
        /// selected number contains a dot.</returns>
        public static bool IsFraction(double number)
        {
            string value = number.ToString();
            return value.Contains('.') && !value.EndsWith(".0");
        }
        /// <summary>
        /// Checks if a number is under Zero.
        /// </summary>
        /// <typeparam name="Type">The type of the selected number.</typeparam>
        /// <param name="number">The selected number.</param>
        /// <returns>A boolean that represents wether or not the
        /// selected number is under Zero.</returns>
        public static bool IsNegative<Type>(Type number) where Type : IFormattable
        => number < (dynamic)Value<Type>(0);
        /// <summary>
        /// Checks if a number is equal to Zero.
        /// </summary>
        /// <typeparam name="Type">The type of the selected number.</typeparam>
        /// <param name="number">The selected number.</param>
        /// <returns>A boolean that represents wether or not the
        /// selected number is equal to Zero.</returns>
        public static bool IsNuteral<Type>(Type number) where Type : IFormattable
        => number == (dynamic)Value<Type>(0);
        /// <summary>
        /// Checks if a number is above Zero.
        /// </summary>
        /// <typeparam name="Type">The type of the selected number.</typeparam>
        /// <param name="number">The selected number.</param>
        /// <returns>A boolean that represents wether or not the
        /// selected number is above Zero.</returns>
        public static bool IsPositive<Type>(Type number) where Type : IFormattable
        => number > (dynamic)Value<Type>(0);
        /// <summary>
        /// Checks if a number is between a specific range.
        /// </summary>
        /// <typeparam name="Type">The type of the selected number.</typeparam>
        /// <param name="number">The selected number.</param>
        /// <param name="start">The first number of the range.</param>
        /// <param name="end">The last number of the range.</param>
        /// <param name="within">If true; the selected number will be checked to be
        /// equal to the limits of the range, and the oppositie in false.</param>
        /// <returns>A boolean that represents wether or not the
        /// selected number is between the selected range.</returns>
        public static bool IsBetween<Type>(Type number, Type start, Type end, bool within) where Type : IFormattable
        {
            if (start > (dynamic)end)
            {
                Type z = start;
                start = end;
                end = z;
            }
            return within ? number >= (dynamic)start && number <= (dynamic)end : number > (dynamic)start && number < (dynamic)end;
        }
        /// <summary>
        /// Checks if two Vectors are parallels for each other.
        /// </summary>
        /// <param name="vector1">The first selected Vector.</param>
        /// <param name="vector2">The second selected Vector.</param>
        /// <returns>A boolean that represents wether or not the two selected Vectors are parallels for each other.</returns>
        public static bool AreParallels(Vector2D vector1, Vector2D vector2)
        => vector1.Parallels(vector2);
        /// <summary>
        /// Checks if two Vectors are perpendiculars for each other.
        /// </summary>
        /// <param name="vector1">The first selected Vector.</param>
        /// <param name="vector2">The second selected Vector.</param>
        /// <returns>A boolean that represents wether or not the two selected Vectors are perpendiculars for each other.</returns>
        public static bool ArePerpendiculars(Vector2D vector1, Vector2D vector2)
        => vector1.Perpendiculates(vector2);
        /// <summary>
        /// Checks if two Vectors are parallels for each other.
        /// </summary>
        /// <param name="vector1">The first selected Vector.</param>
        /// <param name="vector2">The second selected Vector.</param>
        /// <returns>A boolean that represents wether or not the two selected Vectors are parallels for each other.</returns>
        public static bool AreParallels(Vector3D vector1, Vector3D vector2)
        => vector1.Parallels(vector2);
        /// <summary>
        /// Checks if two Vectors are perpendiculars for each other.
        /// </summary>
        /// <param name="vector1">The first selected Vector.</param>
        /// <param name="vector2">The second selected Vector.</param>
        /// <returns>A boolean that represents wether or not the two selected Vectors are perpendiculars for each other.</returns>
        public static bool ArePerpendiculars(Vector3D vector1, Vector3D vector2)
        => vector1.Perpendiculates(vector2);
        /// <summary>
        /// Checks if two Matrices are conformable for multiplication with each other,
        /// (which means the first one's width is same as second one's height or the opposite).
        /// </summary>
        /// <param name="matrix1">The first selected Matrix.</param>
        /// <param name="matrix2">The second selected Matrix.</param>
        /// <returns>A boolean That represents wether or not the two Matrices are conformable with each other.</returns>
        public static bool AreMultiplicationConformable<Type>(Matrix<Type> matrix1, Matrix<Type> matrix2) where Type : IFormattable
        => matrix1.IsMultiplicationConformableWith(matrix2);
        #endregion

        #region #Sequences
        /// <summary>
        /// Creates a sequence of numbers in a specified range with spaces of 1.
        /// </summary>
        /// <typeparam name="Type">The selected type of the numbers of the sequence.</typeparam>
        /// <param name="start">The first number of the sequence.</param>
        /// <param name="end">The last number of the sequence.</param>
        /// <returns>A sequence filled with number in range from the first selected number to the last selected number.</returns>
        public static Type[] InRange<Type>(int start, int end) where Type : IFormattable
        => ArithmeticSequence(Value<Type>(start), Max(start, end) - Min(start, end) + 1, Value<Type>(1));
        /// <summary>
        /// Produces a sequence of the Fibonacci Sequence numbers in a specified size.
        /// </summary>
        /// <typeparam name="Type">The selected type of the numbers of the sequence.</typeparam>
        /// <param name="size">The size of the sequence.</param>
        /// <returns>A part from the Fibonacci Sequence with the selected size.</returns>
        public static Type[] FibonacciSequence<Type>(int size) where Type : IFormattable
        {
            List<Type> serie = new List<Type>() { Value<Type>(1) };
            if (size <= 0) { return new Type[] { }; }
            switch (size)
            {
                case 2:
                    return new Type[] { Value<Type>(1), Value<Type>(2) } ;
                case 1:
                    return serie.ToArray();
            }
            Type x = Value<Type>(1),
                 y = Value<Type>(2);
            for (int i = 0; i < size - 1; i++)
            {
                Type z = x;
                x = y;
                y = (dynamic)z + y;
                serie.Add(x);
            }
            return serie.ToArray();
        }
        /// <summary>
        /// Produces a sequence of Prime Numbers in a specified size.
        /// </summary>
        /// <typeparam name="Type">The selected type of the numbers of the sequence.</typeparam>
        /// <param name="size">The size of the sequence.</param>
        /// <returns>A sequence that contains only Prime Numbers with the selected size.</returns>
        public static Type[] PrimesSequence<Type>(int size) where Type : IFormattable
        {
            List<Type> serie = new List<Type>() { };
            if (size <= 0) { return new Type[] { }; }
            for (int i = 2, k = 0; k < size; i++)
            { if (IsPrime(i)) { serie.Add(Value<Type>(i)); k++; } }
            return serie.ToArray();
        }
        /// <summary>
        /// Creates an arithmetic sequence with one space, (which is a sequence that increases or decreases via addition or substraction).
        /// </summary>
        /// <typeparam name="Type">The selected type of the numbers of the sequence.</typeparam>
        /// <param name="start">The first element of the sequence.</param>
        /// <param name="space">The amount of spacing between each element.</param>
        /// <param name="size">The size of the sequence.</param>
        /// <returns>An array that represents the arithmetic sequence.</returns>
        public static Type[] ArithmeticSequence<Type>(Type start, int size, Type space) where Type : IFormattable
        {
            List<Type> sequence = new List<Type>() { start };
            if (size <= 0) { return new Type[0]; }
            for (int i = 1; i < size; i++)
            { sequence.Add(sequence[i - 1] + (dynamic)space); }
            return sequence.ToArray();
        }
        /// <summary>
        /// Creates an arithmetic sequence with multiple spaces, (which is a sequence that increases or decreases via addition or substraction).
        /// </summary>
        /// <typeparam name="Type">The selected type of the numbers of the sequence.</typeparam>
        /// <param name="start">The first element of the sequence.</param>
        /// <param name="spaces">An array that's used to make spaces between each element.</param>
        /// <param name="size">The size of the sequence.</param>
        /// <returns>An array that represents the arithmetic sequence.</returns>
        public static Type[] ArithmeticSequence<Type>(Type start, int size, params Type[] spaces) where Type : IFormattable
        {
            List<Type> sequence = new List<Type>() { start };
            if (size <= 0) { return new Type[0]; }
            for (int i = 1, j = 0; i < size; i++, j++)
            {
                if (j >= spaces.Length)
                { j = 0; }
                sequence.Add(sequence[i - 1] + (dynamic)spaces[j]);
            }
            return sequence.ToArray();
        }
        /// <summary>
        /// Takes a copy of an arithmetic sequence and build a new one out of it.
        /// </summary>
        /// <typeparam name="Type">The selected type of the numbers of the selected sequence.</typeparam>
        /// <param name="origin">The original sequence.</param>
        /// <param name="size">The size of the new sequence.</param>
        /// <returns>An array that represents a new sequence built from the selected old sequence.</returns>
        public static Type[] CopyArithmeticSequence<Type>(Type[] origin, int size) where Type : IFormattable
        {
            List<Type> sequence = origin.ToList();
            if (size <= 0) { return new Type[0]; }
            if (size <= origin.Length)
            {
                sequence.RemoveRange(size - 1, origin.Length - size + 1);
                sequence.Add(origin[sequence.Count]);
                return sequence.ToArray();
            }
            List<Type> spaces = new List<Type>();
            if (origin.Length < 2)
            { spaces.Add(Value<Type>(0)); }
            else
            {
                for (int i = 1; i < origin.Length; i++)
                { spaces.Add(origin[i] - (dynamic)origin[i - 1]); }
            }
            List<Type> rest = ArithmeticSequence<Type>(sequence[sequence.Count - 1], size, spaces.ToArray()).ToList();
            rest.RemoveAt(0);
            rest.RemoveAt(rest.Count - 1);
            sequence.AddRange(rest);
            return sequence.ToArray();
        }
        /// <summary>
        /// Creates a geometric sequence with one space, (which is a sequence that increases or decreases via multiplication or division).
        /// </summary>
        /// <typeparam name="Type">The selected type of the numbers of the sequence.</typeparam>
        /// <param name="start">The first element of the sequence.</param>
        /// <param name="space">The amount of spacing between each element.</param>
        /// <param name="size">The size of the sequence.</param>
        /// <returns>An array that represents the geometric sequence.</returns>
        public static Type[] GeometricSequence<Type>(Type start, int size, Type space) where Type : IFormattable
        {
            List<Type> sequence = new List<Type>() { start };
            if (size <= 0)
            { return new Type[0]; }
            for (int i = 1; i < size; i++)
            { sequence.Add(sequence[i - 1] * (dynamic)space); }
            return sequence.ToArray();
        }
        /// <summary>
        /// Creates a geometric sequence with multiple spaces, (which is a sequence that increases or decreases via multiplication or division).
        /// </summary>
        /// <typeparam name="Type">The selected type of the numbers of the sequence.</typeparam>
        /// <param name="start">The first element of the sequence.</param>
        /// <param name="spaces">An array that's used to make spaces between each element.</param>
        /// <param name="size">The size of the sequence.</param>
        /// <returns>An array that represents the geometric sequence.</returns>
        public static Type[] GeometricSequence<Type>(Type start, int size, params Type[] spaces) where Type : IFormattable
        {
            List<Type> sequence = new List<Type>() { start };
            if (size <= 0)
            { return new Type[0]; }
            for (int i = 1, j = 0; i < size; i++, j++)
            {
                if (j >= spaces.Length)
                { j = 0; }
                sequence.Add(sequence[i - 1] * (dynamic)spaces[j]);
            }
            return sequence.ToArray();
        }
        /// <summary>
        /// Takes a copy of a geometric sequence and build a new one out of it.
        /// </summary>
        /// <typeparam name="Type">The selected type of the numbers of the selected sequence.</typeparam>
        /// <param name="origin">The original sequence.</param>
        /// <param name="size">The size of the new sequence.</param>
        /// <returns>An array that represents a new sequence built from the selected old sequence.</returns>
        public static Type[] CopyGeometricSequence<Type>(Type[] origin, int size) where Type : IFormattable
        {
            List<Type> sequence = origin.ToList();
            if (size <= 0)
            { return new Type[0]; }
            if (size <= origin.Length)
            {
                sequence.RemoveRange(size - 1, origin.Length - size + 1);
                sequence.Add(origin[sequence.Count]);
                return sequence.ToArray();
            }
            List<Type> spaces = new List<Type>();
            if (origin.Length < 2)
            { spaces.Add(Value<Type>(0)); }
            else
            {
                for (int i = 1; i < origin.Length; i++)
                { spaces.Add(origin[i] / (dynamic)origin[i - 1]); }
            }
            List<Type> rest = GeometricSequence<Type>(sequence[sequence.Count - 1], size, spaces.ToArray()).ToList();
            rest.RemoveAt(0);
            rest.RemoveAt(rest.Count - 1);
            sequence.AddRange(rest);
            return sequence.ToArray();
        }
        /// <summary>
        /// Finds the maximum number in an array of numbers.
        /// </summary>
        /// <typeparam name="Type">The selected type of the selected numbers.</typeparam>
        /// <param name="numbers">The selected numbers.</param>
        /// <returns>The maximum number in the selected numbers.</returns>
        public static Type Max<Type>(params Type[] numbers) where Type : IFormattable
        {
            if (numbers.Length <= 0)
            { return Value<Type>(0); }
            Type max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < (dynamic)numbers[i])
                { max = numbers[i]; }
            }
            return max;
        }
        /// <summary>
        /// Finds the minimum number in an array of numbers.
        /// </summary>
        /// <typeparam name="Type">The selected type of the selected numbers.</typeparam>
        /// <param name="numbers">The selected numbers.</param>
        /// <returns>The minimum number in the selected numbers.</returns>
        public static Type Min<Type>(params Type[] numbers) where Type : IFormattable
        {
            if (numbers.Length <= 0)
            { return Value<Type>(0); }
            Type min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > (dynamic)numbers[i])
                { min = numbers[i]; }
            }
            return min;
        }
        /// <summary>
        /// Calculates the summation of an array of numbers.
        /// </summary>
        /// <typeparam name="Type">The selected type of the selected numbers.</typeparam>
        /// <param name="numbers">The selected numbers.</param>
        /// <returns>A value that represents the summation of the selected numbers.</returns>
        public static Type Sum<Type>(params Type[] numbers) where Type : IFormattable
        {
            Type sum = Value<Type>(0);
            for (int i = 0; i < numbers.Length; i++)
            { sum += (dynamic)numbers[i]; }
            return sum;
        }
        /// <summary>
        /// Calculates the average of an array of numbers.
        /// </summary>
        /// <typeparam name="Type">The selected type of the selected numbers.</typeparam>
        /// <param name="numbers">The selected numbers.</param>
        /// <returns>A value that represents the average of the selected numbers.</returns>
        public static Type Average<Type>(params Type[] numbers) where Type : IFormattable
        => numbers.Length == 0 ? 0 : Sum(numbers) / (dynamic)(double)numbers.Length;
        /// <summary>
        /// Finds the elements that is in the middle of an array of numbers, (returns the average of the two elements at the middle if the count is not odd).
        /// </summary>
        /// <param name="numbers">The selected numbers.</param>
        /// <returns>The number that is in the middle of the selected numbers.</returns>
        public static Type Median<Type>(params Type[] numbers) where Type : IFormattable
        => numbers.Length == 0 ? Value<Type>(0) : IsOdd(numbers.Length) ? numbers[numbers.Length / 2] : Average(numbers[numbers.Length / 2 - 1], numbers[numbers.Length / 2]);
        /// <summary>
        /// Calculates the range of an array of numbers, (the largest element minus the smallest element).
        /// </summary>
        /// <param name="numbers">The selected numbers.</param>
        /// <returns>A value that represents the range of the selected numbers.</returns>
        public static Type Range<Type>(params Type[] numbers) where Type : IFormattable
        => numbers.Length < 1 ? Value<Type>(0) : Max(numbers) - (dynamic)Min(numbers);
        /// <summary>
        /// Finds the most repeatitve number in an array of numbers.
        /// </summary>
        /// <param name="numbers">The selected numbers.</param>
        /// <returns>The number that is repeated the most in the selected numbers.</returns>
        public static Type Mode<Type>(params Type[] numbers) where Type : IFormattable
        {
            if (numbers.Length == 0) { return Value<Type>(0); }
            Type mode = numbers[0], count = Value<Type>(1);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (mode == (dynamic)numbers[i]) { continue; }
                int count_ = numbers.ToList().FindAll((Type x) => { return x == (dynamic)numbers[i]; }).Count;
                if (count_ > (dynamic)count)
                { mode = numbers[i]; count = (dynamic)count_; }
            }
            return mode;
        }
        /// <summary>
        /// Sorts an array of numbers incrementally.
        /// </summary>
        /// <typeparam name="Type">The selected type of the selected numbers.</typeparam>
        /// <param name="numbers">The selected numbers.</param>
        /// <returns>A new array that represents the old one but sorted incrementally.</returns>
        public static Type[] SortIncrementally<Type>(params Type[] numbers) where Type : IFormattable
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > (dynamic)numbers[j])
                    {
                        Type z = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = z;
                    }
                }
            }
            return numbers;
        }
        /// <summary>
        /// Sorts an array of numbers decrementally.
        /// </summary>
        /// <typeparam name="Type">The selected type of the selected numbers.</typeparam>
        /// <param name="numbers">The selected numbers.</param>
        /// <returns>A new array that represents the old one but sorted decrementally.</returns>
        public static Type[] SortDecrementally<Type>(params Type[] numbers) where Type : IFormattable
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] < (dynamic)numbers[j])
                    {
                        Type z = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = z;
                    }
                }
            }
            return numbers;
        }
        /// <summary>
        /// Sorts an array of numbers incrementally.
        /// </summary>
        /// <typeparam name="Type">The selected type of the selected numbers.</typeparam>
        /// <param name="numbers">The selected numbers.</param>
        public static void SortIncrementally<Type>(ref Type[] numbers) where Type : IFormattable
        => numbers = SortIncrementally(numbers);
        /// <summary>
        /// Sorts an array of numbers decrementally.
        /// </summary>
        /// <typeparam name="Type">The selected type of the selected numbers.</typeparam>
        /// <param name="numbers">The selected numbers.</param>
        public static void SortDecrementally<Type>(ref Type[] numbers) where Type : IFormattable
        => numbers = SortDecrementally(numbers);
        /// <summary>
        /// Shuffles an array of numbers.
        /// </summary>
        /// <typeparam name="Type">The selected type of the selected numbers.</typeparam>
        /// <param name="array">The selected array.</param>
        /// <returns>The selected array after its numbers have been shuffled.</returns>
        public static Type[] Shuffle<Type>(params Type[] array)
        {
            int count = array.Length * 2,
                min = 0,
                max = array.Length - 1;
            for (int i = 0; i < count; i++)
            {
                int src = i % (array.Length - 1);
                int trg = RandomInteger(min, max);
                object tmp = array.GetValue(trg);
                array.SetValue(array.GetValue(src), trg);
                array.SetValue(tmp, src);
            }
            return array;
        }
        /// <summary>
        /// Shuffles an array of numbers.
        /// </summary>
        /// <typeparam name="Type">The selected type of the selected numbers.</typeparam>
        /// <param name="array">The selected array.</param>
        public static void Shuffle<Type>(ref Type[] array)
        => array = Shuffle(array);
        #endregion

        #region #Equations
        /// <summary>
        /// Calculates the value of x in an equation with the form of (ax + b = 0).
        /// </summary>
        /// <param name="a">The proverbs of x.</param>
        /// <param name="b">The added part.</param>
        /// <returns>The value of x that satisfy the selected Equation.</returns>
        public static double OneDimensionalEquation(double a, double b)
        => a == 0 ? b != 0 ? NaN : 0 : (-b) / a;
        /// <summary>
        /// Calculates the value of x in an equation with the form of (ax + b = 0).
        /// </summary>
        /// <param name="a">The proverbs of x.</param>
        /// <param name="b">The added part.</param>
        /// <param name="form">The form of the equation according to the values.</param>
        /// <returns>The value of x that satisfy the selected Equation.</returns>
        public static double OneDimensionalEquation(double a, double b, out string form)
        {
            form = "";
            string a_ = a.ToString(),
                   b_ = b.ToString();
            if (a == 0) { form = b == 0 ? b_ + " = 0" : b_ + " != 0"; }
            else
            {
                a_ = a == 1 ? "x" : a == -1 ? "-x" : a_ + "x";
                b_ = b == 0 ? "" : b > 0 ? " + " + b : " - " + -b;
                form = a_ + b_ + " = 0";
            }
            return OneDimensionalEquation(a, b);
        }
        /// <summary>
        /// Calculates the value of x in an equation with the form of (ax + b = 0).
        /// </summary>
        /// <param name="a">The proverbs of x.</param>
        /// <param name="b">The added part.</param>
        /// <param name="form">The form of the equation according to the values.</param>
        /// <param name="domain">The domain (values of x) of the Equation.</param>
        /// <param name="range">The range (values of y) of the Equation.</param>
        /// <returns>The value of x that satisfy the selected Equation.</returns>
        public static double OneDimensionalEquation(double a, double b, out string form, out string domain, out string range)
        {
            domain = range = "] " + NegativeInfinity + " , +" + PositiveInfinity + " [";
            return OneDimensionalEquation(a, b, out form);
        }

        /// <summary>
        /// Calculates the value of x (only in the Real Numbers Category) in an equation with the form of (ax^2 + bx + c = 0).
        /// </summary>
        /// <param name="a">The proverbs of x^2.</param>
        /// <param name="b">The proverbs of x.</param>
        /// <param name="c">The added part.</param>
        /// <param name="x1">The first value of x that satisfies the Equation.</param>
        /// <param name="x2">The second value of x that satisfies the Equation.</param>
        /// <returns>The value of x that satisfies the selected Equation.</returns>
        public static string TwoDimensionalEquation(double a, double b, double c, out double x1, out double x2)
        {
            string x;
            if (a == 0)
            {
                if (b == 0) { x1 = x2 = double.NaN; x = x1.ToString(); }
                else { x1 = x2 = OneDimensionalEquation(b, c); x = x1.ToString(); }
            }
            else
            {
                double delta = Power(b, 2) - (4 * a * c);
                if (IsNuteral(delta)) { x1 = x2 = (-b / (2 * a)); x = x1.ToString(); }
                else if (IsPositive(delta))
                {
                    double sqrtDelta1, sqrtDelta2;
                    SquareRoot(delta, out sqrtDelta1, out sqrtDelta2);
                    x1 = (-b + sqrtDelta1) / (2 * a);
                    x2 = (-b + sqrtDelta2) / (2 * a);
                    double i_ = sqrtDelta1 / (2 * a);
                    i_ = (double)Absolute((decimal)i_);
                    x = b == 0 ? "+-" + i_ :
                              -b / (2 * a) + " +- " + ((i_ > 0) ? i_ : -i_);
                }
                else { x1 = x2 = NaN; x = x1.ToString(); }
            }
            return x;
        }
        /// <summary>
        /// Calculates the value of x (in both; Real and Complex Numbers Category) in an equation with the form of (ax^2 + bx + c = 0).
        /// </summary>
        /// <param name="a">The proverbs of x^2.</param>
        /// <param name="b">The proverbs of x.</param>
        /// <param name="c">The added part.</param>
        /// <param name="complex1">The first value of x that satisfies the Equation.</param>
        /// <param name="complex2">The second value of x that satisfies the Equation.</param>
        /// <returns>The value of x that satisfy the selected Equation.</returns>
        public static string TwoDimensionalEquation(double a, double b, double c, out Complex complex1, out Complex complex2)
        {
            double delta = Power(b, 2) - (4 * a * c);
            string complex;
            if (IsNegative(delta))
            {
                Imaginary sqrtDelta1, sqrtDelta2;
                SquareRoot(delta, out sqrtDelta1, out sqrtDelta2);
                complex1 = new Complex(-b / (2 * a), sqrtDelta1 / (2 * a));
                complex2 = new Complex(-b / (2 * a), sqrtDelta2 / (2 * a));
                Imaginary i_ = sqrtDelta1 / (2 * a);
                i_ = i * Absolute(i_.Proverbs);
                complex = b == 0 ? "+-" + i_ :
                          -b / (2 * a) + " +- " + ((i_ > i * 0) ? i_ : -i_);
            }
            else
            {
                double x1, x2;
                complex = TwoDimensionalEquation(a, b, c, out x1, out x2);
                complex1 = new Complex(x1, i * 0); complex2 = new Complex(x2, i * 0);
            }
            return complex;
        }
        /// <summary>
        /// Calculates the value of x (only in the Real Numbers Category) in an equation with the form of (ax^2 + bx + c = 0).
        /// </summary>
        /// <param name="a">The proverbs of x^2.</param>
        /// <param name="b">The proverbs of x.</param>
        /// <param name="c">The added part.</param>
        /// <param name="x1">The first value of x that satisfies the Equation.</param>
        /// <param name="x2">The second value of x that satisfies the Equation.</param>
        /// <param name="form">The form of the equation according to the values.</param>
        /// <returns>The value of x that satisfies the selected Equation.</returns>
        public static string TwoDimensionalEquation(double a, double b, double c, out double x1, out double x2, out string form)
        {
            form = "";
            string a_ = a.ToString(),
                   b_ = b.ToString(),
                   c_ = c.ToString();
            if (a == 0 && b == 0) { form = c == 0 ? c_ + " = 0" : c_ + " != 0"; }
            else
            {
                a_ = a == 0 ? "" : a == 1 ? "x^2" : a == -1 ? "-x^2" : a_ + "x^2";
                b_ = b == 0 ? "" : b > 1 ? (a != 0 ? " + " : "") + b + "x" : b < -1 ? (a != 0 ? " - " : "-") + -b + "x" : b == 1 ? (a != 0 ? " + " : "") + "x" : (a != 0 ? " - " : "-") + "x";
                c_ = c == 0 ? "" : c > 0 ? " + " + c : " - " + -c;
                form = a_ + b_ + c_ + " = 0";
            }
            return TwoDimensionalEquation(a, b, c, out x1, out x2);
        }
        /// <summary>
        /// Calculates the value of x (in both; Real and Complex Numbers Category) in an equation with the form of (ax^2 + bx + c = 0).
        /// </summary>
        /// <param name="a">The proverbs of x^2.</param>
        /// <param name="b">The proverbs of x.</param>
        /// <param name="c">The added part.</param>
        /// <param name="complex1">The first value of x that satisfies the Equation.</param>
        /// <param name="complex2">The second value of x that satisfies the Equation.</param>
        /// <param name="form">The form of the equation according to the values.</param>
        /// <returns>The value of x that satisfies the selected Equation.</returns>
        public static string TwoDimensionalEquation(double a, double b, double c, out Complex complex1, out Complex complex2, out string form)
        {
            double x1, x2;
            TwoDimensionalEquation(a, b, c, out x1, out x2, out form);
            return TwoDimensionalEquation(a, b, c, out complex1, out complex2);
        }
        /// <summary>
        /// Calculates the value of x (only in the Real Numbers Category) in an equation with the form of (ax^2 + bx + c = 0).
        /// </summary>
        /// <param name="a">The proverbs of x^2.</param>
        /// <param name="b">The proverbs of x.</param>
        /// <param name="c">The added part.</param>
        /// <param name="x1">The first value of x that satisfies the Equation.</param>
        /// <param name="x2">The second value of x that satisfies the Equation.</param>
        /// <param name="form">The form of the equation according to the values.</param>
        /// <param name="domain">The domain (values of x) of the Equation.</param>
        /// <param name="range">The range (values of y) of the Equation.</param>
        /// <returns>The value of x that satisfies the selected Equation.</returns>
        public static string TwoDimensionalEquation(double a, double b, double c, out double x1, out double x2, out string form, out string domain, out string range)
        {
            domain = "] " + NegativeInfinity + " , +" + PositiveInfinity + " [";
            // ax^2 + bx + c = 0
            // a[x^2 b/a(x)] + c = 0
            // a[x^2 + b/a(x) + (b/2a)^2 - (b/2a)^2] + c = 0
            // a[(x + b/2a)^2 - (b/2a)^2] + c = 0
            // a(x + b/2a)^2 - b^2/4a + c = 0
            //        -inf       <       x        <       +inf
            //        -inf       <   x + b/2a     <       +inf
            //          0        <= a(x + b/2a)^2 <       +inf
            // -b^2/4a + c       <=     f(x)      <       +inf
            double greatestPoint = (-Power(b, 2) / (4 * a) + c);
            range = a == 0 ?
                   "] " + NegativeInfinity + " , +" + PositiveInfinity + " [" :
                   a > 0 ?
                   "[ " + greatestPoint + " , +" + PositiveInfinity + " [" :
                   "] " + NegativeInfinity + " , " + greatestPoint + " ]";
            return TwoDimensionalEquation(a, b, c, out x1, out x2, out form);
        }
        /// <summary>
        /// Calculates the value of x (in both; Real and Complex Numbers Category) in an equation with the form of (ax^2 + bx + c = 0).
        /// </summary>
        /// <param name="a">The proverbs of x^2.</param>
        /// <param name="b">The proverbs of x.</param>
        /// <param name="c">The added part.</param>
        /// <param name="x1">The first value of x that satisfies the Equation.</param>
        /// <param name="x2">The second value of x that satisfies the Equation.</param>
        /// <param name="form">The form of the equation according to the values.</param>
        /// <param name="domain">The domain (values of x) of the Equation.</param>
        /// <param name="range">The range (values of y) of the Equation.</param>
        /// <returns>The value of x that satisfies the selected Equation.</returns>
        public static string TwoDimensionalEquation(double a, double b, double c, out Complex complex1, out Complex complex2, out string form, out string domain, out string range)
        {
            double x1, x2;
            TwoDimensionalEquation(a, b, c, out x1, out x2, out form, out domain, out range);
            return TwoDimensionalEquation(a, b, c, out complex1, out complex2, out form);
        }

        /// <summary>
        /// Calculates the value of x in an equation with the form of (ax^3 + bx^2 + cx + d = 0).
        /// </summary>
        /// <param name="a">The proverbs of x^3.</param>
        /// <param name="b">The proverbs of x^2.</param>
        /// <param name="c">The proverbs of x.</param>
        /// <param name="d">The added part.</param>
        /// <returns>The value of x that satisfy the selected Equation.</returns>
        public static double[] ThreeDimensionalEquation(double a, double b, double c, double d)
        {
            double p = -Cube((b / (3 * a)))
                       + (b * c) / (6 * Square(a))
                       - d / (2 * a),
                   q = c / (3 * a)
                       - Square((b / (3 * a)));
            double negative = CubeRoot(p - SquareRoot(Square(p) + Cube(q))),
                   positive = CubeRoot(p + SquareRoot(Square(p) + Cube(q)));
            double[] x = new double[3];
            x[0] = negative + positive - b / (3 * a);
            x[1] = negative + negative - b / (3 * a);
            x[2] = positive + positive - b / (3 * a);
            return x;
        }

        /// <summary>
        /// Creates a string set for a side of an Equation.
        /// </summary>
        /// <param name="variables">The Variables that are inserted within the side of the Equation.</param>
        /// <returns>A string value that represents the formed side of the Equation.</returns>
        public static string CreateSideEquation(params Calculus.Variable[] variables)
        {
            string side = "";
            for (int i = 0, j = 0; i < variables.Length; i++)
            {
                Calculus.Variable variable = variables[i];
                if (variable.Proverbs == 0)
                { continue; }
                string sign = variable.Proverbs < 0 ? "-" : "+";
                string sign_ = j == 0 ? (sign == "+" ? "" : "-") : $" {sign} ";
                string proverbs = Absolute(variable.Proverbs) == 1 ? (variable.Power == 0 ? "1" : "") : Absolute(variable.Proverbs).ToString();
                string power = variable.Power == 0 || variable.Power == 1 ? "" : $"^{(variable.Power < 0 ? $"({variable.Power.ToString()})" : variable.Power.ToString())}";
                side += sign_ + proverbs;
                j++;
                if (variable.Power == 0)
                { continue; }
                side += variable.Character.ToString() + power;
            }
            return side;
        }
        /// <summary>
        /// Creates a string set for a Function.
        /// </summary>
        /// <param name="functionCharacter">The character of the Function.</param>
        /// <param name="variables">The Variables that are inserted within the Function.</param>
        /// <returns>A string value that represents the formed Function along side with the Variables.</returns>
        public static string CreateFunction(Calculus.FunctionCharacter functionCharacter, params Calculus.Variable[] variables)
        => new Calculus.Function(functionCharacter, variables).Form;
        /// <summary>
        /// Creates a string set for a Function.
        /// </summary>
        /// <param name="functionCharacter">The character of the Function.</param>
        /// <param name="function">The created Function.</param>
        /// <param name="variables">The Variables that are inserted within the Function.</param>
        /// <returns>A string value that represents the formed Function along side with the Variables.</returns>
        public static string CreateFunction(Calculus.FunctionCharacter functionCharacter, out Calculus.Function function, params Calculus.Variable[] variables)
        {
            function = new Calculus.Function(functionCharacter, variables);
            return function.Form;
        }
        /// <summary>
        /// Creates a string set for an Equation, (all Variables in one side equal to Zero).
        /// </summary>
        /// <param name="variables">The Variables that are inserted within the Equation.</param>
        /// <returns>A string value that represents the formed Equation along side with the Variables.</returns>
        public static string CreateEquation(params Calculus.Variable[] variables)
        => new Calculus.Equation(variables).Form;
        /// <summary>
        /// Creates a string set for an Equation, (all Variables in one side equal to Zero).
        /// </summary>
        /// <param name="equation">The created Equation.</param>
        /// <param name="variables">The Variables that are inserted within the Equation.</param>
        /// <returns>A string value that represents the formed Equation along side with the Variables.</returns>
        public static string CreateEquation(out Calculus.Equation equation, params Calculus.Variable[] variables)
        {
            equation = new Calculus.Equation(variables);
            return equation.Form;
        }
        /// <summary>
        /// Solves one-dimensional-two-variables Equations, and gives the answers for each Variable.
        /// </summary>
        /// <param name="firstEquation">The first selected Equation to solve.</param>
        /// <param name="secondEquation">The second selected Equation to solve.</param>
        /// <returns>The values of each Variable within the Equations, (its count equal to Equations count).</returns>
        public static double[] TwoVariablesEquations(Calculus.Equation firstEquation, Calculus.Equation secondEquation)
        {
            var firstVariables = firstEquation.Variables.Where(new Func<Calculus.Variable, bool>(delegate (Calculus.Variable v) { return v.Power == 1 || v.Power == 0; })).ToArray();
            var secondVariables = secondEquation.Variables.Where(new Func<Calculus.Variable, bool>(delegate (Calculus.Variable v) { return v.Power == 1 || v.Power == 0; })).ToArray();
            if (firstVariables.Length > 3 || secondVariables.Length > 3)
            { return new double[] { }; }
            double delta = firstVariables[0].Proverbs * secondEquation[1].Proverbs - firstVariables[1].Proverbs * secondEquation[0].Proverbs;
            double deltaX = -firstVariables[2].Proverbs * secondEquation[1].Proverbs - firstVariables[1].Proverbs * -secondEquation[2].Proverbs;
            double deltaY = firstVariables[0].Proverbs * -secondEquation[2].Proverbs - -firstVariables[2].Proverbs * secondEquation[0].Proverbs;
            return new double[] { deltaX / delta, deltaY / delta };
        }
        /// <summary>
        /// Solves One degree Ploynomial Equations, and returns their answers in a Matrix, (note that the amount of equations shall match the amount of variables, else no solutions exist).
        /// </summary>
        /// <param name="equations">The selected Equations to solve.</param>
        /// <returns>A Matrix that represents the solutions of the variables ordered in the their order.</returns>
        public static Matrix<double> OneDegreePolynomialEquations(params Calculus.Equation[] equations)
        {
            int variablesAmount = 0,
                maximumVariables = 0;
            for (int i = 0; i < equations.Length; i++)
            {
                if (equations[i].Variables.Where(delegate (Calculus.Variable variable) { return variable.Power != 0; }).Count() > variablesAmount)
                {
                    variablesAmount = equations[i].Variables.Where(delegate (Calculus.Variable variable) { return variable.Power != 0; }).Count();
                    maximumVariables = i;
                }
            }
            for (int i = 0; i < variablesAmount; i++)
            {
                for (int j = 0; j < equations.Length; j++)
                {
                    if (equations[j].Variables.Count < variablesAmount || equations[maximumVariables].Variables[i] != equations[j].Variables[i])
                    { equations[j].Add(new Calculus.Variable(0, 1, equations[maximumVariables].Variables[i].Character)); }
                }
            }
            if (variablesAmount != equations.Length) { return new Matrix<double>(0); }
            List<int>[] lostVariables = new List<int>[variablesAmount];
            for (int i = 0; i < equations.Length; i++)
            {
                // i : for equations.
                // j : for maximum equation variables variables.
                // k : for equations variables.
                if (i == maximumVariables) { continue; }
                lostVariables[i] = new List<int>();
                for (int j = 0; j < equations[maximumVariables].Variables.Count; j++)
                {
                    for (int k = 0; k < equations[i].Variables.Count; k++)
                    {
                        if (equations[maximumVariables].Variables[j].Character != equations[i].Variables[k].Character)
                        { lostVariables[i].Add(k); }
                    }
                }
            }
            Matrix<double> matrix = new Matrix<double>(variablesAmount);
            for (int i = 0, j = 0; i < matrix.Height; i += j == matrix.Width - 1 ? 1 : 0, j = j == matrix.Width - 1 ? 0 : j + 1)
            { matrix[i, j] = equations[i].Variables[j].Power == 1 ? equations[i].Variables[j].Proverbs : 0; }
            Matrix<double> resultsMatrix = new Matrix<double>(1, variablesAmount);
            for (int i = 0, j = 0; i < resultsMatrix.Height; i += j == resultsMatrix.Width - 1 ? 1 : 0, j = j == resultsMatrix.Width - 1 ? 0 : j + 1)
            { resultsMatrix[j, i] = equations[i].Variables[equations[i].Variables.Count - 1].Power == 0 ? -equations[i].Variables[equations[i].Variables.Count - 1].Proverbs : 0; }
            return matrix.Transpose.Inverse * resultsMatrix;
        }
        /// <summary>
        /// Solves One degree Ploynomial Equations, and returns their answers in a Matrix, (note that the amount of equations shall match the amount of variables, else no solutions exist).
        /// </summary>
        /// <param name="results">To get the results of the Equations as an array.</param>
        /// <param name="equations">The selected Equations to solve.</param>
        /// <returns>A Matrix that represents the solutions of the variables ordered in the their order.</returns>
        public static Matrix<double> OneDegreePolynomialEquations(out double[] results, params Calculus.Equation[] equations)
        { results = OneDegreePolynomialEquations(equations).ToList().ToArray(); return OneDegreePolynomialEquations(equations); }
        #endregion

        #region #Trigonometry
        /// <summary>
        /// Initilizes the angle into a value from 0 degrees to 360 degrees.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The same angle value represented between 0 degrees and 360 degrees.</returns>
        public static double InitializeInCircle(double θ)
        {
            while (θ >= 360d)
            { θ -= 360d; }
            while (θ < 0d)
            { θ += 360d; }
            return θ;
        }
        /// <summary>
        /// Initilizes the angle into a value from 0 degrees to 90 degrees.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The same angle value represented between 0 degrees and 90 degrees.</returns>
        public static double InitializeInQuarter(double θ)
        {
            while (θ >= 90d)
            {
                if (θ % 180d != 0) { θ -= 90d; }
                else { θ = 0d; }
            }
            while (θ < 0d)
            {
                if (θ % 180d != 0) { θ += 90d; }
                else { θ = 90d; }
            }
            return θ;
        }
        /// <summary>
        /// Determines the quarter of the Unit Circle that the angle is set in.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The number of the quarter in the Unit Circle.</returns>
        public static int GetQuarter(double θ)
        {
            θ = InitializeInCircle(θ);
            return θ >= 270d ? 4 : θ >= 180d ? 3 : θ >= 90d ? 2 : 1;
        }

        #region #Regular
        /// <summary>
        /// Handles all the boring Sine Calculation stuff, which all other functions drive from.
        /// </summary>
        /// <param name="x">Represents the angle, (measured in Degrees).</param>
        /// <param name="n">Represents the angle's current power.</param>
        /// <returns>A part of the Sine Calculation.</returns>
        private static double SinCalculation(double x, int n)
        => Power(-1m, n) * (Power(x, 2 * n + 1)) / Factorial(2 * n + 1);
        /// <summary>
        /// Calculates the Sine of the angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The Sine value of the angle.</returns>
        public static double Sin(double θ)
        {
            int negative = Sign(θ);
            Absolute(ref θ);
            θ = InitializeInCircle(θ);
            int quarter = GetQuarter(θ);
            θ = InitializeInQuarter(θ);
            negative *= quarter == 1 || quarter == 2 ? +1 : -1;
            θ = θ != 90 && (quarter == 2 || quarter == 4) ?
                90 - θ : θ;
            bool small = θ < 1;
            bool large = θ > 89.5 && θ != 90;
            θ = ToRadian(θ);
            double value = 0.0d;
            for (int i = 0; i <= 7; i++)
            { value += SinCalculation(θ, i); }
            double sin = value * negative;
            return small || large ? sin : Accurate(sin, 0.000029d);
        }
        /// <summary>
        /// Calculates the Cosine of the angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The Cosine value of the angle.</returns>
        public static double Cos(double θ)
        {
            Absolute(ref θ);
            if (θ == 90d || θ == 270d)
            { return 0; }
            θ = InitializeInCircle(θ);
            int quarter = GetQuarter(θ);
            θ = InitializeInQuarter(θ);
            θ = quarter == 2 || quarter == 4 ?
                90 - θ : θ;
            bool small = θ < 1;
            bool large = θ > 89.5 && θ < 90;
            int negative = quarter == 1 || quarter == 4 ? +1 : -1;
            double cos = (1 - 2 * Square(Sin(θ / 2d))) * negative;
            return small || large ? cos : Accurate(cos, 0.000029d);
        }
        /// <summary>
        /// Calculates the Tangent of the angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The Tangent value of the angle.</returns>
        public static double Tan(double θ)
        {
            if (Cos(θ) == 0)
            { return NaN; }
            bool small = θ < 1;
            bool large = θ > 89.5 && θ != 90;
            double tan = Sin(θ) / Cos(θ);
            return small || large ? tan : Accurate(tan, 0.000029d);
        }
        /// <summary>
        /// Calculates the Cotangent of the angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The Cotangent value of the angle.</returns>
        public static double Cot(double θ)
        {
            if (Sin(θ) == 0)
            { return NaN; }
            bool small = θ < 1;
            bool large = θ > 89.5 && θ != 90;
            double cot = Cos(θ) / Sin(θ);
            return small || large ? cot : Accurate(cot, 0.000029d);
        }
        /// <summary>
        /// Calculates the Secant of the angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The Secant value of the angle.</returns>
        public static double Sec(double θ)
        {
            if (Cos(θ) == 0)
            { return NaN; }
            return 1 / Cos(θ);
        }
        /// <summary>
        /// Calculates the Cosecant of the angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The Cosecant value of the angle.</returns>
        public static double Csc(double θ)
        {
            if (Sin(θ) == 0)
            { return NaN; }
            return 1d / Sin(θ);
        }
        #endregion

        #region #Arcs
        /// <summary>
        /// Handles all the boring Arcsine Calculation stuff, which all other functions drive from.
        /// </summary>
        /// <param name="x">Represents the angle, (measured in Degrees).</param>
        /// <param name="n">Represents the angle's current power.</param>
        /// <returns>A part of the Arcsine Calculation.</returns>
        private static double ArcsinCalculation(double value, int n)
        => (Factorial(2 * n) / (Square(Power(2, (decimal)n) * Factorial(n)))) * ((Power(value, 2 * n + 1) / (2 * n + 1)));
        /// <summary>
        /// Calculates the Arcsine of the value, (the angle whose Sine is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <returns>The angle whose Sine is the selected value.</returns>
        public static double Arcsin(double value)
        {
            if (!IsBetween(value, -1, 1, true))
            { return NaN; }
            int negative = Sign(value);
            value = Absolute(value);
            bool half = value > Sin(45);
            value = half ? SquareRoot(1 - Square(value)) : value;
            double result = 0;
            for (int i = 0; i < 9; i++)
            { result += ArcsinCalculation(value, i); }
            result = half ? ((double)Pi / 2 - result) * negative : result * negative;
            result = result < 0 ? (double)Pi - result : result;
            return Accurate(ToDegree(result), 0.0029d);
        }
        /// <summary>
        /// Calculates the Arcsine of the value, (the angles whose Sine is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <param name="θ1">The first angle whose Sine is the value.</param>
        /// <param name="θ2">The second angle whose Sine is the value.</param>
        /// <returns>The angles whose Sine is the selected value.</returns>
        public static double Arcsin(double value, out double θ1, out double θ2)
        {
            if (!IsBetween(value, -1, 1, true))
            { θ1 = θ2 = NaN; return θ1; }
            θ1 = Arcsin(value);
            θ2 = 180 - θ1;
            θ2 = θ2 < 0 ? 360 + θ2 : θ2;
            θ2 = InitializeInCircle(θ2);
            θ1 = Accurate(θ1, 0.0029d);
            θ2 = Accurate(θ2, 0.0029d);
            return θ1;
        }
        /// <summary>
        /// Calculates the Arccosine of the value, (the angle whose Cosine is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <returns>The angle whose Cosine is the selected value.</returns>
        public static double Arccos(double value)
        {
            if (!IsBetween(value, -1, 1, true))
            { return NaN; }
            int negative = Sign(value);
            value = Absolute(value);
            double result = 90 - Arcsin(value);
            result = negative > 0 ? result : 180 - result;
            return Accurate(result, 0.0029d);
        }
        /// <summary>
        /// Calculates the Arccosine of the value, (the angles whose Cosine is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <param name="θ1">The first angle whose Sine is the value.</param>
        /// <param name="θ2">The second angle whose Sine is the value.</param>
        /// <returns>The angles whose Cosine is the selected value.</returns>
        public static double Arccos(double value, out double θ1, out double θ2)
        {
            if (!IsBetween(value, -1, 1, true))
            { θ1 = θ2 = NaN; return θ1; }
            θ1 = Arccos(value);
            θ2 = InitializeInCircle(360 - θ1);
            θ1 = Accurate(θ1, 0.0029d);
            θ2 = Accurate(θ2, 0.0029d);
            return θ1;
        }
        /// <summary>
        /// Calculates the ArcTangent of the value, (the angle whose Tangent is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <returns>The angle whose Tangent is the selected value.</returns>
        public static double Arctan(double value)
        {
            // Sinx^2 / Cosx^2 = Tanx^2 
            // Sinx^2 + Cosx^2 / Cosx^2 = Tanx^2 + 1
            // 1 / Cosx^2 = Tanx^2 + 1
            // 1 / (Tanx^2 + 1) = Cosx^2
            // Cosx^2 = (Cos2x + 1) / 2 = 1 / (Tanx^2 + 1)
            // Cosx / 2 = 2 / (Tanx^2 + 1) - 1
            if (!(value < double.MaxValue && value > double.MinValue)) { return 90; }
            int negative = Sign(value);
            value = Absolute(value);
            double result = Arccos(2 / (Square(value) + 1) - 1) * negative / 2;
            result = result < 0 ? 180 + result : result;
            return Accurate(result, 0.0029d);
        }
        /// <summary>
        /// Calculates the ArcTangent of the value, (the angles whose Tangent is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <param name="θ1">The first angle whose Sine is the value.</param>
        /// <param name="θ2">The second angle whose Sine is the value.</param>
        /// <returns>The angles whose Tangent is the selected value.</returns>
        public static double Arctan(double value, out double θ1, out double θ2)
        {
            if (!(value < double.MaxValue && value > double.MinValue))
            { θ1 = 90; θ2 = 270; return θ1; }
            θ1 = Arctan(value);
            θ2 = InitializeInCircle(180 + θ1);
            θ1 = Accurate(θ1, 0.0029d);
            θ2 = Accurate(θ2, 0.0029d);
            return θ1;
        }
        /// <summary>
        /// Calculates the ArccoTangent of the value, (the angle whose Cotangent is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <returns>The angle whose Cotangent is the selected value.</returns>
        public static double Arccot(double value)
        {
            if (!(value < double.MaxValue && value > double.MinValue)) { return 0; }
            int negative = Sign(value);
            value = Absolute(value);
            double result = 90 - Arctan(value);
            result = negative > 0 ? result : 180 - result;
            result = result < 0 ? 180 + result : result;
            return Accurate(result, 0.0029d);
        }
        /// <summary>
        /// Calculates the ArccoTangent of the value, (the angles whose Cotangent is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <param name="θ1">The first angle whose Sine is the value.</param>
        /// <param name="θ2">The second angle whose Sine is the value.</param>
        /// <returns>The angles whose Cotangent is the selected value.</returns>
        public static double Arccot(double value, out double θ1, out double θ2)
        {
            if (!(value < double.MaxValue && value > double.MinValue))
            { θ1 = 0; θ2 = 180; return θ1; }
            θ1 = Arccot(value);
            θ2 = InitializeInCircle(180 + θ1);
            θ1 = Accurate(θ1, 0.0029d);
            θ2 = Accurate(θ2, 0.0029d);
            return θ1;
        }
        /// <summary>
        /// Calculates the Arcsecant of the value, (the angle whose Secant is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <returns>The angle whose Secant is the selected value.</returns>
        public static double Arcsec(double value)
        {
            if (!(value < double.MaxValue && value > double.MinValue)) { return 90; }
            if (IsBetween(value, -1, 1, false))
            { return NaN; }
            int negative = Sign(value);
            value = Absolute(value);
            double result = Arccos(1 / value);
            result = negative > 0 ? result : 180 - result;
            result = result < 0 ? 360 + result : result;
            return Accurate(result, 0.0029d);
        }
        /// <summary>
        /// Calculates the Arcsecant of the value, (the angles whose Secant is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <param name="θ1">The first angle whose Sine is the value.</param>
        /// <param name="θ2">The second angle whose Sine is the value.</param>
        /// <returns>The angles whose Secant is the selected value.</returns>
        public static double Arcsec(double value, out double θ1, out double θ2)
        {
            if (!(value < double.MaxValue && value > double.MinValue))
            { θ1 = 90; θ2 = 270; return θ1; }
            if (IsBetween(value, -1, 1, false))
            { θ1 = θ2 = NaN; return NaN; }
            θ1 = Arcsec(value);
            θ2 = InitializeInCircle(360 - θ1);
            θ1 = Accurate(θ1, 0.0029d);
            θ2 = Accurate(θ2, 0.0029d);
            return θ1;
        }
        /// <summary>
        /// Calculates the Arccosecant of the value, (the angle whose Cosecant is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <returns>The angle whose Cosecant is the selected value.</returns>
        public static double Arccsc(double value)
        {
            if (!(value < double.MaxValue && value > double.MinValue)) { return 0; }
            if (IsBetween(value, -1, 1, false))
            { return NaN; }
            int negative = Sign(value);
            value = Absolute(value);
            double result = Arcsin(1 / value);
            result = negative > 0 ? result : 180 + result;
            result = result < 0 ? 2 * 180 + result : result;
            return Accurate(result, 0.0029d);
        }
        /// <summary>
        /// Calculates the Arccosecant of the value, (the angles whose Cosecant is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <param name="θ1">The first angle whose Sine is the value.</param>
        /// <param name="θ2">The second angle whose Sine is the value.</param>
        /// <returns>The angles whose Cosecant is the selected value.</returns>
        public static double Arccsc(double value, out double θ1, out double θ2)
        {
            if (!(value < double.MaxValue && value > double.MinValue))
            { θ1 = 0; θ2 = 180; return θ1; }
            θ1 = Arccsc(value);
            θ2 = InitializeInCircle(180 - θ1);
            θ2 = θ2 < 0 ? 360 + θ2 : θ2;
            θ1 = Accurate(θ1, 0.0029d);
            θ2 = Accurate(θ2, 0.0029d);
            return θ1;
        }
        #endregion

        #region #Hyperbolic
        /// <summary>
        /// Calculates the Hyperbolic Sine of the angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Sine value of the angle.</returns>
        public static double Sinh(double θ)
        {
            if (θ > 99999d) { return PositiveInfinity; }
            else if (θ < -99999d) { return NegativeInfinity; }
            return (RaiseEulerTo(θ) - RaiseEulerTo(-θ)) / 2;
        }
        /// <summary>
        /// Calculates the Hyperbolic Cosine of the angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Cosine value of the angle.</returns>
        public static double Cosh(double θ)
        {
            if (θ > 99999d || θ < -99999d) { return PositiveInfinity; }
            return (RaiseEulerTo(θ) + RaiseEulerTo(-θ)) / 2;
        }
        /// <summary>
        /// Calculates the Hyperbolic Tangent of the angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Tangent value of the angle.</returns>
        public static double Tanh(double θ)
        {
            if (Cosh(θ) >= Cosh(710)) { return θ > 0d ? 1 : -1; }
            if (Cosh(θ) == 0) { return NaN; }
            return Sinh(θ) / Cosh(θ);
        }
        /// <summary>
        /// Calculates the Hyperbolic Cotangent of the angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Cotangent value of the angle.</returns>
        public static double Coth(double θ)
        {
            if (Sinh(θ) >= Sinh(710) && θ > 0d) { return 1; }
            else if (Sinh(θ) <= Sinh(-710) && θ < 0d) { return -1; }
            if (Sinh(θ) == 0) { return NaN; }
            return Cosh(θ) / Sinh(θ);
        }
        /// <summary>
        /// Calculates the Hyperbolic Secant of the angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Secant value of the angle.</returns>
        public static double Sech(double θ)
        {
            if (Cosh(θ) == 0) { return NaN; }
            return 1 / Cosh(θ);
        }
        /// <summary>
        /// Calculates the Hyperbolic Cosecant of the angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Cosecant value of the angle.</returns>
        public static double Csch(double θ)
        {
            if (Sinh(θ) == 0) { return NaN; }
            return 1 / Sinh(θ);
        }
        #endregion

        #region #Imaginary
        /// <summary>
        /// Calculates the Sine of the angle.
        /// </summary>
        /// <param name="iθ">The selected Imaginary Angle, (measured in Degrees).</param>
        /// <returns>The Sine value of the angle.</returns>
        public static Imaginary Sin(Imaginary iθ)
        => i * Sinh(iθ.Proverbs);
        /// <summary>
        /// Calculates the Cosine of the angle.
        /// </summary>
        /// <param name="iθ">The selected Imaginary Angle, (measured in Degrees).</param>
        /// <returns>The Cosine value of the angle.</returns>
        public static Imaginary Cos(Imaginary iθ)
        => new Imaginary(Cosh(iθ.Proverbs)) / i;
        /// <summary>
        /// Calculates the Tangent of the angle.
        /// </summary>
        /// <param name="iθ">The selected Imaginary Angle, (measured in Degrees).</param>
        /// <returns>The Tangent value of the angle.</returns>
        public static Imaginary Tan(Imaginary iθ)
        => i * Tanh(iθ.Proverbs);
        /// <summary>
        /// Calculates the Cotangent of the angle.
        /// </summary>
        /// <param name="iθ">The selected Imaginary Angle, (measured in Degrees).</param>
        /// <returns>The Cotangent value of the angle.</returns>
        public static Imaginary Cot(Imaginary iθ)
        => -i * Coth(iθ.Proverbs);
        /// <summary>
        /// Calculates the Secant of the angle.
        /// </summary>
        /// <param name="iθ">The selected Imaginary Angle, (measured in Degrees).</param>
        /// <returns>The Secant value of the angle.</returns>
        public static Imaginary Sec(Imaginary iθ)
        => new Imaginary(Sech(iθ.Proverbs)) / i;
        /// <summary>
        /// Calculates the Cosecant of the angle.
        /// </summary>
        /// <param name="iθ">The selected Imaginary Angle, (measured in Degrees).</param>
        /// <returns>The Cosecant value of the angle.</returns>
        public static Imaginary Csc(Imaginary iθ)
        => -i * Csch(iθ.Proverbs);

        /// <summary>
        /// Calculates the Hyperbolic Sine of the angle.
        /// </summary>
        /// <param name="iθ">The selected Imaginary Angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Sine value of the angle.</returns>
        public static Imaginary Sinh(Imaginary iθ)
        => i * Sin(iθ.Proverbs);
        /// <summary>
        /// Calculates the Hyperbolic Cosine of the angle.
        /// </summary>
        /// <param name="iθ">The selected Imaginary Angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Cosine value of the angle.</returns>
        public static Imaginary Cosh(Imaginary iθ)
        => new Imaginary(Cos(iθ.Proverbs)) / i;
        /// <summary>
        /// Calculates the Hyperbolic Tangent of the angle.
        /// </summary>
        /// <param name="iθ">The selected Imaginary Angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Tangent value of the angle.</returns>
        public static Imaginary Tanh(Imaginary iθ)
        => i * Tan(iθ.Proverbs);
        /// <summary>
        /// Calculates the Hyperbolic Cotangent of the angle.
        /// </summary>
        /// <param name="iθ">The selected Imaginary Angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Cotangent value of the angle.</returns>
        public static Imaginary Coth(Imaginary iθ)
        => -i * Cot(iθ.Proverbs);
        /// <summary>
        /// Calculates the Hyperbolic Secant of the angle.
        /// </summary>
        /// <param name="iθ">The selected Imaginary Angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Secant value of the angle.</returns>
        public static Imaginary Sech(Imaginary iθ)
        => new Imaginary(Sec(iθ.Proverbs)) / i;
        /// <summary>
        /// Calculates the Hyperbolic Cosecant of the angle.
        /// </summary>
        /// <param name="iθ">The selected Imaginary Angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Cosecant value of the angle.</returns>
        public static Imaginary Csch(Imaginary iθ)
        => -i * Csc(iθ.Proverbs);
        #endregion

        #region #Hyperbolic Arcs
        /// <summary>
        /// Calculates the Hyperbolic Arcsine of the value, (the angle whose Hyperbolic Sine is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <returns>The angle whose Hyperbolic Sine is the selected value.</returns>
        public static double Arcsinh(double value)
        {
            int negative = value > 0 ? 1 : value < 0 ? -1 : 0;
            try
            {
                Absolute(ref value);
                double result = Ln(value + SquareRoot(Square(value) + 1)) * negative;
                return Accurate(result, 0.00029d);
            }
            catch { return PositiveInfinity * negative; }
        }
        /// <summary>
        /// Calculates the Hyperbolic Arccosine of the value, (the angle whose Hyperbolic Cosine is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <returns>The angle whose Hyperbolic Cosine is the selected value.</returns>
        public static double Arccosh(double value)
        {
            if (value < 1) { return NaN; }
            int negative = value > 0 ? 1 : value < 0 ? -1 : 0;
            try
            {
                Absolute(ref value);
                double result = Ln(value + SquareRoot(Square(value) - 1)) * negative;
                return Accurate(result, 0.00029d);
            }
            catch { return PositiveInfinity * negative; }
        }
        /// <summary>
        /// Calculates the Hyperbolic Arccosine of the value, (the angles whose Hyperbolic Cosine is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <param name="θ1">The first angle whose Hyperbolic Cosine is the value, (measured in Degrees).</param>
        /// <param name="θ2">The second angle whose Hyperbolic Cosine is the value, (measured in Degrees).</param>
        /// <returns>The angle whose Hyperbolic Cosine is the selected value.</returns>
        public static double Arccosh(double value, out double θ1, out double θ2)
        {
            θ1 = Arccosh(value);
            θ2 = -θ1;
            return θ1;
        }
        /// <summary>
        /// Calculates the Hyperbolic ArcTangent of the value, (the angle whose Hyperbolic Tangent is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <returns>The angle whose Hyperbolic Tangent is the selected value.</returns>
        public static double Arctanh(double value)
        {
            if (Absolute(value) >= 1) { return NaN; }
            return Accurate(0.5 * Ln(Absolute((value + 1) / (value - 1))), 0.00029d);
        }
        /// <summary>
        /// Calculates the Hyperbolic ArccoTangent of the value, (the angle whose Hyperbolic Cotangent is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <returns>The angle whose Hyperbolic Cotangent is the selected value.</returns>
        public static double Arccoth(double value)
        {
            if (Absolute(value) <= 1) { return NaN; }
            return Accurate(0.5 * Ln((value + 1) / (value - 1)), 0.00029d);
        }
        /// <summary>
        /// Calculates the Hyperbolic Arcsecant of the value, (the angle whose Hyperbolic Secant is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <returns>The angle whose Hyperbolic Secant is the selected value.</returns>
        public static double Arcsech(double value)
        => value == 0 ? NaN : Arccosh(1 / value);
        /// <summary>
        /// Calculates the Hyperbolic Arcsecant of the value, (the angles whose Hyperbolic Secant is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <param name="θ1">The first angle whose Hyperbolic Secant is the value, (measured in Degrees).</param>
        /// <param name="θ2">The second angle whose Hyperbolic Secant is the value, (measured in Degrees).</param>
        /// <returns>The angle whose Hyperbolic Secant is the selected value.</returns>
        public static double Arcsech(double value, out double θ1, out double θ2)
        {
            θ1 = Arcsech(value);
            θ2 = -θ1;
            return θ1;
        }
        /// <summary>
        /// Calculates the Hyperbolic Arccosecant of the value, (the angle whose Hyperbolic Cosecant is the value).
        /// </summary>
        /// <param name="value">The selected value to get its angle, (measured in Degrees).</param>
        /// <returns>The angle whose Hyperbolic Cosecant is the selected value.</returns>
        public static double Arccsch(double value)
        => value == 0 ? NaN : Arcsinh(1 / value);
        #endregion

        #region #Complex
        /// <summary>
        /// Calculates the Sine of the angle.
        /// </summary>
        /// <param name="θ">The selected Complex Angle, (measured in Degrees).</param>
        /// <returns>The Sine value of the angle.</returns>
        public static Complex Sin(Complex θ)
        {
            // Sin(a + bi) = Sin(a)Cos(bi) + Cos(a)Sin(bi)
            Complex c1 = Sin(θ.RealPart) * Cos(θ.ImaginaryPart),
                    c2 = Cos(θ.RealPart) * Sin(θ.ImaginaryPart);
            return c1 + c2;
        }
        /// <summary>
        /// Calculates the Cosine of the angle.
        /// </summary>
        /// <param name="θ">The selected Complex Angle, (measured in Degrees).</param>
        /// <returns>The Cosine value of the angle.</returns>
        public static Complex Cos(Complex θ)
        {
            // Cos(a + bi) = Cos(a)Cos(bi) - Sin(a)Sin(bi)
            Complex c1 = Cos(θ.RealPart) * Cos(θ.ImaginaryPart),
                    c2 = Sin(θ.RealPart) * Sin(θ.ImaginaryPart);
            return c1 - c2;
        }
        /// <summary>
        /// Calculates the Tangent of the angle.
        /// </summary>
        /// <param name="θ">The selected Complex Angle, (measured in Degrees).</param>
        /// <returns>The Tangent value of the angle.</returns>
        public static Complex Tan(Complex θ)
        => Sin(θ) / Cos(θ);
        /// <summary>
        /// Calculates the Cotangent of the angle.
        /// </summary>
        /// <param name="θ">The selected Complex Angle, (measured in Degrees).</param>
        /// <returns>The Cotangent value of the angle.</returns>
        public static Complex Cot(Complex θ)
        => Cos(θ) / Sin(θ);
        /// <summary>
        /// Calculates the Secant of the angle.
        /// </summary>
        /// <param name="θ">The selected Complex Angle, (measured in Degrees).</param>
        /// <returns>The Secant value of the angle.</returns>
        public static Complex Sec(Complex θ)
        => 1 / Cos(θ);
        /// <summary>
        /// Calculates the Cosecant of the angle.
        /// </summary>
        /// <param name="θ">The selected Complex Angle, (measured in Degrees).</param>
        /// <returns>The Cosecant value of the angle.</returns>
        public static Complex Csc(Complex θ)
        => 1 / Sin(θ);

        /// <summary>
        /// Calculates the Hyperbolic Sine of the angle.
        /// </summary>
        /// <param name="θ">The selected Complex Angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Sine value of the angle.</returns>
        public static Complex Sinh(Complex θ)
        {
            // Sinh(a + bi) = Sinh(a)Cosh(bi) + Cosh(a)Sinh(bi)
            Complex c1 = Sinh(θ.RealPart) * Cosh(θ.ImaginaryPart),
                    c2 = Cosh(θ.RealPart) * Sinh(θ.ImaginaryPart);
            return c1 + c2;
        }
        /// <summary>
        /// Calculates the Hyperbolic Cosine of the angle.
        /// </summary>
        /// <param name="θ">The selected Complex Angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Cosine value of the angle.</returns>
        public static Complex Cosh(Complex θ)
        {
            // Cosh(a + bi) = Cosh(a)Cosh(bi) + Sinh(a)Sinh(bi)
            Complex c1 = Cosh(θ.RealPart) * Cosh(θ.ImaginaryPart),
                    c2 = Sinh(θ.RealPart) * Sinh(θ.ImaginaryPart);
            return c1 + c2;
        }
        /// <summary>
        /// Calculates the Hyperbolic Tangent of the angle.
        /// </summary>
        /// <param name="θ">The selected Complex Angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Tangent value of the angle.</returns>
        public static Complex Tanh(Complex θ)
        => Sinh(θ) / Cosh(θ);
        /// <summary>
        /// Calculates the Hyperbolic Cotangent of the angle.
        /// </summary>
        /// <param name="θ">The selected Complex Angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Cotangent value of the angle.</returns>
        public static Complex Coth(Complex θ)
        => Cosh(θ) / Sinh(θ);
        /// <summary>
        /// Calculates the Hyperbolic Secant of the angle.
        /// </summary>
        /// <param name="θ">The selected Complex Angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Secant value of the angle.</returns>
        public static Complex Sech(Complex θ)
        => 1 / Cosh(θ);
        /// <summary>
        /// Calculates the Hyperbolic Cosecant of the angle.
        /// </summary>
        /// <param name="θ">The selected Complex Angle, (measured in Degrees).</param>
        /// <returns>The Hyperbolic Cosecant value of the angle.</returns>
        public static Complex Csch(Complex θ)
        => 1 / Sinh(θ);
        #endregion

        #endregion

        #region #Conversions

        #region #Agnles

        /// <summary>
        /// Converts a Degree into Radians.
        /// </summary>
        /// <param name="value">The Degree Value.</param>
        /// <returns>A Radian Value that represents the Degree in Radians.</returns>
        public static double ToRadian(double value)
        => value * (double)Pi / 180.0d;
        /// <summary>
        /// Converts a Radian Value into Degrees.
        /// </summary>
        /// <param name="value">The Radian Value.</param>
        /// <returns>A Degree that represents the Radian Value in Degrees.</returns>
        public static double ToDegree(double value)
        => value / (double)Pi * 180.0d;
        /// <summary>
        /// Converts a Degree into Radians.
        /// </summary>
        /// <param name="value">The Degree Value.</param>
        /// <returns>A Radian Value that represents the Degree in Radians.</returns>
        public static Imaginary ToRadian(Imaginary value)
        => value * (double)Pi / 180.0d;
        /// <summary>
        /// Converts a Radian Value into Degrees.
        /// </summary>
        /// <param name="value">The Radian Value.</param>
        /// <returns>A Degree that represents the Radian Value in Degrees.</returns>
        public static Imaginary ToDegree(Imaginary value)
        => value / (double)Pi * 180.0d;

        #endregion

        #region #Numeric Systems
        /// <summary>
        /// Converts a Number (in any Numeric System) into Binary.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A Binary Number that represents the selected number.</returns>
        public static Binary ToBinary(NumericSystem number)
        => number.ToBinary();
        /// <summary>
        /// Converts a Number (in any Numeric System) into Octal.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>An Octal Number that represents the selected number.</returns>
        public static Octal ToOctal(NumericSystem number)
        => number.ToOctal();
        /// <summary>
        /// Converts a Number (in any Numeric System) into Decimal.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A Decimal Number that represents the selected number.</returns>
        public static Decimal10 ToDecimal(NumericSystem number)
        => number.ToDecimal();
        /// <summary>
        /// Converts a Number (in any Numeric System) into Hexadecimal.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A Hexadecimal Number that represents the selected number.</returns>
        public static Hexadecimal ToHexadecimal(NumericSystem number)
        => number.ToHexadecimal();
        /// <summary>
        /// Converts a Number (in any Numeric System) into Sixty-Four-Base.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A Sixty-Four-Base Number that represents the selected number.</returns>
        public static SixtyFourBase ToSixtyFourBase(NumericSystem number)
        => number.ToSixtyFourBase();
        /// <summary>
        /// Converts a Number (in any Numeric System) into Binary-Coded-Decimal.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A Binary-Coded-Decimal Number that represents the selected number.</returns>
        public static BinaryCodedDecimal ToBinaryCodedDecimal(NumericSystem number)
        => number.ToBinaryCodedDecimal();
        /// <summary>
        /// Converts a Number (in any Numeric System) into Binary-Coded-Decimal.
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <returns>A Binary-Coded-Decimal Number that represents the selected number.</returns>
        public static BCD ToBCD(NumericSystem number)
        => number.ToBCD();
        /// <summary>
        /// Converts a Number's base (in any Numeric System).
        /// </summary>
        /// <param name="number">The selected number.</param>
        /// <param name="Base">The selected base.</param>
        /// <returns>The same Number but in another Numeric System with another base.</returns>
        public static NumericSystem ToBase(NumericSystem number, int Base)
        => number.ToBase(Base);

        #endregion

        #region #Colours

        /// <summary>
        /// Converts a CMYK Colour into an RGB Colour.
        /// </summary>
        /// <param name="cmyk">The selected CMYK Colour.</param>
        /// <returns>An RGB Colour that represents the selected CMYK Colour.</returns>
        public static RGB ToRGB(CMYK cmyk)
        => cmyk.ToRGB();
        /// <summary>
        /// Converts an RGB Colour into a CMYK Colour.
        /// </summary>
        /// <param name="rgb">The selected RGB Colour.</param>
        /// <returns>A CMYK Colour that represents the selected RGB Colour.</returns>
        public static CMYK ToCMYK(RGB rgb)
        => rgb.ToCMYK();
        /// <summary>
        /// Converts a Hexadecimal Value into an RGB Colour.
        /// </summary>
        /// <param name="hex">The selected Hexadecimal Value.</param>
        /// <returns>An RGB Colour that represents the selected Hexadecimal Value.</returns>
        public static RGB ToRGB(Hexadecimal hex)
        => new RGB(hex);
        /// <summary>
        /// Converts a Hexadecimal Value into a CMYK Colour.
        /// </summary>
        /// <param name="hex">The selected Hexadecimal Value.</param>
        /// <returns>A CMYK Colour that represents the selected Hexadecimal Value.</returns>
        public static CMYK ToCMYK(Hexadecimal hex)
        => new CMYK(hex);
        /// <summary>
        /// Converts a Hashed-Hexadecimal-String Value into an RGB Colour.
        /// </summary>
        /// <param name="value">The selected Hashed-Hexadecimal-String Value.</param>
        /// <returns>An RGB Colour that represents the selected Hashed-Hexadecimal-String Value.</returns>
        public static RGB ToRGB(string value)
        => new RGB(value);
        /// <summary>
        /// Converts a Hashed-Hexadecimal-String Value into a CMYK Colour.
        /// </summary>
        /// <param name="value">The selected Hashed-Hexadecimal-String Value.</param>
        /// <returns>A CMYK Colour that represents the selected Hashed-Hexadecimal-String Value.</returns>
        public static CMYK ToCMYK(string value)
        => new CMYK(value);

        #endregion

        #region #Geometry

        /// <summary>
        /// Converts a Complex Number into a two-dimensional Vector.
        /// </summary>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A two-dimensional Vector with the values of the selected Complex Number.</returns>
        public static Vector2D ToVector(Complex complex)
        => new Vector2D(complex);
        /// <summary>
        /// Converts a two-dimensional Vector into a Complex Number.
        /// </summary>
        /// <param name="number">The selected two-dimensional Vector.</param>
        /// <returns>A Complex Number with the values of the selected two-dimensional Vector.</returns>
        public static Complex ToComplex(Vector2D vector)
        => vector.ToComplex();

        #endregion

        #region #Matrix

        /// <summary>
        /// Converts a Real Number into a two-by-two Matrix.
        /// </summary>
        /// <param name="number">The selected Real Number.</param>
        /// <returns>A two-by-two Matrix that represents the selected Real Number.</returns>
        public static Matrix<double> ToMatrix(double number)
        => number * Matrix2<double>.IdenticalMatrix;
        /// <summary>
        /// Converts a two-dimensional Vector into an only-one-column Matrix.
        /// </summary>
        /// <param name="vector">The selected two-dimensional Vector</param>
        /// <returns>An only-one-column Matrix that represents the selected two-dimensional Vector.</returns>
        public static Matrix<double> ToMatrix(Vector2D vector)
        => vector.ToMatrix();
        /// <summary>
        /// Converts a three-dimensional Vector into an only-one-column Matrix.
        /// </summary>
        /// <param name="vector">The selected three-dimensional Vector.</param>
        /// <returns>An only-one-column Matrix that represents the selected three-dimensional Vector.</returns>
        public static Matrix<double> ToMatrix(Vector3D vector)
        => vector.ToMatrix();
        /// <summary>
        /// Converts a Lateral Number into a two-by-two Matrix.
        /// </summary>
        /// <param name="lateral">The selected Lateral Number.</param>
        /// <returns>A two-by-two Matrix that represents the selected Lateral Number.</returns>
        public static Matrix<Complex> ToMatrix(Lateral lateral)
        => lateral.ToMatrix2();
        /// <summary>
        /// Converts a Imainary Number into a two-by-two Matrix.
        /// </summary>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A two-by-two Matrix that represents the selected Imaginary Number.</returns>
        public static Matrix<double> ToMatrix(Imaginary inumber)
        => inumber.ToMatrix();
        /// <summary>
        /// Converts a Complex Number into a two-by-two Matrix.
        /// </summary>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A two-by-two Matrix that represents the selected Complex Number.</returns>
        public static Matrix<double> ToMatrix(Complex complex)
        => complex.ToMatrix();
        /// <summary>
        /// Converts a Quaternion Number into a two-by-two Matrix.
        /// </summary>
        /// <param name="quaternion">The selected Quaternion Number.</param>
        /// <returns>A two-by-two Matrix that represents the selected Quaternion Number.</returns>
        public static Matrix<Complex> ToMatrix(Quaternion quaternion)
        => quaternion.ToMatrix2();

        #endregion

        #region #Matrix2

        /// <summary>
        /// Converts a Real Number into a two-by-two Matrix.
        /// </summary>
        /// <param name="number">The selected Real Number.</param>
        /// <returns>A two-by-two Matrix that represents the selected Real Number.</returns>
        public static Matrix2<double> ToMatrix2(double number)
        => number * Matrix2<double>.IdenticalMatrix;
        /// <summary>
        /// Converts a Lateral Number into a two-by-two Matrix.
        /// </summary>
        /// <param name="lateral">The selected Lateral Number.</param>
        /// <returns>A two-by-two Matrix that represents the selected Lateral Number.</returns>
        public static Matrix2<Complex> ToMatrix2(Lateral lateral)
        => lateral.ToMatrix2();
        /// <summary>
        /// Converts a Imainary Number into a two-by-two Matrix.
        /// </summary>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A two-by-two Matrix that represents the selected Imaginary Number.</returns>
        public static Matrix2<double> ToMatrix2(Imaginary inumber)
        => inumber.ToMatrix();
        /// <summary>
        /// Converts a Complex Number into a two-by-two Matrix.
        /// </summary>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A two-by-two Matrix that represents the selected Complex Number.</returns>
        public static Matrix2<double> ToMatrix2(Complex complex)
        => complex.ToMatrix();
        /// <summary>
        /// Converts a Quaternion Number into a two-by-two Matrix.
        /// </summary>
        /// <param name="quaternion">The selected Quaternion Number.</param>
        /// <returns>A two-by-two Matrix that represents the selected Quaternion Number.</returns>
        public static Matrix2<Complex> ToMatrix2(Quaternion quaternion)
        => quaternion.ToMatrix2();

        #endregion

        #region #Matrix3

        /// <summary>
        /// Converts a Real Number into a three-by-three Matrix.
        /// </summary>
        /// <param name="number">The selected Real Number.</param>
        /// <returns>A three-by-three Matrix that represents the selected Real Number.</returns>
        public static Matrix3<double> ToMatrix3(double number)
        => number * Matrix3<double>.IdenticalMatrix;
        /// <summary>
        /// Converts a Lateral Number into a three-by-three Matrix.
        /// </summary>
        /// <param name="lateral">The selected Lateral Number.</param>
        /// <returns>A three-by-three Matrix that represents the selected Lateral Number.</returns>
        public static Matrix3<double> ToMatrix3(Lateral lateral)
        => lateral.ToMatrix3();
        /// <summary>
        /// Converts a Imainary Number into a three-by-three Matrix.
        /// </summary>
        /// <param name="inumber">The selected Imaginary Number.</param>
        /// <returns>A three-by-three Matrix that represents the selected Imaginary Number.</returns>
        public static Matrix3<double> ToMatrix3(Imaginary inumber)
        => new Matrix3<double>().Fill((inumber.ToMatrix() + new Matrix3<double>()).ToList());
        /// <summary>
        /// Converts a Complex Number into a three-by-three Matrix.
        /// </summary>
        /// <param name="complex">The selected Complex Number.</param>
        /// <returns>A three-by-three Matrix that represents the selected Complex Number.</returns>
        public static Matrix3<double> ToMatrix3(Complex complex)
        => new Matrix3<double>().Fill((complex.ToMatrix() + new Matrix3<double>()).ToList());
        /// <summary>
        /// Converts a Quaternion Number into a three-by-three Matrix.
        /// </summary>
        /// <param name="quaternion">The selected Quaternion Number.</param>
        /// <returns>A three-by-three Matrix that represents the selected Quaternion Number.</returns>
        public static Matrix3<double> ToMatrix3(Quaternion quaternion)
        => quaternion.ToMatrix3();

        #endregion

        /// <summary>
        /// Converts a specified type of value into a generic type.
        /// </summary>
        /// <param name="value">The selected value.</param>
        /// <returns>A generic value represents the selected value.</returns>
        public static Type Value<Type>(double value) where Type : IFormattable
        => typeof(Type) == typeof(Complex) ? (dynamic)(Complex)value
         : typeof(Type) == typeof(Quaternion) ? (dynamic)(Quaternion)value
         : typeof(Type) == typeof(Lateral) ? (dynamic)new Lateral(Lateral.LateralCharacter.i, value)
         : typeof(Type) == typeof(Imaginary) ? (dynamic)new Imaginary(value)
         : typeof(Type) == typeof(NumericSystem) ? (dynamic)(new NumericSystem(2, value).RealValue)
         : typeof(Type) == typeof(Binary) ? (dynamic)(new Binary(value).RealValue)
         : typeof(Type) == typeof(Octal) ? (dynamic)(new Octal(value).RealValue)
         : typeof(Type) == typeof(Decimal10) ? (dynamic)(new Decimal10(value).RealValue)
         : typeof(Type) == typeof(Hexadecimal) ? (dynamic)(new Hexadecimal(value).RealValue)
         : typeof(Type) == typeof(SixtyFourBase) ? (dynamic)(new SixtyFourBase(value).RealValue)
         : typeof(Type) == typeof(BinaryCodedDecimal) || typeof(Type) == typeof(BCD) ? (dynamic)(new BinaryCodedDecimal(value)).RealValue
         : typeof(Type) == typeof(int) || typeof(Type) == typeof(long) ? (dynamic)Round(value)
         : (dynamic)value;

        #endregion

        #region #Geometry
        /// <summary>
        /// Normalizes a Vector into a length of One.
        /// </summary>
        /// <param name="vector">The selected Vector.</param>
        /// <returns>A new Vector which is the same as old one, but with a length of One.</returns>
        public static Vector2D Normalize(Vector2D vector)
        => vector.Normalized;
        /// <summary>
        /// Normalizes a Vector into a length of One.
        /// </summary>
        /// <param name="vector">The selected Vector.</param>
        public static void Normalize(ref Vector2D vector)
        => vector = vector.Normalized;
        /// <summary>
        /// Normalizes a Vector into a length of One.
        /// </summary>
        /// <param name="vector">The selected Vector.</param>
        /// <returns>A new Vector which is the same as old one, but with a length of One.</returns>
        public static Vector3D Normalize(Vector3D vector)
        => vector.Normalized;
        /// <summary>
        /// Normalizes a Vector into a length of One.
        /// </summary>
        /// <param name="vector">The selected Vector.</param>
        public static void Normalize(ref Vector3D vector)
        => vector = vector.Normalized;
        /// <summary>
        /// Finds the angle that's formed by two Vectors, (measured in Degrees).
        /// </summary>
        /// <param name="vector1">The first selected Vector.</param>
        /// <param name="vector2">The second selected Vector.</param>
        /// <returns>The angle that's formed by the two selected Vectors.</returns>
        public static double GetFormedAngle(Vector2D vector1, Vector2D vector2)
        => vector1.AngleWith(vector2);
        /// <summary>
        /// Finds the angle that's formed by two Vectors, (measured in Degrees).
        /// </summary>
        /// <param name="vector1">The first selected Vector.</param>
        /// <param name="vector2">The second selected Vector.</param>
        /// <returns>The angle that's formed by the two selected Vectors.</returns>
        public static double GetFormedAngle(Vector3D vector1, Vector3D vector2)
        => vector1.AngleWith(vector2);
        /// <summary>
        /// Finds the intersection Point of two Vectors.
        /// </summary>
        /// <param name="vector1">The first selected Vector.</param>
        /// <param name="vector2">The second selected Vector.</param>
        /// <returns>The Point that represents the Intersection of the two selected Vectors.</returns>
        public static Point IntersectsAt(Vector2D vector1, Vector2D vector2)
        => vector1.InterscetsAt(vector2);
        /// <summary>
        /// Gets the distance that's between two Points.
        /// </summary>
        /// <param name="point1">The first selected Point.</param>
        /// <param name="point2">The second selected Point.</param>
        /// <returns>The distance between the two selected Points.</returns>
        public static double GetDistance(Point point1, Point point2)
        => point1.GetDistance(point2);
        /// <summary>
        /// Gets the -shortest- distance that's between a Point and a two-dimensional Vector.
        /// </summary>
        /// <param name="point">The selected Point.</param>
        /// <param name="point2">The selected two-dimensional Vector.</param>
        /// <returns>The distance between the selected Point and the selected two-dimensional Vector.</returns>
        public static double GetDistance(Point point, Vector2D vector)
        => point.GetDistance(vector);
        /// <summary>
        /// Finds the location state of a Point according to a Vector.
        /// </summary>
        /// <param name="point">The selected Point.</param>
        /// <param name="vector">The selected Vector.</param>
        /// <returns>The state of the selected Point to the selected Vector.</returns>
        public static Point.PointState PointState(Point point, Vector2D vector)
        => vector.PointLocation(point);
        /// <summary>
        /// Calculates the hypotenuse in a triangle, giving two lengths and the angle between them, according to Pythagoras' Formula (a^2 + b^2 - 2abCos(θ) = c^2).
        /// </summary>
        /// <param name="length1">The first length.</param>
        /// <param name="length2">The second length.</param>
        /// <param name="θ">The angle that's between the two selected lengths, (measured in Degrees).</param>
        /// <returns>The third length that completes the triangle.</returns>
        public static double GetTriangleHypotenuse(double length1, double length2, double θ)
        => SquareRoot(Square(length1) + Square(length2) - 2 * length1 * length2 * Cos(θ));
        /// <summary>
        /// Calculates the hypotenuse for amount of perpendicular lengths, according to Pythagoras' Formula, (a^2 + b^2 = c^2).
        /// </summary>
        /// <param name="lengths">The selected lengths.</param>
        /// <returns>The value of the hypotenuse for the selected lengths.</returns>
        public static double GetHypotenuse(params double[] lengths)
        {
            double sum = 0.0d;
            foreach (var item in lengths)
            { sum += Square(item); }
            return SquareRoot(sum);
        }
        /// <summary>
        /// Translates a number into another linearly with a specified percentage.
        /// </summary>
        /// <typeparam name="Type">The type of the selected numbers.</typeparam>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A number that represents the selected one translated into the other linearly in the selected percentage.</returns>
        public static Type LinearInterpolation<Type>(Type start, Type end, double percentage) where Type : IFormattable
        => Value<Type>(1 - percentage) * (dynamic)start + Value<Type>(percentage) * (dynamic)end;
        /// <summary>
        /// Translates a number into another linearly with a specified percentage.
        /// </summary>
        /// <typeparam name="Type">The type of the selected numbers.</typeparam>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        public static Type LinearInterpolation<Type>(ref Type start, Type end, double percentage) where Type : IFormattable
        => start = LinearInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a two-dimensional Vector into another linearly with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A two-dimensional Vector that represents the selected one translated into the other linearly in the selected percentage.</returns>
        public static Vector2D LinearInterpolation(Vector2D start, Vector2D end, double percentage)
        => (Vector2D)LinearInterpolation((Vector3D)start, end, percentage);
        /// <summary>
        /// Translates a two-dimensional Vector into another linearly with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on, (number between Zero and One).</param>
        public static void LinearInterpolation(ref Vector2D start, Vector2D end, double percentage)
        => start = LinearInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a three-dimensional Vector into another linearly with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A three-dimensional Vector that represents the selected one translated into the other linearly in the selected percentage.</returns>
        public static Vector3D LinearInterpolation(Vector3D start, Vector3D end, double percentage)
        => (1 - percentage) * start + percentage * end;
        /// <summary>
        /// Translates a three-dimensional Vector into another linearly with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on, (number between Zero and One).</param>
        public static void LinearInterpolation(ref Vector3D start, Vector3D end, double percentage)
        => start = LinearInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a number into another linearly with a specified percentage.
        /// </summary>
        /// <typeparam name="Type">The type of the selected numbers.</typeparam>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A number that represents the selected one translated into the other linearly in the selected percentage.</returns>
        public static Type Lerp<Type>(Type start, Type end, double percentage) where Type : IFormattable
        => LinearInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a number into another linearly with a specified percentage.
        /// </summary>
        /// <typeparam name="Type">The type of the selected numbers.</typeparam>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        public static Type Lerp<Type>(ref Type start, Type end, double percentage) where Type : IFormattable
        => LinearInterpolation(ref start, end, percentage);
        /// <summary>
        /// Translates a two-dimensional Vector into another linearly with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A two-dimensional Vector that represents the selected one translated into the other linearly in the selected percentage.</returns>
        public static Vector2D Lerp(Vector2D start, Vector2D end, double percentage)
        => LinearInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a two-dimensional Vector into another linearly with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on, (number between Zero and One).</param>
        public static void Lerp(ref Vector2D start, Vector2D end, double percentage)
        => LinearInterpolation(ref start, end, percentage);
        /// <summary>
        /// Translates a three-dimensional Vector into another linearly with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A three-dimensional Vector that represents the selected one translated into the other linearly in the selected percentage.</returns>
        public static Vector3D Lerp(Vector3D start, Vector3D end, double percentage)
        => LinearInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a three-dimensional Vector into another linearly with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on, (number between Zero and One).</param>
        public static void Lerp(ref Vector3D start, Vector3D end, double percentage)
        => LinearInterpolation(ref start, end, percentage);
        /// <summary>
        /// Translates a two-dimensional Vector into another spherically with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A two-dimensional Vector that represents the selected one translated into the other spherically in the selected percentage.</returns>
        public static Vector2D SphericalInterpolation(Vector2D start, Vector2D end, double percentage)
        => (Vector2D)SphericalInterpolation((Vector3D)start, end, percentage);
        /// <summary>
        /// Translates a two-dimensional Vector into another spherically with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        public static void SphericalInterpolation(ref Vector2D start, Vector2D end, double percentage)
        => start = SphericalInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a three-dimensional Vector into another spherically with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A three-dimensional Vector that represents the selected one translated into the other spherically in the selected percentage.</returns>
        public static Vector3D SphericalInterpolation(Vector3D start, Vector3D end, double percentage)
        {
            double θ = GetFormedAngle(end, start);
            return Sin((1 - percentage) * θ) / Sin(θ) * start
                 + Sin(percentage * θ) / Sin(θ) * end;
        }
        /// <summary>
        /// Translates a three-dimensional Vector into another spherically with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        public static void SphericalInterpolation(ref Vector3D start, Vector3D end, double percentage)
        => start = SphericalInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a two-dimensional Vector into another spherically with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A two-dimensional Vector that represents the selected one translated into the other spherically in the selected percentage.</returns>
        public static Vector2D Slerp(Vector2D start, Vector2D end, double percentage)
        => SphericalInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a two-dimensional Vector into another spherically with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        public static void Slerp(ref Vector2D start, Vector2D end, double percentage)
        => SphericalInterpolation(ref start, end, percentage);
        /// <summary>
        /// Translates a three-dimensional Vector into another spherically with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A three-dimensional Vector that represents the selected one translated into the other spherically in the selected percentage.</returns>
        public static Vector3D Slerp(Vector3D start, Vector3D end, double percentage)
        => SphericalInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a three-dimensional Vector into another spherically with a specified percentage.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        public static void Slerp(ref Vector3D start, Vector3D end, double percentage)
        => SphericalInterpolation(ref start, end, percentage);
        /// <summary>
        /// Translates a two-dimensional Vector into another linearly with a specified percentage and returns the normalized version of the translation.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A normalized two-dimensional Vector that represents the selected one translated into the other linearly in the selected percentage.</returns>
        public static Vector2D NormalizedInterpolation(Vector2D start, Vector2D end, double percentage)
        => LinearInterpolation(start, end, percentage).Normalized;
        /// <summary>
        /// Translates a two-dimensional Vector into another linearly with a specified percentage and returns the normalized version of the translation.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        public static void NormalizedInterpolation(ref Vector2D start, Vector2D end, double percentage)
        => start = NormalizedInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a three-dimensional Vector into another linearly with a specified percentage and returns the normalized version of the translation.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A normalized three-dimensional Vector that represents the selected one translated into the other linearly in the selected percentage.</returns>
        public static Vector3D NormalizedInterpolation(Vector3D start, Vector3D end, double percentage)
        => LinearInterpolation(start, end, percentage).Normalized;
        /// <summary>
        /// Translates a three-dimensional Vector into another linearly with a specified percentage and returns the normalized version of the translation.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        public static void NormalizedInterpolation(ref Vector3D start, Vector3D end, double percentage)
        => start = NormalizedInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a two-dimensional Vector into another linearly with a specified percentage and returns the normalized version of the translation.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A normalized two-dimensional Vector that represents the selected one translated into the other linearly in the selected percentage.</returns>
        public static Vector2D Nlerp(Vector2D start, Vector2D end, double percentage)
        => NormalizedInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a two-dimensional Vector into another linearly with a specified percentage and returns the normalized version of the translation.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        public static void Nlerp(ref Vector2D start, Vector2D end, double percentage)
        => NormalizedInterpolation(ref start, end, percentage);
        /// <summary>
        /// Translates a three-dimensional Vector into another linearly with a specified percentage and returns the normalized version of the translation.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        /// <returns>A normalized three-dimensional Vector that represents the selected one translated into the other linearly in the selected percentage.</returns>
        public static Vector3D Nlerp(Vector3D start, Vector3D end, double percentage)
        => NormalizedInterpolation(start, end, percentage);
        /// <summary>
        /// Translates a three-dimensional Vector into another linearly with a specified percentage and returns the normalized version of the translation.
        /// </summary>
        /// <param name="start">The selected start of the translation.</param>
        /// <param name="end">The selected end of the translation.</param>
        /// <param name="percentage">The selected percentage the translation is based on.</param>
        public static void Nlerp(ref Vector3D start, Vector3D end, double percentage)
        => NormalizedInterpolation(ref start, end, percentage);
        #endregion
    }

    #region #Variables

    #region #Numeric Systems

    /// <summary>
    /// A numeric system, which only contains digits from 0 to its base - 1.
    /// </summary>
    public class NumericSystem : IFormattable, IComparable
    {
        /// <summary>
        /// The value of the Numeric Number.
        /// </summary>
        protected string value = "0";
        /// <summary>
        /// The real Decimal value of the Numeric Number.
        /// </summary>
        protected double realValue = 0d;
        /// <summary>
        /// The base number of the Numeric System.
        /// </summary>
        protected int Base = 2;
        /// <summary>
        /// Indicates wether or not the Numeric Number contains an inappropriate value.
        /// </summary>
        protected bool nulled = false;
        /// <summary>
        /// Gives the real Decimal value of the Numeric Number.
        /// </summary>
        /// <returns>The real Decimal value that represents the Numeric Number.</returns>
        public double RealValue { get { return realValue; } }
        /// <summary>
        /// Converts the Numberical Number from its Base into another Base.
        /// </summary>
        /// <param name="Base">The selected Base.</param>
        /// <returns>A new Numeric Number that represents the old one in the selected Base.</returns>
        public NumericSystem ToBase(int Base) => new NumericSystem(Base, realValue);
        /// <summary>
        /// Converts the Numberical Number into a Binary Number.
        /// </summary>
        /// <returns>A new Numeric Number that represents the old one in the Binary System.</returns>
        public Binary ToBinary() => new Binary(realValue);
        /// <summary>
        /// Converts the Numberical Number into an Octal Number.
        /// </summary>
        /// <returns>A new Numeric Number that represents the old one in the Octal System.</returns>
        public Octal ToOctal() => new Octal(realValue);
        /// <summary>
        /// Converts the Numberical Number into a Decimal Number.
        /// </summary>
        /// <returns>A new Numeric Number that represents the old one in the Decimal System.</returns>
        public Decimal10 ToDecimal() => new Decimal10(realValue);
        /// <summary>
        /// Converts the Numberical Number into a Hexadecimal Number.
        /// </summary>
        /// <returns>A new Numeric Number that represents the old one in the Hexadecimal System.</returns>
        public Hexadecimal ToHexadecimal() => new Hexadecimal(realValue);
        /// <summary>
        /// Converts the Numberical Number into a Sixty-Four-Base Number.
        /// </summary>
        /// <returns>A new Numeric Number that represents the old one in the Sixty-Four-Base System.</returns>
        public SixtyFourBase ToSixtyFourBase() => new SixtyFourBase(realValue);
        /// <summary>
        /// Converts the Numberical Number into a Binary-Coded-Decimal Number.
        /// </summary>
        /// <returns>A new Numeric Number that represents the old one in the Binary-Coded-Decimal System.</returns>
        public BinaryCodedDecimal ToBinaryCodedDecimal() => new BinaryCodedDecimal(realValue);
        /// <summary>
        /// Converts the Numberical Number into a Binary-Coded-Decimal Number.
        /// </summary>
        /// <returns>A new Numeric Number that represents the old one in the Binary-Coded-Decimal System.</returns>
        public BCD ToBCD() => new BCD(realValue);
        /// <summary>
        /// All the availabe digits in the Numeric System, (all digits in one string format).
        /// </summary>
        private static string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz?!";
        /// <summary>
        /// All the availabe digits in the Numeric System.
        /// </summary>
        public static char[] Digits { get { return digits.ToCharArray(); } }

        /// <summary>
        /// Builds up a new Numeric System.
        /// </summary>
        protected NumericSystem() : this(2, 0) { }
        /// <summary>
        /// Builds up a new Numeric System with a certain base.
        /// </summary>
        /// <param name="_base">The selected base of the Numeric System.</param>
        public NumericSystem(int _base)
        {
            value = "0";
            realValue = 0;
            Base = _base;
        }
        /// <summary>
        /// Builds up a new Numeric System with a certain base and value.
        /// </summary>
        /// <param name="_base">The selected base of the Numeric System.</param>
        /// <param name="value">The selected real value of the Numeric Number.</param>
        public NumericSystem(int _base, double value)
        {
            realValue = value;
            Base = _base;
            this.value = "";
            Mathematics.Clamp(ref Base, 2, Digits.Length);
            if (value == 0)
            {
                this.value = "0";
                return;
            }
            bool negative = Mathematics.IsNegative(value);
            Mathematics.Absolute(ref value);
            long afterDot = Mathematics.Floor(value);
            double beforeDot = Mathematics.GetFraction(value);
            if (afterDot == 0)
            { this.value = "0"; }
            while (afterDot > 0)
            {
                this.value = this.value.Insert(0, Digits[afterDot % _base].ToString());
                afterDot /= _base;
            }
            if (negative)
            { this.value = this.value.Insert(0, "-"); }
            if (beforeDot == 0) { return; }
            string previousValue = this.value;
            this.value += ".";
            List<double> values = new List<double>() { Mathematics.GetFraction(beforeDot) };
            for (int i = 0; beforeDot != 0.0d; i++)
            {
                bool valid = false;
                int fraction = (int)Mathematics.Floor(beforeDot * _base);
                if (fraction != 0)
                { valid = true; }
                this.value += Digits[fraction];
                beforeDot = Mathematics.GetFraction(beforeDot * _base);
                bool found = false;
                foreach (var item in values)
                {
                    if (i != 0 && item == beforeDot && valid)
                    { found = true; break; }
                }
                if (found || i == 20)
                {
                    if (!valid)
                    { this.value = previousValue; }
                    break;
                }
                values.Add(beforeDot);
            }
        }
        /// <summary>
        /// Builds up a new Numeric System.
        /// </summary>
        /// <param name="_base">The base number of the Numeric System.</param>
        /// <param name="value">The string value that represents the Numeric Number.</param>
        public NumericSystem(int _base, string value)
        {
            Base = _base;
            Mathematics.Clamp(ref Base, 2, Digits.Length);
            int index = 0;
            bool negative = value.StartsWith("-");
            if (negative) { value = value.Remove(0, 1); }
            bool foundComma = false;
            foreach (var item in value)
            {
                if (item == '.')
                {
                    if (!foundComma) { foundComma = true; continue; }
                    else { goto BREAK; }
                }
                if (Digits.ToList().IndexOf(item) < 0 || Digits.ToList().LastIndexOf(item) > _base - 1) { goto BREAK; }
                index++;
            }
            double realValue = 0.0d;
            this.value = negative ? "-" : "";
            string afterDot = value.Contains(".") ? value.Split('.')[0] : value;
            string beforeDot = value.Contains(".") ? value.Split('.')[1] : "";
            string _afterDot = "", _beforeDot = "";
            while (afterDot.StartsWith(Digits[0].ToString())) { afterDot = afterDot.Remove(0, 1); }
            for (int i = afterDot.Length - 1, power = 0; i >= 0; i--, power++)
            {
                if (i == afterDot.Length - 17) { break; }
                realValue += Digits.ToList().IndexOf(afterDot[i]) * Mathematics.Power(_base, (decimal)power);
                _afterDot += afterDot[power];
            }
            for (int i = 0, power = -1; i < beforeDot.Length; i++, power--)
            {
                if (i == 16) { break; }
                realValue += Digits.ToList().IndexOf(beforeDot[i]) * Mathematics.Power(_base, (decimal)power);
                _beforeDot += beforeDot[i];
            }
            while (_beforeDot.EndsWith(Digits[0].ToString())) { _beforeDot = _beforeDot.Remove(_beforeDot.Length - 1, 1); }
            if (_afterDot.Length == 0) { this.value += "0"; }
            this.value += _afterDot;
            if (_beforeDot.Length > 0) { this.value += "." + _beforeDot; }
            this.realValue = realValue * (negative ? -1 : +1);
            return;
            BREAK:
            this.value = "InappropriateValue{" + index + "}";
            this.realValue = 0;
            nulled = true;
            return;
        }

        #region #Conversions
        public static implicit operator NumericSystem(double value)
        { return new NumericSystem(10, value); }
        #endregion
        #region #Operators With Another Numeric System
        public static NumericSystem operator +(NumericSystem n1, NumericSystem n2)
        => new NumericSystem(n1.Base, n1.realValue + n2.realValue);
        public static NumericSystem operator -(NumericSystem n1, NumericSystem n2)
        => new NumericSystem(n1.Base, n1.realValue - n2.realValue);
        public static NumericSystem operator *(NumericSystem n1, NumericSystem n2)
        => new NumericSystem(n1.Base, n1.realValue * n2.realValue);
        public static NumericSystem operator /(NumericSystem n1, NumericSystem n2)
        => new NumericSystem(n1.Base, n1.realValue / n2.realValue);
        public static bool operator >(NumericSystem n1, NumericSystem n2)
        => n1.realValue > n2.realValue;
        public static bool operator <(NumericSystem n1, NumericSystem n2)
        => n1.realValue < n2.realValue;
        public static bool operator >=(NumericSystem n1, NumericSystem n2)
        => n1.realValue >= n2.realValue;
        public static bool operator <=(NumericSystem n1, NumericSystem n2)
        => n1.realValue <= n2.realValue;
        public static bool operator ==(NumericSystem n1, NumericSystem n2)
        => n1.realValue == n2.realValue;
        public static bool operator !=(NumericSystem n1, NumericSystem n2)
        => n1.realValue != n2.realValue;
        #endregion
        #region #Operators Alone
        public static NumericSystem operator +(NumericSystem n)
        => n;
        public static NumericSystem operator -(NumericSystem n)
        => n * -1;
        public static NumericSystem operator ++(NumericSystem n)
        => n.realValue++;
        public static NumericSystem operator --(NumericSystem n)
        => n.realValue--;
        #endregion

        /// <summary>
        /// Converts the value of the Numeric Number into a string value.
        /// </summary>
        /// <returns>The string value of the Numeric Number.</returns>
        public override string ToString()
        => value;
        /// <summary>
        /// Converts the value of the Numeric Number into a string value.
        /// </summary>
        /// <param name="format">A standard or custom numeric format system.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>A string value that represents the Numeric Number value.</returns>
        public string ToString(string format, IFormatProvider provider)
        => value;
        /// <summary>
        /// Compares this instance to a specified Numeric Number and returns an indecation of their relative values.
        /// </summary>
        /// <param name="value">A Numeric Number to compare.</param>
        /// <returns>A signed number indicating the relative values of this instance and value.Return
        /// Value Description Less than zero This instance is less than value. Zero This
        /// instance is equal to value. Greater than zero This instance is greater than value.-or-
        /// value is null.</returns>
        public int CompareTo(NumericSystem value)
        => realValue.CompareTo(value.realValue);
        /// <summary>
        /// Compares this instance to a specified object and returns an indecation of their relative values.
        /// </summary>
        /// <param name="value">An object to compare, or null.</param>
        /// <returns>A signed number indicating the relative values of this instance and value.Return
        /// Value Description Less than zero This instance is less than value. Zero This
        /// instance is equal to value. Greater than zero This instance is greater than value.-or-
        /// value is null.</returns>
        public int CompareTo(object value)
        {
            if (value is NumericSystem) { return realValue.CompareTo((value as NumericSystem).realValue); }
            throw new ArgumentException("Object must be of type NumericSystem.");
        }
        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// A binary number, which only contains digits from 0 to 1.
    /// </summary>
    public class Binary : NumericSystem
    {
        /// <summary>
        /// Builds up a new Binary Number.
        /// <summary>
        public Binary() : this(0) { }
        /// <summary>
        /// Builds up a new Binary Number with certain value.
        /// <summary>
        /// <param name="value">The selected Real value.</param>
        public Binary(double value)
        {
            NumericSystem numeric = new NumericSystem(2, value);
            realValue = numeric.RealValue;
            this.value = numeric.ToString();
            Base = 2;
        }
        /// <summary>
        /// Builds up a new Binary Number with certain value.
        /// <summary>
        /// <param name="value">The string value that represents the Binary Number's value.</param>
        public Binary(string value)
        {
            NumericSystem numeric = new NumericSystem(2, value);
            realValue = numeric.RealValue;
            this.value = numeric.ToString();
            Base = 2;
        }

        #region #Conversions
        public static implicit operator Binary(double v)
        => new Binary(v);
        #endregion
        #region #Operators With Another Numeric System
        public static Binary operator +(Binary b, NumericSystem n)
        => new Binary(b.realValue + n.RealValue);
        public static Binary operator -(Binary b, NumericSystem n)
        => new Binary(b.realValue - n.RealValue);
        public static Binary operator *(Binary b, NumericSystem n)
        => new Binary(b.realValue * n.RealValue);
        public static Binary operator /(Binary b, NumericSystem n)
        => new Binary(b.realValue / n.RealValue);
        public static bool operator >(Binary b, NumericSystem n)
        => b.realValue > n.RealValue;
        public static bool operator <(Binary b, NumericSystem n)
        => b.realValue < n.RealValue;
        public static bool operator >=(Binary b, NumericSystem n)
        => b.realValue >= n.RealValue;
        public static bool operator <=(Binary b, NumericSystem n)
        => b.realValue <= n.RealValue;
        public static bool operator ==(Binary b, NumericSystem n)
        => b.realValue == n.RealValue;
        public static bool operator !=(Binary b, NumericSystem n)
        => b.realValue != n.RealValue;
        #endregion
        #region #Operators Alone
        public static Binary operator +(Binary b)
        => b;
        public static Binary operator -(Binary b)
        => b * -1;
        public static Binary operator ++(Binary b)
        => b.realValue++;
        public static Binary operator --(Binary b)
        => b.realValue--;
        #endregion

        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// An octal number, which only contains digits from 0 to 7.
    /// </summary>
    public class Octal : NumericSystem
    {
        /// <summary>
        /// Builds up a new Octal Number.
        /// <summary>
        public Octal() : this(0) { }
        /// <summary>
        /// Builds up a new Octal Number with certain value.
        /// <summary>
        /// <param name="value">The selected Real value.</param>
        public Octal(double value)
        {
            NumericSystem numeric = new NumericSystem(8, value);
            realValue = numeric.RealValue;
            this.value = numeric.ToString();
            Base = 8;
        }
        /// <summary>
        /// Builds up a new Octal Number with certain value.
        /// <summary>
        /// <param name="value">The string value that represents the Octal Number's value.</param>
        public Octal(string value)
        {
            NumericSystem numeric = new NumericSystem(8, value);
            realValue = numeric.RealValue;
            this.value = numeric.ToString();
            Base = 8;
        }

        #region #Conversions
        public static implicit operator Octal(double v)
        => new Octal(v);
        #endregion
        #region #Operators With Another Numeric System
        public static Octal operator +(Octal o, NumericSystem n)
        => new Octal(o.realValue + n.RealValue);
        public static Octal operator -(Octal o, NumericSystem n)
        => new Octal(o.realValue - n.RealValue);
        public static Octal operator *(Octal o, NumericSystem n)
        => new Octal(o.realValue * n.RealValue);
        public static Octal operator /(Octal o, NumericSystem n)
        => new Octal(o.realValue / n.RealValue);
        public static bool operator >(Octal o, NumericSystem n)
        => o.realValue > n.RealValue;
        public static bool operator <(Octal o, NumericSystem n)
        => o.realValue < n.RealValue;
        public static bool operator >=(Octal o, NumericSystem n)
        => o.realValue >= n.RealValue;
        public static bool operator <=(Octal o, NumericSystem n)
        => o.realValue <= n.RealValue;
        public static bool operator ==(Octal o, NumericSystem n)
        => o.realValue == n.RealValue;
        public static bool operator !=(Octal o, NumericSystem n)
        => o.realValue != n.RealValue;
        #endregion
        #region #Operators Alone
        public static Octal operator +(Octal o)
        => o;
        public static Octal operator -(Octal o)
        => o * -1;
        public static Octal operator ++(Octal o)
        => o.realValue++;
        public static Octal operator --(Octal o)
        => o.realValue--;
        #endregion

        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// A decimal number, which only contains digits from 0 to 9.
    /// </summary>
    public class Decimal10 : NumericSystem
    {
        /// <summary>
        /// Builds up a new Decimal Number.
        /// <summary>
        public Decimal10() : this(0) { }
        /// <summary>
        /// Builds up a new Decimal Number with certain value.
        /// <summary>
        /// <param name="value">The selected Real value.</param>
        public Decimal10(double value)
        {
            NumericSystem numeric = new NumericSystem(10, value);
            realValue = numeric.RealValue;
            this.value = numeric.ToString();
            Base = 10;
        }
        /// <summary>
        /// Builds up a new Decimal Number with certain value.
        /// <summary>
        /// <param name="value">The string value that represents the Decimal Number's value.</param>
        public Decimal10(string value)
        {
            NumericSystem numeric = new NumericSystem(10, value);
            realValue = numeric.RealValue;
            this.value = numeric.ToString();
            Base = 10;
        }

        #region #Conversions
        public static implicit operator Decimal10(double v)
        => new Decimal10(v);
        #endregion
        #region #Operators With Another Numeric System
        public static Decimal10 operator +(Decimal10 d, NumericSystem n)
        => new Decimal10(d.realValue + n.RealValue);
        public static Decimal10 operator -(Decimal10 d, NumericSystem n)
        => new Decimal10(d.realValue - n.RealValue);
        public static Decimal10 operator *(Decimal10 d, NumericSystem n)
        => new Decimal10(d.realValue * n.RealValue);
        public static Decimal10 operator /(Decimal10 d, NumericSystem n)
        => new Decimal10(d.realValue / n.RealValue);
        public static bool operator >(Decimal10 d, NumericSystem n)
        => d.realValue > n.RealValue;
        public static bool operator <(Decimal10 d, NumericSystem n)
        => d.realValue < n.RealValue;
        public static bool operator >=(Decimal10 d, NumericSystem n)
        => d.realValue >= n.RealValue;
        public static bool operator <=(Decimal10 d, NumericSystem n)
        => d.realValue <= n.RealValue;
        public static bool operator ==(Decimal10 d, NumericSystem n)
        => d.realValue == n.RealValue;
        public static bool operator !=(Decimal10 d, NumericSystem n)
        => d.realValue != n.RealValue;
        #endregion
        #region #Operators Alone
        public static Decimal10 operator +(Decimal10 d)
        => d;
        public static Decimal10 operator -(Decimal10 d)
        => d * -1;
        public static Decimal10 operator ++(Decimal10 d)
        => d.realValue++;
        public static Decimal10 operator --(Decimal10 d)
        => d.realValue--;
        #endregion

        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// A hexadecimal number, which only contains digits from 0 to 15 (0 to F).
    /// </summary>
    public class Hexadecimal : NumericSystem
    {
        /// <summary>
        /// Builds up a new Hexadecimal Number.
        /// </summary>
        public Hexadecimal() : this(0) { }
        /// <summary>
        /// Builds up a new Hexadecimal Number with certain value.
        /// <summary>
        /// <param name="value">The selected Real value.</param>
        public Hexadecimal(double value)
        {
            NumericSystem numeric = new NumericSystem(16, value);
            realValue = numeric.RealValue;
            this.value = numeric.ToString();
            Base = 16;
        }
        /// <summary>
        /// Builds up a new Hexadecimal Number with certain value.
        /// <summary>
        /// <param name="value">The string value that represents the Hexadecimal Number's value.</param>
        public Hexadecimal(string value)
        {
            NumericSystem numeric = new NumericSystem(16, value);
            realValue = numeric.RealValue;
            this.value = numeric.ToString();
            Base = 16;
        }

        #region #Conversions
        public static implicit operator Hexadecimal(double v)
        => new Hexadecimal(v);
        #endregion
        #region #Operators With Another Numeric System
        public static Hexadecimal operator +(Hexadecimal h, NumericSystem n)
        => new Hexadecimal(h.realValue + n.RealValue);
        public static Hexadecimal operator -(Hexadecimal h, NumericSystem n)
        => new Hexadecimal(h.realValue - n.RealValue);
        public static Hexadecimal operator *(Hexadecimal h, NumericSystem n)
        => new Hexadecimal(h.realValue * n.RealValue);
        public static Hexadecimal operator /(Hexadecimal h, NumericSystem n)
        => new Hexadecimal(h.realValue / n.RealValue);
        public static bool operator >(Hexadecimal h, NumericSystem n)
        => h.realValue > n.RealValue;
        public static bool operator <(Hexadecimal h, NumericSystem n)
        => h.realValue < n.RealValue;
        public static bool operator >=(Hexadecimal h, NumericSystem n)
        => h.realValue >= n.RealValue;
        public static bool operator <=(Hexadecimal h, NumericSystem n)
        => h.realValue <= n.RealValue;
        public static bool operator ==(Hexadecimal h, NumericSystem n)
        => h.realValue == n.RealValue;
        public static bool operator !=(Hexadecimal h, NumericSystem n)
        => h.realValue != n.RealValue;
        #endregion
        #region #Operators Alone
        public static Hexadecimal operator +(Hexadecimal h)
        => h;
        public static Hexadecimal operator -(Hexadecimal h)
        => h * -1;
        public static Hexadecimal operator ++(Hexadecimal h)
        => h.realValue++;
        public static Hexadecimal operator --(Hexadecimal h)
        => h.realValue--;
        #endregion

        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// A sixty-four-base number, which only contains digits from 0 to 63 (0 to 9, and A to Z, and a to z, including '!' and '?').
    /// </summary>
    public class SixtyFourBase : NumericSystem
    {
        /// <summary>
        /// Builds up a new Sixty-Four-Base Number.
        /// </summary>
        public SixtyFourBase() : this(0d) { }
        /// <summary>
        /// Builds up a new Sixty-Four-Base Number with certain value.
        /// <summary>
        /// <param name="value">The selected Real value.</param>
        public SixtyFourBase(double value)
        {
            NumericSystem numeric = new NumericSystem(64, value);
            realValue = numeric.RealValue;
            this.value = numeric.ToString();
            Base = 64;
        }
        /// <summary>
        /// Builds up a new Sixty-Four-Base Number with certain value.
        /// <summary>
        /// <param name="value">The string value that represents the Sixty-Four-Base Number's value.</param>
        public SixtyFourBase(string value)
        {
            NumericSystem numeric = new NumericSystem(64, value);
            realValue = numeric.RealValue;
            this.value = numeric.ToString();
            Base = 64;
        }

        #region #Conversions
        public static implicit operator SixtyFourBase(double v)
        => new SixtyFourBase(v);
        #endregion
        #region #Operators With Another Numeric System
        public static SixtyFourBase operator +(SixtyFourBase s, NumericSystem n)
        => new SixtyFourBase(s.realValue + n.RealValue);
        public static SixtyFourBase operator -(SixtyFourBase s, NumericSystem n)
        => new SixtyFourBase(s.realValue - n.RealValue);
        public static SixtyFourBase operator *(SixtyFourBase s, NumericSystem n)
        => new SixtyFourBase(s.realValue * n.RealValue);
        public static SixtyFourBase operator /(SixtyFourBase s, NumericSystem n)
        => new SixtyFourBase(s.realValue / n.RealValue);
        public static bool operator >(SixtyFourBase s, NumericSystem n)
        => s.realValue > n.RealValue;
        public static bool operator <(SixtyFourBase s, NumericSystem n)
        => s.realValue < n.RealValue;
        public static bool operator >=(SixtyFourBase s, NumericSystem n)
        => s.realValue >= n.RealValue;
        public static bool operator <=(SixtyFourBase s, NumericSystem n)
        => s.realValue <= n.RealValue;
        public static bool operator ==(SixtyFourBase s, NumericSystem n)
        => s.realValue == n.RealValue;
        public static bool operator !=(SixtyFourBase s, NumericSystem n)
        => s.realValue != n.RealValue;
        #endregion
        #region #Operators Alone
        public static SixtyFourBase operator +(SixtyFourBase s)
        => s;
        public static SixtyFourBase operator -(SixtyFourBase s)
        => s * -1;
        public static SixtyFourBase operator ++(SixtyFourBase s)
        => s.realValue++;
        public static SixtyFourBase operator --(SixtyFourBase s)
        => s.realValue--;
        #endregion

        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// A binary-coded-decimal, which is a Decimal Number has been coded into Binary System.
    /// </summary>
    public class BinaryCodedDecimal : NumericSystem
    {
        /// <summary>
        /// The separator character between each digit.
        /// </summary>
        protected char separator = ' ';
        /// <summary>
        /// Removes the spaces and adds another sepratotr instead,
        /// (Digits of Numeric System aren't allowed).
        /// </summary>
        public string Arrange(char c)
        {
            if (Digits.ToList().IndexOf(c) < 0)
            {
                char oldSeparator = separator;
                separator = c;
                return value.Replace(oldSeparator, c);
            }
            return value;
        }

        /// <summary>
        /// Builds up a new Binary-Coded-Decimal Number.
        /// </summary>
        protected BinaryCodedDecimal() : this(0) { }
        /// <summary>
        /// Builds up a new Binary-Coded-Decimal Number with a certain value.
        /// </summary>
        /// <param name="value">The selected Real value.</param>
        public BinaryCodedDecimal(double value)
        {
            realValue = value;
            SetValue();
        }
        /// <summary>
        /// Builds up a new Binary-Coded-Decimal Number with a certain value.
        /// </summary>
        /// <param name="value">The string value that represents the Binary-Coded-Decimal Number's value.</param>
        public BinaryCodedDecimal(string value)
        {
            char separator = '!';
            bool foundComma = false;
            bool negative = value.StartsWith("-");
            if (negative) { value = value.Remove(0, 1); }
            for (int i = 0; i < value.Length; i++)
            {
                char item = value[i];
                if (Digits.ToList().IndexOf(item) < 0)
                {
                    if (item == '.')
                    {
                        if ((i > 0 && (value[i - 1] == separator && value[i - 1] != '-')) || (i + 1 < value.Length && Digits.ToList().IndexOf(value[i + 1]) < 0)) { goto BREAK; }
                        if (!foundComma) { foundComma = true; continue; }
                        else { goto BREAK; }
                    }
                    if (separator == '!' && i > 0 && i != value.Length - 1) { if (item != '-') { separator = item; continue; } else { goto BREAK; } }
                    else if ((item == separator && item != '-') && i < value.Length - 1 && (value[i - 1] != separator && value[i - 1] != '-')) { continue; }
                    else { goto BREAK; }
                }
                if (Digits.ToList().IndexOf(item) > 1) { goto BREAK; }
            }
            string realValue = "";
            string[] separatedValue = value.Split(separator);
            foreach (string item in separatedValue)
            {
                if (item.Contains('.'))
                {
                    Binary b1 = new Binary(item.Split('.')[0].ToString());
                    Binary b2 = new Binary(item.Split('.')[1].ToString());
                    if (b1.RealValue > 9 || b2.RealValue > 9) { goto BREAK; }
                    realValue += b1.RealValue + "." + b2.RealValue;
                    continue;
                }
                Binary b = new Binary(item.ToString());
                if (b.RealValue > 9) { goto BREAK; }
                realValue += b.RealValue;
            }
            if (negative) { realValue = realValue.Insert(0, "-"); }
            this.realValue = double.Parse(realValue);
            SetValue();
            return;
            BREAK:
            this.realValue = 0;
            return;
        }

        protected void SetValue()
        {
            value = "";
            bool negative = Mathematics.IsNegative(realValue);
            foreach (var item in (Mathematics.Absolute(Mathematics.Floor(realValue))).ToString())
            {
                int x = int.Parse(item.ToString());
                Binary number = new Binary(x);
                value += (x <= 1 ? "000" : x <= 3 ? "00" : x <= 7 ? "0" : "") + number + separator;
            }
            value = value.Remove(value.Length - 1);
            if (!Mathematics.IsFraction(realValue)) { goto END; }
            value += ".";
            foreach (var item in realValue.ToString().Split('.')[1])
            {
                if (decimal.Parse(realValue.ToString().Split('.')[1]) == 0.0m)
                {
                    break;
                }
                int x = int.Parse(item.ToString());
                Binary fraction = new Binary(x);
                value += (x <= 1 ? "000" : x <= 3 ? "00" : x <= 7 ? "0" : "") + fraction + separator;
            }
            value = value.Remove(value.Length - 1);
            END:
            if (negative)
            { value = value.Insert(0, "-"); }
        }

        #region #Conversions
        public static implicit operator BinaryCodedDecimal(double v)
        => new BinaryCodedDecimal(v);
        #endregion
        #region #Operators With Another Numeric System
        public static BinaryCodedDecimal operator +(BinaryCodedDecimal bcd, NumericSystem n)
        => new BinaryCodedDecimal(bcd.realValue + n.RealValue);
        public static BinaryCodedDecimal operator -(BinaryCodedDecimal bcd, NumericSystem n)
        => new BinaryCodedDecimal(bcd.realValue - n.RealValue);
        public static BinaryCodedDecimal operator *(BinaryCodedDecimal bcd, NumericSystem n)
        => new BinaryCodedDecimal(bcd.realValue * n.RealValue);
        public static BinaryCodedDecimal operator /(BinaryCodedDecimal bcd, NumericSystem n)
        => new BinaryCodedDecimal(bcd.realValue / n.RealValue);
        public static bool operator >(BinaryCodedDecimal bcd, NumericSystem n)
        => bcd.realValue > n.RealValue;
        public static bool operator <(BinaryCodedDecimal bcd, NumericSystem n)
        => bcd.realValue < n.RealValue;
        public static bool operator >=(BinaryCodedDecimal bcd, NumericSystem n)
        => bcd.realValue >= n.RealValue;
        public static bool operator <=(BinaryCodedDecimal bcd, NumericSystem n)
        => bcd.realValue <= n.RealValue;
        public static bool operator ==(BinaryCodedDecimal bcd, NumericSystem n)
        => bcd.realValue == n.RealValue;
        public static bool operator !=(BinaryCodedDecimal bcd, NumericSystem n)
        => bcd.realValue != n.RealValue;
        #endregion
        #region #Operators Alone
        public static BinaryCodedDecimal operator +(BinaryCodedDecimal bcd)
        => bcd;
        public static BinaryCodedDecimal operator -(BinaryCodedDecimal bcd)
        => bcd * -1;
        public static BinaryCodedDecimal operator ++(BinaryCodedDecimal bcd)
        => bcd.realValue++;
        public static BinaryCodedDecimal operator --(BinaryCodedDecimal bcd)
        => bcd.realValue--;
        #endregion

        /// <summary>
        /// Converts the value of the Binary-Coded-Decimal into a string value.
        /// </summary>
        /// <returns>The string value of the Binary-Coded-Decimal.</returns>
        public override string ToString()
        => value;
        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// A binary-coded-decimal, which is a Decimal Number has been coded into Binary System.
    /// </summary>
    public class BCD : BinaryCodedDecimal
    {
        /// <summary>
        /// Builds up a new Binary-Coded-Decimal Number.
        /// </summary>
        public BCD() : this(0) { }
        /// <summary>
        /// Builds up a new Binary-Coded-Decimal Number with a certain value.
        /// </summary>
        /// <param name="value">The selected Real value.</param>
        public BCD(double value)
        {
            realValue = value;
            SetValue();
        }
        /// <summary>
        /// Builds up a new Binary-Coded-Decimal Number with a certain value.
        /// </summary>
        /// <param name="value">The string value that represents the Binary-Coded-Decimal Number's value.</param>
        public BCD(string value)
        {
            BinaryCodedDecimal bcd = new BinaryCodedDecimal(value);
            realValue = bcd.RealValue;
            SetValue();
        }

        #region #Conversions
        public static implicit operator BCD(double v)
        => new BCD(v);
        #endregion
        #region #Operators With Another Numeric System
        public static BCD operator +(BCD bcd, NumericSystem n)
        {
            return new BCD(bcd.realValue + n.RealValue);
        }
        public static BCD operator -(BCD bcd, NumericSystem n)
        {
            return new BCD(bcd.realValue - n.RealValue);
        }
        public static BCD operator *(BCD bcd, NumericSystem n)
        {
            return new BCD(bcd.realValue * n.RealValue);
        }
        public static BCD operator /(BCD bcd, NumericSystem n)
        {
            return new BCD(bcd.realValue / n.RealValue);
        }
        public static bool operator >(BCD bcd, NumericSystem n)
        {
            return bcd.realValue > n.RealValue;
        }
        public static bool operator <(BCD bcd, NumericSystem n)
        {
            return bcd.realValue < n.RealValue;
        }
        public static bool operator >=(BCD bcd, NumericSystem n)
        {
            return bcd.realValue >= n.RealValue;
        }
        public static bool operator <=(BCD bcd, NumericSystem n)
        {
            return bcd.realValue <= n.RealValue;
        }
        public static bool operator ==(BCD bcd, NumericSystem n)
        {
            return bcd.realValue == n.RealValue;
        }
        public static bool operator !=(BCD bcd, NumericSystem n)
        {
            return bcd.realValue != n.RealValue;
        }
        #endregion
        #region #Operators Alone
        public static BCD operator +(BCD bcd)
        => bcd;
        public static BCD operator -(BCD bcd)
        => bcd * -1;
        public static BCD operator ++(BCD bcd)
        => bcd.realValue++;
        public static BCD operator --(BCD bcd)
        => bcd.realValue--;
        #endregion

        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }

    #endregion

    #region #Numbers

    /// <summary>
    /// A lateral number, which exists in the Lateral Numbers Axis.
    /// </summary>
    public class Lateral : IFormattable, IComparable
    {
        /// <summary>
        /// Determines the character of a Lateral.
        /// </summary>
        public enum LateralCharacter
        {
            /// <summary>The letter i.</summary>
            i,
            /// <summary>The letter i.</summary>
            j,
            /// <summary>The letter i.</summary>
            k,
        }

        /// <summary>
        /// The value of the Lateral Number.
        /// </summary>
        protected string value = "";
        /// <summary>
        /// The real part value of the Lateral Number.
        /// </summary>
        protected double realValue = 1;
        /// <summary>
        /// Gives the proverbs of the Lateral Number.
        /// </summary>
        /// <returns>The proverbs that's multiplied with the Lateral Number.</returns>
        public double Proverbs { get { return circling == 0 || circling == 1 ? realValue : -realValue; } }
        /// <summary>
        /// The amount of circling of the Lateral Number.
        /// </summary>
        protected int circling = 1;
        /// <summary>
        /// Gives the circling of the Lateral Number.
        /// </summary>
        /// <returns>The circling of the Lateral Number.</returns>
        public int Circling { get { return circling; } }
        /// <summary>
        /// The character of the Lateral.
        /// </summary>
        protected LateralCharacter character;
        /// <summary>
        /// The character of the Lateral.
        /// </summary>
        public LateralCharacter Character { get { return character; } }

        /// <summary>
        /// Represents the value of 1 on the Lateral Numbers Axis, or in other words,
        /// the squrare root of -1 in the Real Numbers Axis.
        /// </summary>
        public static Lateral i { get { return new Lateral(LateralCharacter.i); } }
        /// <summary>
        /// Represents the value of 1 on the Lateral Numbers Axis, or in other words,
        /// the squrare root of -1 in the Real Numbers Axis.
        /// </summary>
        public static Lateral j { get { return new Lateral(LateralCharacter.j); } }
        /// <summary>
        /// Represents the value of 1 on the Lateral Numbers Axis, or in other words,
        /// the squrare root of -1 in the Real Numbers Axis.
        /// </summary>
        public static Lateral k { get { return new Lateral(LateralCharacter.k); } }

        /// <summary>
        /// Builds up a new Lateral Number with a character.
        /// </summary>
        /// <param name="character">The selected character for the Lateral Number.</param>
        public Lateral(LateralCharacter character)
        {
            this.character = character;
            realValue = 1;
            circling = 1;
        }
        /// <summary>
        /// Builds up a new Lateral Number with a character and proverbs value.
        /// </summary>
        /// <param name="character">The selected character for the Lateral Number.</param>
        /// <param name="value">The selected value of the proverbs.</param>
        public Lateral(LateralCharacter character, double value)
        {
            this.character = character;
            realValue = value;
            circling = 1;
        }

        /// <summary>
        /// Sets the amount of circling of the Lateral Number, (circles its power between 0 and 3).
        /// </summary>
        /// <param name="circling">The selected amount of circling.</param>
        protected void SetCirlcing(int circling)
        {
            this.circling = circling;
            this.circling = Mathematics.Circle(this.circling, 0, 3);
            value = this.circling == 0 ? realValue.ToString() :
                    this.circling == 1 ? (realValue == 1 ? character.ToString() : realValue == 0 ? "0" : realValue == -1 ? $"-{character.ToString()}" : realValue == Mathematics.PositiveInfinity ? Mathematics.PositiveInfinity.ToString() : realValue == Mathematics.NegativeInfinity ? Mathematics.NegativeInfinity.ToString() : realValue.ToString() + character.ToString()) :
                    this.circling == 2 ? (realValue * -1).ToString() :
                    realValue == 1 ? $"-{character.ToString()}" : realValue == 0 ? "0" : realValue == -1 ? character.ToString() : realValue == Mathematics.PositiveInfinity ? Mathematics.NegativeInfinity.ToString() : realValue == Mathematics.NegativeInfinity ? Mathematics.PositiveInfinity.ToString() : (realValue * -1).ToString() + character.ToString();
            if (value == $"NaN{character.ToString()}")
            { value = "NaN"; }
        }

        /// <summary>
        /// Gets the correct character of the Lateral Number according to two characters of two Lateral Numbers multiplied.
        /// </summary>
        /// <param name="char1">The first character of the first Lateral Number.</param>
        /// <param name="char2">The second character of the second Lateral Number.</param>
        /// <param name="sign">The sign of the multiplication, (yeah order matters).</param>
        /// <returns>The correct character for the selected two Lateral Numbers multiplied, and its sign.</returns>
        private static LateralCharacter MultiplieCharacter(LateralCharacter char1, LateralCharacter char2, out int sign)
        {
            // i^2  =   j^2  =  k^2  = -1
            // i * j * k = i / j / k = -1
            // ij = -ji = k  ,   ji = -ij = -k
            // jk = -kj = i  ,   kj = -jk = -i
            // ki = -ik = j  ,   ik = -ki = -j
            switch (char1)
            {
                default:
                case LateralCharacter.i:
                    sign = char2 == LateralCharacter.k ? -1 : +1;
                    break;
                case LateralCharacter.j:
                    sign = char2 == LateralCharacter.i ? -1 : +1;
                    break;
                case LateralCharacter.k:
                    sign = char2 == LateralCharacter.j ? -1 : +1;
                    break;
            }
            int c1 = (int)char1, c2 = (int)char2;
            if (c1 == c2) { return (LateralCharacter)c1; }
            else
            {
                for (int i = 0; i <= 2; i++)
                { if (c1 != i && c2 != i) { return (LateralCharacter)i; } }
            }
            return LateralCharacter.i;
        }

        #region #Operators With a Number
        public static Lateral operator *(Lateral l, double n)
        => new Lateral(l.character, l.realValue * n);
        public static Lateral operator *(double n, Lateral l)
        => new Lateral(l.character, l.realValue * n);
        public static Lateral operator /(Lateral l, double n)
        => new Lateral(l.character, l.realValue / n);
        public static Lateral operator /(double n, Lateral l)
        => new Lateral(l.character, n / l.realValue);
        #endregion
        #region #Operators With Another Lateral
        public static Lateral operator *(Lateral l1, Lateral l2)
        {
            int sign;
            LateralCharacter character = MultiplieCharacter(l1.character, l2.character, out sign);
            Lateral l = new Lateral(character, l1.realValue * l2.realValue * sign);
            if (l1.character == l2.character) { l.SetCirlcing(l1.circling + l2.circling); }
            return l;
        }
        public static Lateral operator /(Lateral l1, Lateral l2)
        {
            int sign;
            LateralCharacter character = MultiplieCharacter(l2.character, l1.character, out sign);
            Lateral l = new Lateral(character, l1.realValue / l2.realValue * sign);
            if (l1.character == l2.character) { l.SetCirlcing(l1.circling - l2.circling); }
            return l;
        }
        public static bool operator <(Lateral l1, Lateral l2)
        => l1.realValue < l2.realValue && l1.character == l2.character;
        public static bool operator >(Lateral l1, Lateral l2)
        => l1.realValue > l2.realValue && l1.character == l2.character;
        public static bool operator <=(Lateral l1, Lateral l2)
        => l1.realValue <= l2.realValue && l1.character == l2.character;
        public static bool operator >=(Lateral l1, Lateral l2)
        => l1.realValue >= l2.realValue && l1.character == l2.character;
        public static bool operator ==(Lateral l1, Lateral l2)
        => l1.realValue == l2.realValue && l1.character == l2.character;
        public static bool operator !=(Lateral l1, Lateral l2)
        => l1.realValue != l2.realValue || l1.character != l2.character;
        #endregion
        #region #Operatorts Alone
        public static Lateral operator +(Lateral l)
        => l;
        public static Lateral operator -(Lateral l)
        => new Lateral(l.character, -l.realValue);
        public static Lateral operator ++(Lateral l)
        { l.realValue++; return l; }
        public static Lateral operator --(Lateral l)
        { l.realValue--; return l; }
        #endregion

        /// <summary>
        /// Converts the Lateral Number into a two-by-two Matrix.
        /// </summary>
        /// <returns>A Matrix that represents the Lateral Number.</returns>
        public Matrix2<Complex> ToMatrix2()
         => Character == LateralCharacter.i && (circling == 1 || circling == 3) ? new Matrix2<Complex>().FillDiagonally(new Complex[] { Proverbs * Mathematics.i, -Proverbs * Mathematics.i })
         : Character == LateralCharacter.j && (circling == 1 || circling == 3) ? new Matrix2<Complex>().Fill(new Complex[] { (Complex)0, -(Complex)Proverbs, (Complex)Proverbs, (Complex)0 })
         : Character == LateralCharacter.k && (circling == 1 || circling == 3) ? new Matrix2<Complex>().Fill(new Complex[] { (Complex)0, Proverbs * Mathematics.i, Proverbs * Mathematics.i, (Complex)0 })
                        : (Complex)Proverbs * Matrix2<Complex>.IdenticalMatrix;
        /// <summary>
        /// Converts the Lateral Number into a three-by-three Matrix.
        /// </summary>
        /// <returns>A Matrix that represents the Lateral Number.</returns>
        public Matrix3<double> ToMatrix3()
         => Character == LateralCharacter.i && (circling == 1 || circling == 3) ? Proverbs * Matrix3<double>.iMatrix
         : Character == LateralCharacter.j && (circling == 1 || circling == 3) ? Proverbs * Matrix3<double>.jMatrix
         : Character == LateralCharacter.k && (circling == 1 || circling == 3) ? Proverbs * Matrix3<double>.kMatrix
                        : Proverbs * Matrix3<double>.IdenticalMatrix;

        /// <summary>
        /// Converts the value of the Lateral Number into a string value.
        /// </summary>
        /// <returns>A string value that represents the Lateral Number value.</returns>
        public override string ToString()
        { SetCirlcing(circling); return value; }
        /// <summary>
        /// Converts the value of the Complex Number into a string value.
        /// </summary>
        /// <param name="format">A standard or custom numeric format system.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>A string value that represents the Complex Number value.</returns>
        public string ToString(string format, IFormatProvider provider)
        { SetCirlcing(circling); return value; }
        /// <summary>
        /// Compares this instance to a specified Lateral Number and returns an indecation of their relative values.
        /// </summary>
        /// <param name="value">A Lateral Number to compare.</param>
        /// <returns>A signed number indicating the relative values of this instance and value.Return
        /// Value Description Less than zero This instance is less than value. Zero This
        /// instance is equal to value. Greater than zero This instance is greater than value.-or-
        /// value is null.</returns>
        public int CompareTo(Lateral value)
        => realValue.CompareTo(value.realValue);
        /// <summary>
        /// Compares this instance to a specified object and returns an indecation of their relative values.
        /// </summary>
        /// <param name="value">An object to compare, or null.</param>
        /// <returns>A signed number indicating the relative values of this instance and value.Return
        /// Value Description Less than zero This instance is less than value. Zero This
        /// instance is equal to value. Greater than zero This instance is greater than value.-or-
        /// value is null.</returns>
        public int CompareTo(object value)
        {
            if (value is Lateral) { return realValue.CompareTo((value as Lateral).realValue); }
            throw new ArgumentException("Object must be of type Lateral.");
        }
        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// An imaginary number, which exists in the Imaginary Numbers Axis.
    /// </summary>
    public class Imaginary : Lateral
    {
        /// <summary>
        /// Represents the value of 1 on the Imaginary Numbers Axis, or in other words,
        /// the squrare root of -1 in the Real Numbers Axis.
        /// </summary>
        public new static Imaginary i { get { return new Imaginary(); } }

        /// <summary>
        /// Builds up a new Imaginary Number.
        /// </summary>
        public Imaginary() : base(LateralCharacter.i) { }
        /// <summary>
        /// Builds up a new Imaginary Number with proverbs value.
        /// </summary>
        /// <param name="value">The selected value of the proverbs.</param>
        public Imaginary(double value) : base(LateralCharacter.i, value) { }

        #region #Operators With a Number
        public static Imaginary operator *(Imaginary i, double n)
        {
            Imaginary i_ = new Imaginary();
            i_.circling = i.circling;
            i_.realValue = i.realValue * n;
            return i_;
        }
        public static Imaginary operator *(double n, Imaginary i)
        {
            Imaginary i_ = new Imaginary();
            i_.circling = i.circling;
            i_.realValue = i.realValue * n;
            return i_;
        }
        public static Imaginary operator /(Imaginary i, double n)
        {
            Imaginary i_ = new Imaginary();
            i_.circling = i.circling;
            i_.realValue = i.realValue / n;
            return i_;
        }
        public static Imaginary operator /(double n, Imaginary i)
        {
            Imaginary i_ = new Imaginary();
            i_.circling = i.circling;
            i_.realValue = n / i.realValue;
            return i_;
        }
        #endregion
        #region #Operators With Another Imaginary
        public static Imaginary operator +(Imaginary i1, Imaginary i2)
        {
            if (i1.circling == i2.circling)
            { return new Imaginary(i1.realValue + i2.realValue); }
            throw new DifferentPowerImaginaryNumbersAdditionOrSubstractionException();
        }
        public static Imaginary operator -(Imaginary i1, Imaginary i2)
        {
            if (i1.circling == i2.circling)
            { return new Imaginary(i1.realValue - i2.realValue); }
            throw new DifferentPowerImaginaryNumbersAdditionOrSubstractionException();
        }
        public static Imaginary operator *(Imaginary i1, Imaginary i2)
        {
            Imaginary i = new Imaginary(i1.realValue * i2.realValue);
            i.SetCirlcing(i1.circling + i2.circling);
            return i;
        }
        public static Imaginary operator /(Imaginary i1, Imaginary i2)
        {
            Imaginary i = new Imaginary(i1.realValue / i2.realValue);
            i.SetCirlcing(i1.circling - i2.circling);
            return i;
        }
        public static bool operator <(Imaginary i1, Imaginary i2)
        => i1.realValue < i2.realValue;
        public static bool operator >(Imaginary i1, Imaginary i2)
        => i1.realValue > i2.realValue;
        public static bool operator <=(Imaginary i1, Imaginary i2)
        => i1.realValue <= i2.realValue;
        public static bool operator >=(Imaginary i1, Imaginary i2)
        => i1.realValue >= i2.realValue;
        public static bool operator ==(Imaginary i1, Imaginary i2)
        => i1.realValue == i2.realValue;
        public static bool operator !=(Imaginary i1, Imaginary i2)
        => i1.realValue != i2.realValue;
        #endregion
        #region #Operatorts Alone
        public static Imaginary operator +(Imaginary i)
        => i;
        public static Imaginary operator -(Imaginary i)
        => new Imaginary(-i.realValue);
        public static Imaginary operator ++(Imaginary i)
        { i.realValue++; return i; }
        public static Imaginary operator --(Imaginary i)
        { i.realValue--; return i; }
        #endregion

        /// <summary>
        /// Converts the Imaginary Number into a two-by-two Matrix.
        /// </summary>
        /// <returns>A Matrix that represents the Imaginary Number.</returns>
        public new Matrix2<double> ToMatrix()
        => circling == 1 || circling == 3 ? Proverbs * Matrix2<double>.iMatrix:
                                            Proverbs * Matrix2<double>.IdenticalMatrix;

        /// <summary>
        /// Converts the value of the Imaginary Number into a string value.
        /// </summary>
        /// <returns>A string value that represents the Imaginary Number value.</returns>
        public override string ToString()
        { SetCirlcing(circling); return value; }
        /// <summary>
        /// Compares this instance to a specified Imaginary Number and returns an indecation of their relative values.
        /// </summary>
        /// <param name="value">An Imaginary Number to compare.</param>
        /// <returns>A signed number indicating the relative values of this instance and value.Return
        /// Value Description Less than zero This instance is less than value. Zero This
        /// instance is equal to value. Greater than zero This instance is greater than value.-or-
        /// value is null.</returns>
        public int CompareTo(Imaginary value)
        => realValue.CompareTo(value.realValue);
        /// <summary>
        /// Compares this instance to a specified object and returns an indecation of their relative values.
        /// </summary>
        /// <param name="value">An object to compare, or null.</param>
        /// <returns>A signed number indicating the relative values of this instance and value.Return
        /// Value Description Less than zero This instance is less than value. Zero This
        /// instance is equal to value. Greater than zero This instance is greater than value.-or-
        /// value is null.</returns>
        public new int CompareTo(object value)
        {
            if (value is Imaginary) { return realValue.CompareTo((value as Imaginary).realValue); }
            throw new ArgumentException("Object must be of type Imaginary.");
        }
        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// A complex number, which is a two dimensional number,
    /// represents a set of a Real Number and an Imaginary Number.
    /// </summary>
    public class Complex : IFormattable, IComparable
    {
        /// <summary>
        /// The value of the Complex Number.
        /// </summary>
        private string value = "0";
        /// <summary>
        /// The real part of the Complex Number.
        /// </summary>
        private double realValue = 0;
        /// <summary>
        /// The imaginary part of the Complex Number.
        /// </summary>
        private Imaginary imaginaryValue = i * 0;
        /// <summary>
        /// The real part of the Complex Number.
        /// </summary>
        public double RealPart { get { return realValue; } set { realValue = value; } }
        /// <summary>
        /// The imaginary part of the Complex Number.
        /// </summary>
        public Imaginary ImaginaryPart { get { return imaginaryValue; } set { imaginaryValue = value; } }
        /// <summary>
        /// The length of the Complex Number.
        /// </summary>
        public double Magnitude { get { return Mathematics.GetHypotenuse(realValue, imaginaryValue.Proverbs); } }
        /// <summary>
        /// The angle of the Complex Number on the Real-o-Imaginary Numbers Axis, (measured in Degrees).
        /// </summary>
        public double Angle
        {
            get
            {
                double sin = Magnitude > 0 ? imaginaryValue.Proverbs / Magnitude : 0,
                       cos = Magnitude > 0 ? realValue / Magnitude : 0;
                double θ1, θ2;
                Mathematics.Arcsin(sin, out θ1, out θ2);
                return Quarter == 1 || Quarter == 3 ? θ1 : θ2;
            }
        }
        /// <summary>
        /// Represents the quarter that this Complex Number is in.
        /// </summary>
        public int Quarter { get { return realValue >= 0 ? (imaginaryValue.Proverbs >= 0 ? 1 : 4) : (imaginaryValue.Proverbs >= 0 ? 2 : 3); } }
        /// <summary>
        /// The Complex Number with an equal real part and an imaginary part equal in magnitude but opposite in sign.
        /// </summary>
        public Complex Conjugate { get { return new Complex(RealPart, -ImaginaryPart); } }
        /// <summary>
        /// The Complex Number that satisfies One over this Complex Number.
        /// </summary>
        public Complex Inverse { get { return 1 / this; } }
        /// <summary>
        /// Returns the Complex Number normalized into a length of One.
        /// </summary>
        public Complex Normalized { get { return this / Magnitude; } }

        /// <summary>
        /// A shortcut.
        /// </summary>
        private static Imaginary i = Mathematics.i;

        /// <summary>
        /// The form of showing the Complex Number's value in a set of its
        /// Length and Angle.
        /// </summary>
        public const string TrignomentricalForm = "z = [ r , θ ]";
        /// <summary>
        /// The form of showing the Complex Number's value in a set of its
        /// Length and its Angle's Sine and Cosine.
        /// </summary>
        public const string PolarForm = "z = r ( Cos(θ) + i Sin(θ) )";
        /// <summary>
        /// The form of showing the Complex Number's value in a set of its
        /// Length and Euler's Number raised to its Angle.
        /// </summary>
        public const string ExponentialForm = "z = re^θi";
        /// <summary>
        /// The form of showing the Complex Number's value in a set of its
        /// Real and Imaginary Numbers Values.
        /// </summary>
        public const string RectangularForm = "z = x + yi";

        /// <summary>
        /// Builds up a new Complex Number.
        /// </summary>
        public Complex()
        {
            realValue = 0;
            imaginaryValue = i * 0;
        }
        /// <summary>
        /// Builds up a new Complex Number by Axis.
        /// </summary>
        /// <param name="realValue">The value of the Complex Number on the Real Numbers Axis.</param>
        /// <param name="imaginaryValue">The value of the Complex Number on the Imaginary Number Axis.</param>
        public Complex(double realValue, Imaginary imaginaryValue)
        {
            this.realValue = realValue;
            this.imaginaryValue = imaginaryValue;
        }
        /// <summary>
        /// Builds up a new Complex Number by Vector.
        /// </summary>
        /// <param name="length">The length of the Complex Number.</param>
        /// <param name="θ">The angle of the Complex Number on the Real-o-Imaginary Axis, (measured in Radians).</param>
        public Complex(double length, double θ)
        {
            // Cosθ = x / r; Sinθ = y / r
            // x = Cosθ * r; y = Sinθ * r
            realValue = Mathematics.Cos(Mathematics.InitializeInCircle(θ)) * Mathematics.Absolute(length);
            imaginaryValue = Mathematics.Sin(Mathematics.InitializeInCircle(θ)) * Mathematics.Absolute(length) * i;
        }
        /// <summary>
        /// Builds up a new Complex Number from a two dimensional Vector.
        /// </summary>
        /// <param name="vector">The selected two dimensional Vector.</param>
        public Complex(Vector2D vector) : this(vector.i, vector.j * i) { }

        /// <summary>
        /// Sets the value of the Complex Number.
        /// </summary>
        private void SetValue()
        {
            if (realValue != 0)
            {
                if (imaginaryValue != i * 0)
                { value = realValue + (imaginaryValue > i * 0 ? " + " + imaginaryValue : " - " + -imaginaryValue); }
                else { value = realValue.ToString(); }
            }
            else
            {
                if (imaginaryValue != i * 0) { value = imaginaryValue.ToString(); }
                else { value = "0"; }
            }
        }

        #region #Conversions
        public static explicit operator Complex(double v)
        => new Complex(v, 0 * Mathematics.i);
        public static implicit operator Complex(Imaginary i)
        {
            int ic = i.Circling;
            Imaginary i_ = i.Proverbs * Mathematics.i;
            switch (i.Circling)
            {
                case 0:
                    i_ /= Mathematics.i;
                    return new Complex(i_.Proverbs, 0 * Mathematics.i);
                default:
                case 1:
                    return new Complex(0, i_);
                case 2:
                    i_ /= Mathematics.Power(Mathematics.i, 2);
                    return new Complex(i_.Proverbs, 0 * Mathematics.i) * -1;
                case 3:
                    i_ /= Mathematics.Power(Mathematics.i, 3);
                    return new Complex(0, -i_);
            }
        }
        #endregion
        #region #Operators With a Number
        public static Complex operator +(Complex c, double n)
        => new Complex(c.realValue + n, c.imaginaryValue);
        public static Complex operator -(Complex c, double n)
        => new Complex(c.realValue - n, c.imaginaryValue);
        public static Complex operator -(double n, Complex c)
        => new Complex(n - c.realValue, -c.imaginaryValue);
        public static Complex operator +(Complex c, Imaginary i)
        => new Complex(c.realValue, c.imaginaryValue + i);
        public static Complex operator -(Complex c, Imaginary i)
        => new Complex(c.realValue, c.imaginaryValue - i);
        public static Complex operator -(Imaginary i, Complex c)
        => new Complex(-c.realValue, i - c.imaginaryValue);
        public static Complex operator *(Complex c, double n)
        => new Complex(c.realValue * n, c.imaginaryValue * n);
        public static Complex operator *(double n, Complex c)
        => new Complex(c.realValue * n, c.imaginaryValue * n);
        public static Complex operator /(Complex c, double n)
        => new Complex(c.realValue / n, c.imaginaryValue / n);
        public static Complex operator /(double n, Complex c)
        => new Complex(n, i * 0) / c;
        public static Complex operator *(Complex c, Imaginary i)
        => new Complex(-c.imaginaryValue.Proverbs * i.Proverbs, c.realValue * i);
        public static Complex operator *(Imaginary i, Complex c)
        => new Complex(-c.imaginaryValue.Proverbs * i.Proverbs, c.realValue * i);
        public static Complex operator /(Complex c, Imaginary i)
        => c / new Complex(0, i);
        public static Complex operator /(Imaginary i, Complex c)
        => new Complex(0, i) / c;
        #endregion
        #region #Operators With Another Complex
        public static Complex operator +(Complex c1, Complex c2)
        => new Complex(c1.realValue + c2.realValue, c1.imaginaryValue + c2.imaginaryValue);
        public static Complex operator -(Complex c1, Complex c2)
        => new Complex(c1.realValue - c2.realValue, c1.imaginaryValue - c2.imaginaryValue);
        public static Complex operator *(Complex c1, Complex c2)
        {
            // (a + bi) * (c + di)
            // c(a + bi) + di(a + bi)
            // ac + bci + adi + bdi^2
            // ac - bd + i(bc + ad)
            double a = c1.realValue,
                   b = c1.imaginaryValue.Proverbs,
                   c = c2.realValue,
                   d = c2.imaginaryValue.Proverbs;
            return new Complex(a * c - b * d, i * (b * c + a * d));
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            // (a + bi) / (c + di)
            // (a + bi)(c - di) / (c + di)(c - di)
            // (ac + bd) + i(bc - ad) / (c^2 + d^2)
            // [(ac + bd) / (c^2 + d^2)] + i[(bc - ad) / (c^2 + d^2)]
            double a = c1.realValue,
                   b = c1.imaginaryValue.Proverbs,
                   c = c2.realValue,
                   d = c2.imaginaryValue.Proverbs;
            return new Complex((a * c + b * d) / (c * c + d * d), (i * (b * c - a * d)) / (c * c + d * d));
        }
        public static bool operator <(Complex c1, Complex c2)
        => c1.Magnitude < c2.Magnitude;
        public static bool operator >(Complex c1, Complex c2)
        => c1.Magnitude > c2.Magnitude;
        public static bool operator <=(Complex c1, Complex c2)
        => c1.Magnitude < c2.Magnitude || (c1.RealPart == c2.RealPart && c1.ImaginaryPart == c2.ImaginaryPart);
        public static bool operator >=(Complex c1, Complex c2)
        => c1.Magnitude > c2.Magnitude || (c1.RealPart == c2.RealPart && c1.ImaginaryPart == c2.ImaginaryPart);
        public static bool operator ==(Complex c1, Complex c2)
        => c1.RealPart == c2.RealPart && c1.ImaginaryPart == c2.ImaginaryPart;
        public static bool operator !=(Complex c1, Complex c2)
        => !(c1.RealPart == c2.RealPart && c1.ImaginaryPart == c2.ImaginaryPart);
        #endregion
        #region #Operators Alone
        public static Complex operator +(Complex c)
        => c;
        public static Complex operator -(Complex c)
        => new Complex(-c.realValue, -c.imaginaryValue);
        #endregion

        /// <summary>
        /// Shows the Complex Number in a set of its Length and Angle.
        /// </summary>
        /// <param name="convert">Set True if converting into Radians is needed.</param>
        /// <returns>A value that represents the Trigonometric Form of the Complex Number.</returns>
        public string ToTrigonometricForm(bool convert)
        => $"z = [ {Magnitude} , {(convert ? Angle : Mathematics.ToRadian(Angle)) } ]";
        /// <summary>
        /// Shows the Complex Number in a set of its Length and its Angle's Sine and Cosine.
        /// </summary>
        /// <param name="convert">Set True if converting into Radians is needed.</param>
        /// <returns>A value that represents the Polar Form of the Complex Number.</returns>
        public string ToPolarForm(bool convert)
        {
            double θ = convert ? Angle : Mathematics.ToRadian(Angle);
            return $"z = {Magnitude} ( Cos({θ}) + i Sin({θ}) )";
        }
        /// <summary>
        /// Shows the Complex Number in a set of its Length and Euler's Number raised to its Angle.
        /// </summary>
        /// <param name="convert">Set True if converting into Radians is needed.</param>
        /// <returns>A value that represents the Exponential Form of the Complex Number.</returns>
        public string ToExponentialForm(bool convert)
        => $"z = {Magnitude}e^{(convert ? Angle : Mathematics.ToRadian(Angle))}i";
        /// <summary>
        /// Shows the Complex Number in a set of its Real and Imaginary Numbers Values.
        /// </summary>
        /// <returns>A value that represents the Rectangular Form of the Complex Number.</returns>
        public string ToRectangularForm()
        => $"z = {value}";
        /// <summary>
        /// Converts the Complex Number to a two dimensional Vector.
        /// </summary>
        /// <returns>The two dimensional Vector with the values of the Complex Number.</returns>
        public Vector2D ToVector()
        => new Vector2D(this);
        /// <summary>
        /// Converts the Complex Number into a two-by-two Matrix.
        /// </summary>
        /// <returns>A Matrix that represents the Complex Number.</returns>
        public Matrix2<double> ToMatrix()
        => RealPart * Matrix2<double>.IdenticalMatrix + ImaginaryPart.Proverbs * Mathematics.iMatrix;

        /// <summary>
        /// Converts the value of the Complex Number into a string value.
        /// </summary>
        /// <returns>A string value that represents the Complex Number value.</returns>
        public override string ToString()
        { SetValue(); return value; }
        /// <summary>
        /// Converts the value of the Complex Number into a string value.
        /// </summary>
        /// <param name="format">A standard or custom numeric format system.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>A string value that represents the Complex Number value.</returns>
        public string ToString(string format, IFormatProvider provider)
        { SetValue(); return value; }
        /// <summary>
        /// Compares this instance to a specified Complex Number and returns an indecation of their relative values.
        /// </summary>
        /// <param name="value">A Complex Number to compare.</param>
        /// <returns>A signed number indicating the relative values of this instance and value.Return
        /// Value Description Less than zero This instance is less than value. Zero This
        /// instance is equal to value. Greater than zero This instance is greater than value.-or-
        /// value is null.</returns>
        public int CompareTo(Complex value)
        => Magnitude.CompareTo(value.Magnitude);
        /// <summary>
        /// Compares this instance to a specified object and returns an indecation of their relative values.
        /// </summary>
        /// <param name="value">An object to compare, or null.</param>
        /// <returns>A signed number indicating the relative values of this instance and value.Return
        /// Value Description Less than zero This instance is less than value. Zero This
        /// instance is equal to value. Greater than zero This instance is greater than value.-or-
        /// value is null.</returns>
        public int CompareTo(object value)
        {
            if (value is Complex) { return Magnitude.CompareTo((value as Complex).Magnitude); }
            throw new ArgumentException("Object must be of type Complex.");
        }
        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// A quaternion number, which is a four dimensional number,
    /// represents a set of a Real Number and three different Lateral Numbers.
    /// </summary>
    public class Quaternion : IFormattable, IComparable
    {
        /// <summary>
        /// The value of the Quaternion Number.
        /// </summary>
        private string value = "";
        /// <summary>
        /// The real part of the Quaternion Number.
        /// </summary>
        private double w;
        /// <summary>
        /// The lateral part in the I Axis of the Quaternion Number.
        /// </summary>
        private Lateral x = new Lateral(Lateral.LateralCharacter.i);
        /// <summary>
        /// The lateral part in the J Axis of the Quaternion Number.
        /// </summary>
        private Lateral y = new Lateral(Lateral.LateralCharacter.j);
        /// <summary>
        /// The lateral part in the K Axis of the Quaternion Number.
        /// </summary>
        private Lateral z = new Lateral(Lateral.LateralCharacter.k);
        /// <summary>
        /// The real part of the Quaternion Number.
        /// </summary>
        public double RealPart { get { return w; } set { w = value; } }
        /// <summary>
        /// The lateral part in the I Axis of the Quaternion Number.
        /// </summary>
        public Lateral LateralI { get { return x; } set { x = value; } }
        /// <summary>
        /// The lateral part in the J Axis of the Quaternion Number.
        /// </summary>
        public Lateral LateralJ { get { return y; } set { y = value; } }
        /// <summary>
        /// The lateral part in the K Axis of the Quaternion Number.
        /// </summary>
        public Lateral LateralK { get { return z; } set { z = value; } }
        /// <summary>
        /// The length of the Quaternion Number.
        /// </summary>
        public double Magnitude { get { return Mathematics.GetHypotenuse(w, x.Proverbs, y.Proverbs, z.Proverbs); } }
        /// <summary>
        /// The Quaternion Number with an equal real part and an lateral parts equal in magnitude but opposite in signs.
        /// </summary>
        public Quaternion Conjugate { get { return new Quaternion(w, -x.Proverbs, -y.Proverbs, -z.Proverbs); } }
        /// <summary>
        /// The Quaternion Number that satisfies One over this Quaternion Number.
        /// </summary>
        public Quaternion Inverse { get { return 1 / this; } }

        /// <summary>
        /// A shortcut.
        /// </summary>
        private static Lateral i = new Lateral(Lateral.LateralCharacter.i),
                               j = new Lateral(Lateral.LateralCharacter.j),
                               k = new Lateral(Lateral.LateralCharacter.k);

        /// <summary>
        /// Builds up a new Quaternion Number.
        /// </summary>
        public Quaternion()
        {
            w = 0;
            x = 0 * i;
            y = 0 * j;
            z = 0 * k;
        }
        /// <summary>
        /// Builds up a new Quaternion Number with its values.
        /// </summary>
        /// <param name="w">The value of the Real Number of the Quaternion Number.</param>
        /// <param name="x">The proverbs of the Lateral Number on the I Axis of the Quaternion Number.</param>
        /// <param name="y">The proverbs of the Lateral Number on the J Axis of the Quaternion Number.</param>
        /// <param name="z">The proverbs of the Lateral Number on the K Axis of the Quaternion Number.</param>
        public Quaternion(double w, double x, double y, double z)
        {
            this.w = w;
            this.x = x * i;
            this.y = y * j;
            this.z = z * k;
        }

        /// <summary>
        /// Sets the value of the Quaternion Number.
        /// </summary>
        private void SetValue()
        {
            value = Mathematics.CreateSideEquation(
                                new Calculus.Variable(w, 0),
                                new Calculus.Variable(x.Proverbs, 1, Calculus.VariableCharacter.i),
                                new Calculus.Variable(y.Proverbs, 1, Calculus.VariableCharacter.j),
                                new Calculus.Variable(z.Proverbs, 1, Calculus.VariableCharacter.k));
            if (string.IsNullOrWhiteSpace(value)) { value = "0"; }
        }

        #region #Conversions
        public static explicit operator Quaternion(double v)
        => new Quaternion(v, 0, 0, 0);
        public static implicit operator Quaternion(Imaginary i)
        {
            int ic = i.Circling;
            Imaginary i_ = i.Proverbs * Mathematics.i;
            switch (i.Circling)
            {
                case 0:
                    i_ /= Mathematics.i;
                    return new Quaternion(i_.Proverbs, 0, 0, 0);
                default:
                case 1:
                    return new Quaternion(0, i_.Proverbs, 0, 0);
                case 2:
                    i_ /= Mathematics.Power(Mathematics.i, 2);
                    return new Quaternion(i_.Proverbs, 0, 0, 0) * -1;
                case 3:
                    i_ /= Mathematics.Power(Mathematics.i, 3);
                    return new Quaternion(0, -i_.Proverbs, 0, 0);
            }
        }
        public static implicit operator Quaternion(Complex c)
        => new Quaternion(c.RealPart, c.ImaginaryPart.Proverbs, 0, 0);
        public static implicit operator Quaternion(Lateral l)
        {
            switch (l.Character)
            {
                default:
                case Lateral.LateralCharacter.i:
                    if (l.Circling == 0 || l.Circling == 2)
                    { int sign = l.Circling == 2 ? -1 : +1; return new Quaternion(l.Proverbs * sign, 0, 0, 0); }
                    else
                    { int sign = l.Circling == 3 ? -1 : +1; return new Quaternion(0, l.Proverbs * sign, 0, 0); }
                case Lateral.LateralCharacter.j:
                    if (l.Circling == 0 || l.Circling == 2)
                    { int sign = l.Circling == 2 ? -1 : +1; return new Quaternion(l.Proverbs * sign, 0, 0, 0); }
                    else
                    { int sign = l.Circling == 3 ? -1 : +1; return new Quaternion(0, 0, l.Proverbs * sign, 0); }
                case Lateral.LateralCharacter.k:
                    if (l.Circling == 0 || l.Circling == 2)
                    { int sign = l.Circling == 2 ? -1 : +1; return new Quaternion(l.Proverbs * sign, 0, 0, 0); }
                    else
                    { int sign = l.Circling == 3 ? -1 : +1; return new Quaternion(0, 0, 0, l.Proverbs * sign); }
            }
        }
        #endregion
        #region #Operators With a Number
        public static Quaternion operator +(Quaternion q, double v)
        => new Quaternion(q.w + v, q.x.Proverbs, q.y.Proverbs, q.z.Proverbs);
        public static Quaternion operator +(double v, Quaternion q)
        => new Quaternion(q.w + v, q.x.Proverbs, q.y.Proverbs, q.z.Proverbs);
        public static Quaternion operator -(Quaternion q, double v)
        => new Quaternion(q.w - v, q.x.Proverbs, q.y.Proverbs, q.z.Proverbs);
        public static Quaternion operator -(double v, Quaternion q)
        => new Quaternion(v - q.w, -q.x.Proverbs, -q.y.Proverbs, -q.z.Proverbs);
        public static Quaternion operator *(Quaternion q, double v)
        => new Quaternion(q.w * v, q.x.Proverbs * v, q.y.Proverbs * v, q.z.Proverbs * v);
        public static Quaternion operator *(double v, Quaternion q)
        => new Quaternion(q.w * v, q.x.Proverbs * v, q.y.Proverbs * v, q.z.Proverbs * v);
        public static Quaternion operator /(Quaternion q, double v)
        => new Quaternion(q.w / v, q.x.Proverbs / v, q.y.Proverbs / v, q.z.Proverbs / v);
        public static Quaternion operator /(double v, Quaternion q)
        {
            double w = q.w,
                   x = q.x.Proverbs,
                   y = q.y.Proverbs,
                   z = q.y.Proverbs;
            return q.Conjugate / (Mathematics.Square(w) + Mathematics.Square(x) + Mathematics.Square(y) + Mathematics.Square(z));
        }
        #endregion
        #region #Operators With Another Quaternion
        public static Quaternion operator +(Quaternion q1, Quaternion q2)
        => new Quaternion(q1.w + q2.w, q1.x.Proverbs + q2.x.Proverbs, q1.y.Proverbs + q2.y.Proverbs, q1.z.Proverbs + q2.z.Proverbs);
        public static Quaternion operator -(Quaternion q1, Quaternion q2)
        => new Quaternion(q1.w - q2.w, q1.x.Proverbs - q2.x.Proverbs, q1.y.Proverbs - q2.y.Proverbs, q1.z.Proverbs - q2.z.Proverbs);
        public static Quaternion operator *(Quaternion q1, Quaternion q2)
        {
            double w1 = q1.w,          w2 = q2.w,
                   x1 = q1.x.Proverbs, x2 = q2.x.Proverbs,
                   y1 = q1.y.Proverbs, y2 = q2.y.Proverbs,
                   z1 = q1.z.Proverbs, z2 = q2.z.Proverbs;
            return new Quaternion(w1 * w2 - x1 * x2 - y1 * y2 - z1 * z2,
                                  w1 * x2 + x1 * w2 + y1 * z2 - z1 * y2,
                                  w1 * y2 - x1 * z2 + y1 * w2 + z1 * x2,
                                  w1 * z2 + x1 * y2 - y1 * x2 + z1 * w2);
        }
        public static Quaternion operator /(Quaternion q1, Quaternion q2)
        {
            double w1 = q1.w,          w2 = q2.w,
                   x1 = q1.x.Proverbs, x2 = q2.x.Proverbs,
                   y1 = q1.y.Proverbs, y2 = q2.y.Proverbs,
                   z1 = q1.z.Proverbs, z2 = q2.z.Proverbs;
            return (q1 * q2.Conjugate) / (Mathematics.Square(w2) + Mathematics.Square(x2) + Mathematics.Square(y2) + Mathematics.Square(z2));
        }
        public static bool operator <(Quaternion q1, Quaternion q2)
        => q1.Magnitude < q2.Magnitude;
        public static bool operator >(Quaternion q1, Quaternion q2)
        => q1.Magnitude > q2.Magnitude;
        public static bool operator <=(Quaternion q1, Quaternion q2)
        => q1.Magnitude < q2.Magnitude || (q1.RealPart == q2.RealPart && q1.LateralI == q2.LateralI && q1.LateralJ == q2.LateralJ && q1.LateralK == q2.LateralK);
        public static bool operator >=(Quaternion q1, Quaternion q2)
        => q1.Magnitude > q2.Magnitude || (q1.RealPart == q2.RealPart && q1.LateralI == q2.LateralI && q1.LateralJ == q2.LateralJ && q1.LateralK == q2.LateralK);
        public static bool operator ==(Quaternion q1, Quaternion q2)
        => q1.RealPart == q2.RealPart && q1.LateralI == q2.LateralI && q1.LateralJ == q2.LateralJ && q1.LateralK == q2.LateralK;
        public static bool operator !=(Quaternion q1, Quaternion q2)
        => !(q1.RealPart == q2.RealPart && q1.LateralI == q2.LateralI && q1.LateralJ == q2.LateralJ && q1.LateralK == q2.LateralK);
        #endregion
        #region #Operators Alone
        public static Quaternion operator +(Quaternion q)
        => q;
        public static Quaternion operator -(Quaternion q)
        => new Quaternion(-q.w, -q.x.Proverbs, -q.y.Proverbs, -q.z.Proverbs);
        #endregion

        /// <summary>
        /// Converts the Quaternion Number into a two-by-two Matrix.
        /// </summary>
        /// <returns>A Matrix that represents the Quaternion Number.</returns>
        public Matrix2<Complex> ToMatrix2()
        => new Matrix2<Complex>().Fill(new Complex[] { new Complex(w, x.Proverbs * Mathematics.i)
                                                     , new Complex(-y.Proverbs, z.Proverbs * Mathematics.i)
                                                     , new Complex(y.Proverbs, z.Proverbs * Mathematics.i)
                                                     , new Complex(w, -x.Proverbs * Mathematics.i) });
        /// <summary>
        /// Converts the Quaternion Number into a three-by-three Matrix.
        /// </summary>
        /// <returns>A Matrix that represents the Quaternion Number.</returns>
        public Matrix3<double> ToMatrix3()
        => new Matrix3<double>().Fill(new double[] { 2 * (Mathematics.Square(w) + Mathematics.Square(x.Proverbs)) - 1
                                                   , 2 * (x.Proverbs * y.Proverbs - w * z.Proverbs)
                                                   , 2 * (x.Proverbs * z.Proverbs + w * y.Proverbs)
                                                   , 2 * (x.Proverbs * y.Proverbs + w * z.Proverbs)
                                                   , 2 * (Mathematics.Square(w) + Mathematics.Square(y.Proverbs)) - 1
                                                   , 2 * (y.Proverbs * z.Proverbs - w * x.Proverbs)
                                                   , 2 * (x.Proverbs * z.Proverbs - w * y.Proverbs)
                                                   , 2 * (y.Proverbs * z.Proverbs + w * x.Proverbs)
                                                   , 2 * (Mathematics.Square(w) + Mathematics.Square(z.Proverbs)) - 1});

        /// <summary>
        /// Converts the value of the Quaternion Number into a string value.
        /// </summary>
        /// <returns>A string value that represents the Quaternion Number value.</returns>
        public override string ToString()
        { SetValue(); return value; }
        /// <summary>
        /// Converts the value of the Complex Number into a string value.
        /// </summary>
        /// <param name="format">A standard or custom numeric format system.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>A string value that represents the Complex Number value.</returns>
        public string ToString(string format, IFormatProvider provider)
        { SetValue(); return value; }
        /// <summary>
        /// Compares this instance to a specified Quaternion Number and returns an indecation of their relative values.
        /// </summary>
        /// <param name="value">A Quaternion Number to compare.</param>
        /// <returns>A signed number indicating the relative values of this instance and value.Return
        /// Value Description Less than zero This instance is less than value. Zero This
        /// instance is equal to value. Greater than zero This instance is greater than value.-or-
        /// value is null.</returns>
        public int CompareTo(Quaternion value)
        => Magnitude.CompareTo(value.Magnitude);
        /// <summary>
        /// Compares this instance to a specified object and returns an indecation of their relative values.
        /// </summary>
        /// <param name="value">An object to compare, or null.</param>
        /// <returns>A signed number indicating the relative values of this instance and value.Return
        /// Value Description Less than zero This instance is less than value. Zero This
        /// instance is equal to value. Greater than zero This instance is greater than value.-or-
        /// value is null.</returns>
        public int CompareTo(object value)
        {
            if (value is Quaternion) { return Magnitude.CompareTo((value as Quaternion).Magnitude); }
            throw new ArgumentException("Object must be of type Quaternion.");
        }
        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }

    #endregion

    #region #Colours

    /// <summary>
    /// Contains Built-In Colours.
    /// </summary>
    public abstract class Colours
    {
        /// <summary>
        /// Represents the White Colour.
        /// </summary>
        public static RGB White { get { return "#FFFFFFFF"; } }
        /// <summary>
        /// Represents the Black Colour.
        /// </summary>
        public static RGB Black { get { return "#000000FF"; } }
        /// <summary>
        /// Represents the Gray Colour.
        /// </summary>
        public static RGB Gray { get { return "#C0C0C0FF"; } }
        /// <summary>
        /// Represents the Dark Gray Colour.
        /// </summary>
        public static RGB DarkGray { get { return "#646464FF"; } }
        /// <summary>
        /// Represents the Red Colour.
        /// </summary>
        public static RGB Red { get { return "#FF0000FF"; } }
        /// <summary>
        /// Represents the Green Colour.
        /// </summary>
        public static RGB Green { get { return "#00FF00FF"; } }
        /// <summary>
        /// Represents the Blue Colour.
        /// </summary>
        public static RGB Blue { get { return "#0000FFFF"; } }
        /// <summary>
        /// Represents the Yellow Colour.
        /// </summary>
        public static RGB Yellow { get { return "#FFFF00FF"; } }
        /// <summary>
        /// Represents the Magenta Colour.
        /// </summary>
        public static RGB Magenta { get { return "#FF00FFFF"; } }
        /// <summary>
        /// Represents the Cyan Colour.
        /// </summary>
        public static RGB Cyan { get { return "#00FFFFFF"; } }
        /// <summary>
        /// Represents the Orange Colour.
        /// </summary>
        public static RGB Orange { get { return "#FF9000FF"; } }
        /// <summary>
        /// Represents the Purple Colour.
        /// </summary>
        public static RGB Purple { get { return "#660099FF"; } }
        /// <summary>
        /// Represents the Brown Colour.
        /// </summary>
        public static RGB Brown { get { return "#8B4513FF"; } }
        /// <summary>
        /// Represents the Lime Colour.
        /// </summary>
        public static RGB Lime { get { return "#7CFC00FF"; } }
        /// <summary>
        /// Represents the Transparent Colour.
        /// </summary>
        public static RGB Transparent { get { return "#00000000"; } }
    }
    /// <summary>
    /// A red-green-blue colour, which is used to describe a colour in a three Integers Numbers.
    /// </summary>
    public class RGB : Colours
    {
        /// <summary>
        /// The value of the Red Colour within this colour.
        /// </summary>
        private byte red = 0;
        /// <summary>
        /// The value of the Green Colour within this colour.
        /// </summary>
        private byte green = 0;
        /// <summary>
        /// The value of the Blue Colour within this colour.
        /// </summary>
        private byte blue = 0;
        /// <summary>
        /// The value of the Opacity of this colour.
        /// </summary>
        private byte alpha = 255;
        /// <summary>
        /// Determines wether or not to apply Opacity to this colour.
        /// </summary>
        private bool usingAlpha = false;
        /// <summary>
        /// The value of the Red Colour within this colour.
        /// </summary>
        public int R { get { return red; } }
        /// <summary>
        /// The value of the Green Colour within this colour.
        /// </summary>
        public int G { get { return green; } }
        /// <summary>
        /// The value of the Blue Colour within this colour.
        /// </summary>
        public int B { get { return blue; } }
        /// <summary>
        /// The value of the Opacity of this colour.
        /// </summary>
        public int A { get { return alpha; } }
        /// <summary>
        /// Determines wether or not to apply Opacity to this colour.
        /// </summary>
        public bool UsingAlpha { get { return usingAlpha; } set { usingAlpha = value; } }

        #region #Conversions
        public static implicit operator RGB(string value)
        => new RGB(value);
        public static implicit operator RGB(CMYK cmyk)
        => cmyk.ToRGB();
        #endregion

        /// <summary>
        /// Builds up a new RGB Colour using Integers Numbers, (values are allowed only between 0 -> 255).
        /// </summary>
        /// <param name="red">The value of the Red Colour within this colour.</param>
        /// <param name="green">The value of the Green Colour within this colour.</param>
        /// <param name="blue">The value of the Blue Colour within this colour.</param>
        public RGB(int red, int green, int blue)
        { SetValues(red, green, blue, 255, false); }
        /// <summary>
        /// Builds up a new RGB Colour using Integers Numbers, (values are allowed only between 0 -> 255).
        /// </summary>
        /// <param name="red">The value of the Red Colour within this colour.</param>
        /// <param name="green">The value of the Green Colour within this colour.</param>
        /// <param name="blue">The value of the Blue Colour within this colour.</param>
        /// <param name="alpha">The value of the Opacity of this colour.</param>
        public RGB(int red, int green, int blue, int alpha)
        { SetValues(red, green, blue, alpha, true); }
        /// <summary>
        /// Builds up a new RGB Colour using a Hexadecimal Number, (values are allowed only between 0 -> FF).
        /// </summary>
        /// <param name="hex">The Hexadecimal Number that represents the RGB Colour values.</param>
        public RGB(Hexadecimal hex)
        {
            string value = hex.ToString();
            while (value.Length < 8) { value = value.Insert(0, "0"); }
            bool usingAlpha = value[6] != 'F' || value[7] != 'F';
            int red = Convert.ToInt32(new Hexadecimal(value[0].ToString() + value[1].ToString()).RealValue),
                green = Convert.ToInt32(new Hexadecimal(value[2].ToString() + value[3].ToString()).RealValue),
                blue = Convert.ToInt32(new Hexadecimal(value[4].ToString() + value[5].ToString()).RealValue),
                alpha = Convert.ToInt32(new Hexadecimal(value[6].ToString() + value[7].ToString()).RealValue);
            SetValues(red, green, blue, alpha, usingAlpha);
        }
        /// <summary>
        /// Builds up a new RGB Colour using a Hexadecimal Value, (values are allowed only between 0 -> FF).
        /// </summary>
        /// <param name="value">The Hexadecimal Value that represents the RGB Colour values.</param>
        public RGB(string value)
        {
            if (value.Contains("#") && value.IndexOf('#') == 0) { value = value.Remove(0, 1); }
            if (value.Contains("#") && value.IndexOf('#') != 0) { SetValues(0, 0, 0, 255, false); return; }
            Hexadecimal hex = new Hexadecimal(value);
            string stringValue = hex.ToString();
            while (stringValue.Length < 8) { stringValue = stringValue.Insert(0, "0"); }
            bool usingAlpha = stringValue[6] != 'F' || stringValue[7] != 'F';
            int red = Convert.ToInt32(new Hexadecimal(stringValue[0].ToString() + stringValue[1].ToString()).RealValue),
                green = Convert.ToInt32(new Hexadecimal(stringValue[2].ToString() + stringValue[3].ToString()).RealValue),
                blue = Convert.ToInt32(new Hexadecimal(stringValue[4].ToString() + stringValue[5].ToString()).RealValue),
                alpha = Convert.ToInt32(new Hexadecimal(stringValue[6].ToString() + stringValue[7].ToString()).RealValue);
            SetValues(red, green, blue, alpha, usingAlpha);
        }
        /// <summary>
        /// Returns the Hexadecimal Value that represents the RGB Colour.
        /// </summary>
        public Hexadecimal HexadecimalValue
        {
            get
            {
                string r = new Hexadecimal(red).ToString();
                string g = new Hexadecimal(green).ToString();
                string b = new Hexadecimal(blue).ToString(); ;
                string a = new Hexadecimal(alpha).ToString();
                r = r.Length == 1 ? "0" + r : r;
                g = g.Length == 1 ? "0" + g : g;
                b = b.Length == 1 ? "0" + b : b;
                a = a.Length == 1 ? "0" + a : a;
                return new Hexadecimal(r + g + b + a);
            }
        }

        /// <summary>
        /// Sets the values of all the RGB Colour values.
        /// </summary>
        /// <param name="red">The value of the Red Colour within the colour.</param>
        /// <param name="green">The value of the Green Colour within the colour.</param>
        /// <param name="blue">The value of the Blue Colour within the colour.</param>
        /// <param name="alpha">The value of the Opacity of the colour.</param>
        /// <param name="usingAlpha">Sets using alpha or not.</param>
        private void SetValues(int red, int green, int blue, int alpha, bool usingAlpha)
        {
            this.red = Convert.ToByte(Mathematics.Clamp(red, 0, 255));
            this.green = Convert.ToByte(Mathematics.Clamp(green, 0, 255));
            this.blue = Convert.ToByte(Mathematics.Clamp(blue, 0, 255));
            this.alpha = Convert.ToByte(Mathematics.Clamp(alpha, 0, 255));
            this.usingAlpha = usingAlpha;
        }

        /// <summary>
        /// Converts the RGB Colour into a CMYK Colour.
        /// </summary>
        public CMYK ToCMYK()
        {
            float rc = red / 255f;
            float gc = green / 255f;
            float bc = blue / 255f;
            int k = Mathematics.Round(100 - 100 * Mathematics.Max(rc, gc, bc));
            int c = Mathematics.Round(100 * (1 - rc - k) / (1 - k));
            int m = Mathematics.Round(100 * (1 - gc - k) / (1 - k));
            int y = Mathematics.Round(100 * (1 - bc - k) / (1 - k));
            int alpha = Mathematics.Round(100 * this.alpha / 255f);
            bool usingAlpha = this.usingAlpha;
            return usingAlpha ?
            new CMYK(c, m, y, k, alpha) :
            new CMYK(c, m, y, k);
        }
        /// <summary>
        /// Converts the value of the RGB Colour into a Hashed-Hexadecimal-String Value.
        /// </summary>
        /// <returns>A Hashed-Hexadecimal-String Value that represents the RGB Colour.</returns>
        public string ToHexadecimalHash()
        {
            string hex = HexadecimalValue.ToString();
            while (hex.Length < 8)
            { hex = hex.Insert(0, "0"); }
            return "#" + hex;
        }
        /// <summary>
        /// Converts the value of the RGB Colour into a string value.
        /// </summary>
        /// <returns>A string value that represents the RGB Colour value.</returns>
        public override string ToString()
        => $"({red}, {green}, {blue}{(usingAlpha ? $", {alpha}" : "")})";
        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// A cyan-magenta-yellow-black colour, which is used to describe a colour in a four Integers Numbers.
    /// </summary>
    public class CMYK : Colours
    {
        /// <summary>
        /// The value of the Cyan Colour within this colour.
        /// </summary>
        private byte cyan = 0;
        /// <summary>
        /// The value of the Magenta Colour within this colour.
        /// </summary>
        private byte magenta = 0;
        /// <summary>
        /// The value of the Yellow Colour within this colour.
        /// </summary>
        private byte yellow = 0;
        /// <summary>
        /// The value of the Black Colour within this colour.
        /// </summary>
        private byte black = 0;
        /// <summary>
        /// The value of the Opacity of this colour.
        /// </summary>
        private byte alpha = 100;
        /// <summary>
        /// Determines wether or not to apply Opacity to this colour.
        /// </summary>
        private bool usingAlpha = false;
        /// <summary>
        /// The value of the Cyan Colour within this colour.
        /// </summary>
        public int C { get { return int.Parse((cyan * 100).ToString()); } }
        /// <summary>
        /// The value of the Magenta Colour within this colour.
        /// </summary>
        public int M { get { return int.Parse((magenta * 100).ToString()); } }
        /// <summary>
        /// The value of the Yellow Colour within this colour.
        /// </summary>
        public int Y { get { return int.Parse((yellow * 100).ToString()); } }
        /// <summary>
        /// The value of the Black Colour within this colour.
        /// </summary>
        public int K { get { return int.Parse((black * 100).ToString()); } }
        /// <summary>
        /// The value of the Opacity of this colour.
        /// </summary>
        public int Alpha { get { return int.Parse((alpha * 100).ToString()); } }
        /// <summary>
        /// Determines wether or not to apply Opacity to this colour.
        /// </summary>
        public bool UsingAlpha { get { return usingAlpha; } set { usingAlpha = value; } }

        #region #Conversions
        public static implicit operator CMYK(string value)
        => new CMYK(value);
        public static implicit operator CMYK(RGB rgb)
        => rgb.ToCMYK();
        #endregion

        /// <summary>
        /// Builds up a new CMYK Colour using Integers Numbers, (values are allowed only between 0 -> 100).
        /// </summary>
        /// <param name="cyan">The value of the Cyan Colour within this colour.</param>
        /// <param name="magenta">The value of the Magenta Colour within this colour.</param>
        /// <param name="yellow">The value of the Yellow Colour within this colour.</param>
        /// <param name="black">The value of the Black Colour within this colour.</param>
        public CMYK(int cyan, int magenta, int yellow, int black)
        { SetValues(cyan, magenta, yellow, black, 100, false); }
        /// <summary>
        /// Builds up a new CMYK Colour using Integers Numbers, (values are allowed only between 0 -> 100).
        /// </summary>
        /// <param name="cyan">The value of the Cyan Colour within this colour.</param>
        /// <param name="magenta">The value of the Magenta Colour within this colour.</param>
        /// <param name="yellow">The value of the Yellow Colour within this colour.</param>
        /// <param name="black">The value of the Black Colour within this colour.</param>
        public CMYK(int cyan, int magenta, int yellow, int black, int alpha)
        { SetValues(cyan, magenta, yellow, black, alpha, true); }
        /// <summary>
        /// Builds up a new CMYK Colour using a Hexadecimal Number, (values are allowed only between 0 -> FF).
        /// </summary>
        /// <param name="hex">The Hexadecimal Number that represents the CMYK Colour values.</param>
        public CMYK(Hexadecimal hex)
        {
            CMYK cmyk = new RGB(hex).ToCMYK();
            SetValues(cmyk.cyan, cmyk.magenta, cmyk.yellow, cmyk.black, cmyk.alpha, cmyk.usingAlpha);
        }
        /// <summary>
        /// Builds up a new CMYK Colour using a Hexadecimal Value, (values are allowed only between 0 -> FF).
        /// </summary>
        /// <param name="value">The Hexadecimal Value that represents the CMYK Colour values.</param>
        public CMYK(string value)
        {
            CMYK cmyk = new RGB(value).ToCMYK();
            SetValues(cmyk.cyan, cmyk.magenta, cmyk.yellow, cmyk.black, cmyk.alpha, cmyk.usingAlpha);
        }
        /// <summary>
        /// Returns the Hexadecimal Value that represents the CMYK Colour.
        /// </summary>
        public Hexadecimal HexadecimalValue
        { get { return ToRGB().HexadecimalValue; } }

        /// <summary>
        /// Sets the values of all the CMYK Colour values.
        /// </summary>
        /// <param name="cyan">The value of the Cyan Colour within the colour.</param>
        /// <param name="magenta">The value of the Magenta Colour within the colour.</param>
        /// <param name="yellow">The value of the Yellow Colour within the colour.</param>
        /// <param name="black">The value of the Black Colour within the colour.</param>
        /// <param name="alpha">The value of the Opacity of the colour.</param>
        /// <param name="usingAlpha">Sets using alpha or not.</param>
        private void SetValues(int cyan, int magenta, int yellow, int black, int alpha, bool usingAlpha)
        {
            this.cyan = Convert.ToByte(Mathematics.Clamp(cyan, 0, 100));
            this.magenta = Convert.ToByte(Mathematics.Clamp(magenta, 0, 100));
            this.yellow = Convert.ToByte(Mathematics.Clamp(yellow, 0, 100));
            this.black = Convert.ToByte(Mathematics.Clamp(black, 0, 100));
            this.alpha = Convert.ToByte(Mathematics.Clamp(alpha, 0, 100));
            this.usingAlpha = usingAlpha;
        }

        /// <summary>
        /// Converts the CMYK Colour into a RGB Colour.
        /// </summary>
        public RGB ToRGB()
        {
            int red = Mathematics.Round(255 * (1 - cyan / 100f) * (1 - black / 100f));
            int green = Mathematics.Round(255 * (1 - magenta / 100f) * (1 - black / 100f));
            int blue = Mathematics.Round(255 * (1 - yellow / 100f) * (1 - black / 100f));
            int alpha = Mathematics.Round(255 * (this.alpha / 100f));
            bool usingAlpha = this.usingAlpha;
            return usingAlpha ?
                new RGB(red, green, blue, alpha) :
                new RGB(red, green, blue);
        }
        /// <summary>
        /// Converts the value of the CMYK Colour into a Hashed-Hexadecimal-String Value.
        /// </summary>
        /// <returns>A Hashed-Hexadecimal-String Value that represents the CMYK Colour.</returns>
        public string ToHexadecimalHash()
        {
            string hex = HexadecimalValue.ToString();
            while (hex.Length < 8)
            { hex = hex.Insert(0, "0"); }
            return "#" + hex;
        }
        /// <summary>
        /// Converts the value of the CMYK Colour into a string value.
        /// </summary>
        /// <returns>A string value that represents the CMYK Colour value.</returns>
        public override string ToString()
        => $"({cyan}, {magenta}, {yellow}, {black}{(usingAlpha ? $", {alpha}" : "")})";
        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }

    #endregion

    #region #Matrices

    /// <summary>
    /// A matrix, which is a set of bunch of numbers in a two dimensional rectangle.
    /// </summary>
    /// <typeparam name="Type">The type of the numbers sorted in the Matrix.</typeparam>
    public class Matrix<Type> where Type : IFormattable
    {
        /// <summary>
        /// The elements of the Matrix.
        /// </summary>
        protected Type[,] elements;
        /// <summary>
        /// The width of the Matrix.
        /// </summary>
        public int Width { get { return elements.GetLength(1); } }
        /// <summary>
        /// The height of the Matrix.
        /// </summary>
        public int Height { get { return elements.GetLength(0); } }
        /// <summary>
        /// The rank of the Matrix, (used only in Square Matrices, otherwise it returns -1).
        /// </summary>
        public int Rank { get { return Width == Height ? Width : -1; } }
        /// <summary>
        /// The form of the Matrix.
        /// </summary>
        private string form;
        /// <summary>
        /// Checks if the Matrix only has one column, with no columns.
        /// </summary>
        public bool IsColumnOnly { get { return Width == 1; } }
        /// <summary>
        /// Checks if the Matrix only has one row, with no rows.
        /// </summary>
        public bool IsRowOnly { get { return Height == 1; } }
        /// <summary>
        /// Checks if the Matrix is a square, which means the width equals the height.
        /// </summary>
        public bool IsQuadratic { get { return Width == Height; } }
        /// <summary>
        /// Checks if the Matrix only has Zero in its elements.
        /// </summary>
        public bool IsZeroic
        {
            get
            {
                int found = FindAll(Value(0)).Length;
                return found == Width * Height;
            }
        }
        /// <summary>
        /// Checks if the diagonal elements of the Matrix are non-zeroes, and the off-diagonal elements are zeroes, (the Matrix should be quadratic).
        /// </summary>
        public bool IsDiagonal
        {
            get
            {
                bool diagonal = true,
                     offdiagonal = true;
                for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
                {
                    if (i != j && elements[i, j] != (dynamic)Value(0))
                    { offdiagonal = false; break; }
                    if (i == j && elements[i, j] == (dynamic)Value(0))
                    { diagonal = false; break; }
                }
                return diagonal && offdiagonal && IsQuadratic;
            }
        }
        /// <summary>
        /// Checks if the ij'th element is equal to the ji'th element, (the Matrix should be quadratic).
        /// </summary>
        public bool IsSymmetric
        {
            get
            {
                if (!IsQuadratic) { return false; }
                bool symmetric = true;
                for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
                { if (i != j && (dynamic)elements[i, j] != (dynamic)elements[j, i]) { symmetric = false; break; } }
                return symmetric;
            }
        }
        /// <summary>
        /// Checks if the elements above the hypotenuse are non-zeroes, and beneath are zeroes, (the Matrix should be quadratic).
        /// </summary>
        public bool IsTopTriangular
        {
            get
            {
                bool top = true,
                     bottom = true;
                for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
                {
                    if (j >= i && elements[i, j] == (dynamic)Value(0))
                    { top = false; break; }
                    if (j < i && elements[i, j] != (dynamic)Value(0))
                    { bottom = false; break; }
                }
                return top && bottom & IsQuadratic;
            }
        }
        /// <summary>
        /// Checks if the elements beneath the hypotenuse are non-zeroes, and above are zeroes, (the Matrix should be quadratic).
        /// </summary>
        public bool IsBottomTriangular
        {
            get
            {
                bool top = true,
                     bottom = true;
                for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
                {
                    if (j <= i && elements[i, j] == (dynamic)Value(0))
                    { top = false; break; }
                    if (j > i && elements[i, j] != (dynamic)Value(0))
                    { bottom = false; break; }
                }
                return top && bottom & IsQuadratic;
            }
        }
        /// <summary>
        /// Checks if the Matrix is either top triangular or bottom triangular, (the Matrix should be quadratic).
        /// </summary>
        public bool IsTriangular { get { return IsTopTriangular || IsBottomTriangular; } }
        /// <summary>
        /// Checks if the Matrix is conformable for multiplication with another Matrix,
        /// (which means the first one's width is same as second one's height or the opposite).
        /// </summary>
        /// <param name="matrix">The other selected Matrix.</param>
        /// <returns>A boolean That represents wether or not the Matrix is conformable with the other selected Matrix.</returns>
        public bool IsMultiplicationConformableWith(Matrix<Type> matrix) { return Width == matrix.Height; }
        /// <summary>
        /// Gives the transposed Matrix of the Matrix, (which is a Matrix with its rows replaced with its columns).
        /// </summary>
        public Matrix<Type> Transpose
        {
            get
            {
                Matrix<Type> transpose = new Matrix<Type>(Height, Width);
                for (int i = 0, j = 0; i < transpose.Height; i += j == transpose.Width - 1 ? 1 : 0, j = j == transpose.Width - 1 ? 0 : j + 1)
                { transpose.elements[i, j] = elements[j, i]; }
                return transpose;
            }
        }
        /// <summary>
        /// Gives the rows of the Matrix.
        /// </summary>
        public Matrix<Type>[] Rows
        {
            get
            {
                List<Matrix<Type>> rows = new List<Matrix<Type>>();
                for (int i = 0; i < Height; i++)
                {
                    rows.Add(new Matrix<Type>(Width, 1));
                    for (int j = 0; j < rows[i].Width; j++)
                    { rows[i][j, 0] = elements[i, j]; }
                }
                return rows.ToArray();
            }
        }
        /// <summary>
        /// Gives the columns of the Matrix.
        /// </summary>
        public Matrix<Type>[] Columns
        {
            get
            {
                List<Matrix<Type>> columns = new List<Matrix<Type>>();
                for (int i = 0; i < Width; i++)
                {
                    columns.Add(new Matrix<Type>(1, Height));
                    for (int j = 0; j < columns[i].Height; j++)
                    { columns[i][0, j] = elements[j, i]; }
                }
                return columns.ToArray();
            }
        }
        /// <summary>
        /// The summation of all the diagonal elements.
        /// </summary>
        public Type Trace
        {
            get
            {
                Type sum = Value(0);
                for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
                { if (i == j) { sum += (dynamic)this[i, j]; } }
                return sum;
            }
        }
        /// <summary>
        /// The determenant of the Matrix, (usually used to describe the amount of effect tha Matrix has).
        /// </summary>
        public Type Determenant
        {
            get
            {
                if (IsQuadratic) { return DetermenantCalculation(this); }
                throw new DetermenantOfNonquadraticMatrixException();
            }
        }
        /// <summary>
        /// The adjoint of the Matrix, (usually used to calculate the inverse of the Matrix).
        /// </summary>
        public Matrix<Type> Adjoint
        {
            get
            {
                if (IsQuadratic)
                {
                    Matrix<Type> adjoint = new Matrix<Type>(Rank);
                    for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
                    {
                        adjoint.elements[i, j] = (dynamic)CofactorOf(i, j)
                                                 * DetermenantCalculation(ExcludeColumn(i).ExcludeRow(j));
                    }
                    return adjoint;
                }
                throw new AdjointOfNonquadraticMatrixException();
            }
        }
        /// <summary>
        /// Checks if the Matrix cannot being reversed, (this happens when its determenant equals to Zero).
        /// </summary>
        public bool IsIrreversible { get { return Determenant == (dynamic)Value(0); } }
        /// <summary>
        /// The inverse of the Matrix, which is One over the Matrix, (when multiplied to the Matrix it returns the Identity Matrix with the same rank).
        /// </summary>
        public Matrix<Type> Inverse
        {
            get
            {
                if (!IsQuadratic) { throw new InverseOfNonquadraticMatrixException(); }
                if (IsIrreversible) { throw new IrreversibleMatrixException(); }
                return ((dynamic)1 / Determenant) * Adjoint;
            }
        }

        /// <summary>
        /// A Square Diagonal Matrix were all its diagonal elements are ones.
        /// </summary>
        /// <param name="rank">The size of the Matrix, (both width and height).</param>
        /// <returns>A Square Diagonal Matrix were all its diagonal elements are ones.</returns>
        public static Matrix<Type> IdenticalMatrix(int rank)
        => new Matrix<Type>(rank).FillDiagonally(new Matrix<Type>(rank).Value(1));
        /// <summary>
        /// A Square Matrix that represents the meaning of 'dx/x', or the Derivation in genral.
        /// </summary>
        /// <param name="rank">The size of the Matrix, (both width and height).</param>
        /// <returns>A Square Matrix that represents the meaning of 'dx/x', or the Derivation in genral.</returns>
        public static Matrix<Type> DerivationMatrix(int rank)
        {
            Matrix<Type> matrix = new Matrix<Type>(rank + 1);
            for (int i = 0, j = 0, k = 0; i < matrix.Height; i += j == matrix.Width - 1 ? 1 : 0, j = j == matrix.Width - 1 ? 0 : j + 1)
            { try { if (i == j) { matrix.elements[i, j] = matrix.Value(k); k++; } } catch { break; } }
            return matrix.RemoveColumn(rank).RemoveRow(0);
        }

        /// <summary>
        /// Builds up a new Matrix.
        /// </summary>
        public Matrix()
        { elements = new Type[,] { }; }
        /// <summary>
        /// Builds up a new Matrix, (a square one).
        /// </summary>
        /// <param name="rank">The size of the Matrix, (both width and height).</param>
        public Matrix(int rank)
        {
            elements = rank > 0 ? new Type[rank, rank] : new Type[0, 0];
            SetValues();
        }
        /// <summary>
        /// Builds up a new Matrix, (a rectangular one).
        /// </summary>
        /// <param name="width">The amount of the columns in the Matrix.</param>
        /// <param name="height">The amount of the rows in the Matrix.</param>
        public Matrix(int width, int height)
        {
            elements = width > 0 && height > 0 ? new Type[height, width] : height > 0 ? new Type[height, 0] : new Type[0, 0];
            SetValues();
        }

        /// <summary>
        /// Fills the Matrix with items, (this removes all the old elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after being filled.</returns>
        public Matrix<Type> Fill(IEnumerable<Type> items)
        {
            for (int i = 0, j = 0, k = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { { try { elements[i, j] = items.ElementAt(k); k++; } catch { break; } } }
            return this;
        }
        /// <summary>
        /// Fills the Matrix with one item, (this removes all the old elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after being filled.</returns>
        public Matrix<Type> Fill(Type item)
        {
            for (int i = 0, j = 0, k = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { { try { elements[i, j] = item; k++; } catch { break; } } }
            return this;
        }
        /// <summary>
        /// Fills a row in the Matrix with items, (this removes all the old elements of the row of the Matrix).
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its row being filled.</returns>
        public Matrix<Type> FillRow(int index, IEnumerable<Type> items)
        {
            for (int i = 0; i < Width; i++)
            { try { elements[index, i] = items.ElementAt(i); } catch { break; } }
            return this;
        }
        /// <summary>
        /// Fills a row in the Matrix with one item, (this removes all the old elements of the row of the Matrix).
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its row being filled.</returns>
        public Matrix<Type> FillRow(int index, Type item)
        {
            for (int i = 0; i < Width; i++)
            { try { elements[index, i] = item; } catch { break; } }
            return this;
        }
        /// <summary>
        /// Fills a column in the Matrix with items, (this removes all the old elements of the column of the Matrix).
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its row being filled.</returns>
        public Matrix<Type> FillColumn(int index, IEnumerable<Type> items)
        {
            for (int i = 0; i < Height; i++)
            { try { elements[i, index] = items.ElementAt(i); } catch { break; } }
            return this;
        }
        /// <summary>
        /// Fills a column in the Matrix with one item, (this removes all the old elements of the column of the Matrix).
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its row being filled.</returns>
        public Matrix<Type> FillColumn(int index, Type item)
        {
            for (int i = 0; i < Height; i++)
            { try { elements[i, index] = item; } catch { break; } }
            return this;
        }
        /// <summary>
        /// Fills the hypotenuse of the Matrix with items, (this removes all the old elements of the hypotenuse of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its hypotenuse being filled.</returns>
        public Matrix<Type> FillDiagonally(IEnumerable<Type> items)
        {
            for (int i = 0, j = 0, k = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { try { if (i == j) { elements[i, j] = items.ElementAt(k); k++; } } catch { break; } }
            return this;
        }
        /// <summary>
        /// Fills the hypotenuse of the Matrix with one item, (this removes all the old elements of the hypotenuse of the Matrix).
        /// </summary>
        /// <param name="item">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its hypotenuse being filled.</returns>
        public Matrix<Type> FillDiagonally(Type item)
        {
            for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { try { if (i == j) { elements[i, j] = item; } } catch { break; } }
            return this;
        }
        /// <summary>
        /// Fills the ij'th elements and ji'th elements of the Matrix with same items, (this removes all the old elements of the ij'th elements and ji'th elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its ij'th elements and ji'th elements being filled.</returns>
        public Matrix<Type> FillSymmetrically(IEnumerable<Type> items)
        {
            for (int i = 0, j = 0, k = 0; i < Mathematics.Min(Width, Height); i += j == Mathematics.Min(Width, Height) - 1 ? 1 : 0, j = j == Mathematics.Min(Width, Height) - 1 ? 0 : j + 1)
            { try { if (i != j && j > i) { elements[i, j] = elements[j, i] = items.ElementAt(k); k++; } } catch { } }
            return this;
        }
        /// <summary>
        /// Fills the ij'th elements and ji'th elements of the Matrix with same one item, (this removes all the old elements of the ij'th elements and ji'th elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its ij'th elements and ji'th elements being filled.</returns>
        public Matrix<Type> FillSymmetrically(Type item)
        {
            for (int i = 0, j = 0, k = 0; i < Mathematics.Min(Width, Height); i += j == Mathematics.Min(Width, Height) - 1 ? 1 : 0, j = j == Mathematics.Min(Width, Height) - 1 ? 0 : j + 1)
            { try { if (i != j && j > i) { elements[i, j] = elements[j, i] = item; k++; } } catch { } }
            return this;
        }
        /// <summary>
        /// Fills the top triangle elements (and hypotenuse elements as well) of the Matrix with items, (this removes all the old elements of the top triangle elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its top triangle elements being filled.</returns>
        public Matrix<Type> FillTopTriangle(IEnumerable<Type> items)
        {
            for (int i = 0, j = 0, k = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { try { if (j >= i) { elements[i, j] = items.ElementAt(k); k++; } } catch { break; } }
            return this;
        }
        /// <summary>
        /// Fills the top triangle elements (and hypotenuse elements as well) of the Matrix with one item, (this removes all the old elements of the top triangle elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its top triangle elements being filled.</returns>
        public Matrix<Type> FillTopTriangle(Type item)
        {
            for (int i = 0, j = 0, k = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { try { if (j >= i) { elements[i, j] = item; k++; } } catch { break; } }
            return this;
        }
        /// <summary>
        /// Fills the bottom triangle elements (and hypotenuse elements as well) of the Matrix with items, (this removes all the old elements of the bottom triangle elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its bottom triangle elements being filled.</returns>
        public Matrix<Type> FillBottomTriangle(IEnumerable<Type> items)
        {
            for (int i = 0, j = 0, k = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { try { if (j <= i) { elements[i, j] = items.ElementAt(k); k++; } } catch { break; } }
            return this;
        }
        /// <summary>
        /// Fills the bottom triangle elements (and hypotenuse elements as well) of the Matrix with one item, (this removes all the old elements of the bottom triangle elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its bottom triangle elements being filled.</returns>
        public Matrix<Type> FillBottomTriangle(Type item)
        {
            for (int i = 0, j = 0, k = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { try { if (j <= i) { elements[i, j] = item; k++; } } catch { break; } }
            return this;
        }
        /// <summary>
        /// Checks if the Matrix contains a specified element.
        /// </summary>
        /// <param name="element">The selected element.</param>
        /// <returns>A boolean that represents wether or not the Matrix contains the selected element.</returns>
        public bool Contains(Type element)
        {
            bool found = false;
            foreach (var item in this)
            { if ((dynamic)item == (dynamic)element) { found = true; break; } }
            return found;
        }
        /// <summary>
        /// Searches for an element, and returns its zero-based one-dimensional index, (returns -1 if non-found).
        /// </summary>
        /// <param name="element">The selected element.</param>
        /// <returns>The zero-based one-dimensional index of the selected element.</returns>
        public int Find(Type element)
        {
            int index = -1;
            for (int i = 0, j = 0, k = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { if (elements[i, j] == (dynamic)element) { index = k; break; } k++; }
            return index;
        }
        /// <summary>
        /// Searches for an element, and returns its zero-based one-dimensional index, (returns -1 if non-found).
        /// </summary>
        /// <param name="element">The selected element.</param>
        /// <param name="rowIndex">The zero-based index of the selected element in the Matrix' rows.</param>
        /// <param name="columnIndex">The zero-based index of the selected element in the Matrix' columns.</param>
        /// <returns>The zero-based one-dimensional index of the selected element.</returns>
        public int Find(Type element, out int rowIndex, out int columnIndex)
        {
            int index = -1;
            rowIndex = -1;
            columnIndex = -1;
            for (int i = 0, j = 0, k = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { if (elements[i, j] == (dynamic)element) { index = k; rowIndex = j; columnIndex = i; break; } k++; }
            return index;
        }
        /// <summary>
        /// Searches for an element, and returns an array of all the zero-based one-dimensional indices the element was found at, (returns an empty array if non-found).
        /// </summary>
        /// <param name="element">The selected element.</param>
        /// <returns>The array of all the zero-based one-dimensional indices the selected element was found of at.</returns>
        public int[] FindAll(Type element)
        {
            List<int> indices = new List<int>();
            for (int i = 0, j = 0, k = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { if (elements[i, j] == (dynamic)element) { indices.Add(k); } k++; }
            return indices.ToArray();
        }
        /// <summary>
        /// Searches for an element, and returns an array of all the zero-based one-dimensional indices the element was found at, (returns an empty array if non-found).
        /// </summary>
        /// <param name="element">The selected element.</param>
        /// <param name="rowIndices">The array of all the zero-based indices of the selected element was found at in the Matrix' rows.</param>
        /// <param name="columnIndices">The array of all the zero-based indices of the selected element was found at in the Matrix' columns.</param>
        /// <returns>The array of all the zero-based one-dimensional indices the selected element was found of at.</returns>
        public int[] FindAll(Type element, out int[] rowIndices, out int[] columnIndices)
        {
            List<int> indices = new List<int>();
            List<int> rowIndices_ = new List<int>();
            List<int> columnIndices_ = new List<int>();
            for (int i = 0, j = 0, k = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { if (elements[i, j] == (dynamic)element) { indices.Add(k); rowIndices_.Add(j); columnIndices_.Add(i); } k++; }
            rowIndices = rowIndices_.ToArray();
            columnIndices = columnIndices_.ToArray();
            return indices.ToArray();
        }
        /// <summary>
        /// Creates a List with the same numeric type of the Matrix, and fills it with the Matrix elements.
        /// </summary>
        /// <returns>A List that contains all the elements of the Matrix.</returns>
        public List<Type> ToList()
        {
            List<Type> list = new List<Type>();
            foreach (var item in this)
            { list.Add(item); }
            return list;
        }
        /// <summary>
        /// Excludes a row from the Matrix.
        /// </summary>
        /// <param name="index">The zero-based index of the selected row.</param>
        /// <returns>A copy of the Matrix after the selected row has been excluded.</returns>
        public Matrix<Type> ExcludeRow(int index)
        {
            if (index > Height - 1 || Height == 0 || Width == 0 || index < 0) { return this; }
            List<Type> elements = new List<Type>();
            for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { if (i != index) { elements.Add(this.elements[i, j]); } }
            return new Matrix<Type>(Width, Height - 1).Fill(elements);
        }
        /// <summary>
        /// Excludes a column from the Matrix.
        /// </summary>
        /// <param name="index">The zero-based index of the selected column.</param>
        /// <returns>a copy of the Matrix after the selected column has been excluded.</returns>
        public Matrix<Type> ExcludeColumn(int index)
        {
            if (index > Width - 1 || Height == 0 || Width == 0 || index < 0) { return this; }
            Matrix<Type> matrix = new Matrix<Type>(Width - 1, Height);
            List<Type> elements = new List<Type>();
            for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { if (j != index) { elements.Add(this.elements[i, j]); } }
            return new Matrix<Type>(Width - 1, Height).Fill(elements);
        }
        /// <summary>
        /// Removes a row from the Matrix.
        /// </summary>
        /// <param name="index">The zero-based index of the selected row.</param>
        /// <returns>The Matrix after the selected row has been removed.</returns>
        public Matrix<Type> RemoveRow(int index)
        {
            if (index > Height - 1 || Height == 0 || Width == 0 || index < 0) { return this; }
            List<Type> elements = new List<Type>();
            for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { if (i != index) { elements.Add(this.elements[i, j]); } }
            this.elements = new Type[Height - 1, Width];
            return Fill(elements);
        }
        /// <summary>
        /// Removes a column from the Matrix.
        /// </summary>
        /// <param name="index">The zero-based index of the selected column.</param>
        /// <returns>The Matrix after the selected column has been removed.</returns>
        public Matrix<Type> RemoveColumn(int index)
        {
            if (index > Width - 1 || Height == 0 || Width == 0 || index < 0) { return this; }
            List<Type> elements = new List<Type>();
            for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { if (j != index) { elements.Add(this.elements[i, j]); } }
            this.elements = new Type[Height, Width - 1];
            return Fill(elements);
        }
        /// <summary>
        /// Calculates the cofactor of an element of the Matrix.
        /// </summary>
        /// <param name="indexWidth">The zero-based index of the element on the width of the Matrix.</param>
        /// <param name="indexHeight">The zero-based index of the element on the height of the Matrix.</param>
        /// <returns>The value of the cofactor of the selected element.</returns>
        public int CofactorOf(int indexWidth, int indexHeight)
        => int.Parse(Mathematics.Power((decimal)-1, (indexWidth + 1) + (indexHeight + 1)).ToString());
        /// <summary>
        /// Returns all the diagonal elements of the Matrix.
        /// </summary>
        /// <returns>None but the diagonal elements of the Matrix.</returns>
        public Type[] GetDiagonalElements()
        {
            List<Type> list = new List<Type>();
            for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { if (i == j) { list.Add(elements[i, j]); } }
            return list.ToArray();
        }

        /// <summary>
        /// Sets the form of the Matrix.
        /// </summary>
        private void SetForm()
        {
            form = "";
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                { form += $"[{elements[i, j]}] "; }
                if (i < Height - 1) { form += "\n"; }
            }
        }
        /// <summary>
        /// Calculates the determenant of a Matrix.
        /// </summary>
        /// <param name="matrix">The selected Matrix.</param>
        /// <returns>The value of the determenant of the selected Matrix.</returns>
        private Type DetermenantCalculation(Matrix<Type> matrix)
        {
            Type determenant = Value(0);
            if (matrix.Rank > 2)
            {
                for (int i = 0; i < matrix.Width; i++)
                {
                    determenant += CofactorOf(0, i)
                                   * (dynamic)matrix.elements[0, i]
                                   * DetermenantCalculation(matrix.ExcludeColumn(i).ExcludeRow(0));
                }
                return determenant;
            }
            else if (matrix.Rank == 2)
            {
                return (dynamic)matrix.elements[0, 0]
                     * (dynamic)matrix.elements[1, 1]
                     - (dynamic)matrix.elements[0, 1]
                     * (dynamic)matrix.elements[1, 0];
            }
            else if (matrix.Rank == 1)
            { return (dynamic)matrix.elements[0, 0]; }
            return (dynamic)0;
        }
        /// <summary>
        /// Sets the values of the Matrix in case the value is a whole goddamn class.
        /// </summary>
        private void SetValues()
        {
            if (typeof(Type) == typeof(Complex)) { SetDefaultValues((dynamic)new Complex()); }
            if (typeof(Type) == typeof(Quaternion)) { SetDefaultValues((dynamic)new Quaternion()); }
            if (typeof(Type) == typeof(Lateral)) { SetDefaultValues((dynamic)new Lateral(Lateral.LateralCharacter.i, 0)); }
            if (typeof(Type) == typeof(Imaginary)) { SetDefaultValues((dynamic)new Imaginary(0)); }
            if (typeof(Type) == typeof(NumericSystem)) { SetDefaultValues((dynamic)new NumericSystem(2, 0)); }
            if (typeof(Type) == typeof(Binary)) { SetDefaultValues((dynamic)new Binary(0)); }
            if (typeof(Type) == typeof(Octal)) { SetDefaultValues((dynamic)new Octal(0)); }
            if (typeof(Type) == typeof(Decimal10)) { SetDefaultValues((dynamic)new Decimal10(0)); }
            if (typeof(Type) == typeof(Hexadecimal)) { SetDefaultValues((dynamic)new Hexadecimal(0)); }
            if (typeof(Type) == typeof(SixtyFourBase)) { SetDefaultValues((dynamic)new SixtyFourBase(0)); }
            if (typeof(Type) == typeof(BinaryCodedDecimal)) { SetDefaultValues((dynamic)new BinaryCodedDecimal(0)); }
            if (typeof(Type) == typeof(BCD)) { SetDefaultValues((dynamic)new BCD(0)); }
        }
        /// <summary>
        /// Sets the default values of the Matrix.
        /// </summary>
        /// <param name="value">The selected default value.</param>
        private void SetDefaultValues(Type value)
        {
            for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            { elements[i, j] = value; }
        }
        /// <summary>
        /// Converts a value into the Matrix' elements' value type.
        /// </summary>
        /// <param name="value">The selected value.</param>
        /// <returns>The selected value represented in the Matrix' elements' value type.</returns>
        protected Type Value(double value)
        => Mathematics.Value<Type>(value);
        
        #region #Operators With a Number
        public static Matrix<Type> operator +(Matrix<Type> matrix, Type v)
        {
            Matrix<Type> matrix_ = new Matrix<Type>(matrix.Width, matrix.Height);
            for (int i = 0, j = 0; i < matrix.Width; i += j == matrix.Height - 1 ? 1 : 0, j = j == matrix.Height - 1 ? 0 : j + 1)
            { matrix_[i, j] = (dynamic)matrix[i, j] + v; }
            return matrix_;
        }
        public static Matrix<Type> operator +(Type v, Matrix<Type> matrix)
        {
            Matrix<Type> matrix_ = new Matrix<Type>(matrix.Width, matrix.Height);
            for (int i = 0, j = 0; i < matrix.Width; i += j == matrix.Height - 1 ? 1 : 0, j = j == matrix.Height - 1 ? 0 : j + 1)
            { matrix_[i, j] = (dynamic)matrix[i, j] + v; }
            return matrix_;
        }
        public static Matrix<Type> operator -(Matrix<Type> matrix, Type v)
        {
            Matrix<Type> matrix_ = new Matrix<Type>(matrix.Width, matrix.Height);
            for (int i = 0, j = 0; i < matrix.Width; i += j == matrix.Height - 1 ? 1 : 0, j = j == matrix.Height - 1 ? 0 : j + 1)
            { matrix_[i, j] = (dynamic)matrix[i, j] - v; }
            return matrix_;
        }
        public static Matrix<Type> operator -(Type v, Matrix<Type> matrix)
        {
            Matrix<Type> matrix_ = new Matrix<Type>(matrix.Width, matrix.Height);
            for (int i = 0, j = 0; i < matrix.Width; i += j == matrix.Height - 1 ? 1 : 0, j = j == matrix.Height - 1 ? 0 : j + 1)
            { matrix_[i, j] = v - (dynamic)matrix[i, j]; }
            return matrix_;
        }
        public static Matrix<Type> operator *(Matrix<Type> matrix, Type v)
        {
            Matrix<Type> matrix_ = new Matrix<Type>(matrix.Width, matrix.Height);
            for (int i = 0, j = 0; i < matrix.Width; i += j == matrix.Height - 1 ? 1 : 0, j = j == matrix.Height - 1 ? 0 : j + 1)
            { matrix_[i, j] = (dynamic)matrix[i, j] * v; }
            return matrix_;
        }
        public static Matrix<Type> operator *(Type v, Matrix<Type> matrix)
        {
            Matrix<Type> matrix_ = new Matrix<Type>(matrix.Width, matrix.Height);
            for (int i = 0, j = 0; i < matrix.Width; i += j == matrix.Height - 1 ? 1 : 0, j = j == matrix.Height - 1 ? 0 : j + 1)
            { matrix_[i, j] = (dynamic)matrix[i, j] * v; }
            return matrix_;
        }
        public static Matrix<Type> operator /(Matrix<Type> matrix, Type v)
        {
            Matrix<Type> matrix_ = new Matrix<Type>(matrix.Width, matrix.Height);
            for (int i = 0, j = 0; i < matrix.Width; i += j == matrix.Height - 1 ? 1 : 0, j = j == matrix.Height - 1 ? 0 : j + 1)
            { matrix_[i, j] = (dynamic)matrix[i, j] / v; }
            return matrix_;
        }
        public static Matrix<Type> operator /(Type v, Matrix<Type> matrix)
        {
            if (!matrix.IsIrreversible)
            { return v * matrix.Inverse; }
            throw new DivideByIrreversibleMatrixException();
        }
        #endregion
        #region #Operators With Another Matrix
        public static Matrix<Type> operator +(Matrix<Type> matrix1, Matrix<Type> matrix2)
        {
            int Width = Mathematics.Max(matrix1.Width, matrix2.Width),
                Height = Mathematics.Max(matrix1.Height, matrix2.Height);
            Matrix<Type> matrix = new Matrix<Type>(Width, Height);
            for (int i = 0, j = 0; i < Width; i += j == Height - 1 ? 1 : 0, j = j == Height - 1 ? 0 : j + 1)
                matrix[i, j] = (i < matrix1.Width && j < matrix1.Height ? (dynamic)matrix1[i, j] : matrix.Value(0))
                              + (i < matrix2.Width && j < matrix2.Height ? (dynamic)matrix2[i, j] : matrix.Value(0));
            return matrix;
        }
        public static Matrix<Type> operator -(Matrix<Type> matrix1, Matrix<Type> matrix2)
        {
            int Width = Mathematics.Max(matrix1.Width, matrix2.Width),
                Height = Mathematics.Max(matrix1.Height, matrix2.Height);
            Matrix<Type> matrix = new Matrix<Type>(Width, Height);
            for (int i = 0, j = 0; i < Width; i += j == Height - 1 ? 1 : 0, j = j == Height - 1 ? 0 : j + 1)
                matrix[i, j] = (i < matrix1.Width && j < matrix1.Height ? (dynamic)matrix1[i, j] : matrix.Value(0))
                              - (i < matrix2.Width && j < matrix2.Height ? (dynamic)matrix2[i, j] : matrix.Value(0));
            return matrix;
        }
        public static Matrix<Type> operator *(Matrix<Type> matrix1, Matrix<Type> matrix2)
        {
            if (!matrix1.IsMultiplicationConformableWith(matrix2))
            { throw new NonmultiplicationConformableMatricesException(); }
            int Width = matrix2.Width,
                Height = matrix1.Height;
            Matrix<Type> matrix = new Matrix<Type>(Width, Height);
            List<Type> list = new List<Type>();
            Matrix<Type>[] rows = matrix1.Rows,
                        columns = matrix2.Columns;
            for (int i = 0, j = 0; i < Height; i += j == Width - 1 ? 1 : 0, j = j == Width - 1 ? 0 : j + 1)
            {
                for (int k = 0; k < matrix1.Width; k++)
                { matrix.elements[i, j] += (dynamic)rows[i].elements[0, k] * (dynamic)columns[j].elements[k, 0]; }
            }
            return matrix;
        }
        public static Matrix<Type> operator /(Matrix<Type> matrix1, Matrix<Type> matrix2)
        {
            if (!matrix2.IsIrreversible) { return matrix1 * matrix2.Inverse; }
            throw new DivideByIrreversibleMatrixException();
        }
        #endregion
        #region #Operators Alone
        public static Matrix<Type> operator +(Matrix<Type> matrix)
        => matrix;
        public static Matrix<Type> operator -(Matrix<Type> matrix)
        => matrix * matrix.Value(-1);
        public static Matrix<Type> operator ++(Matrix<Type> matrix)
        => matrix += matrix.Value(1);
        public static Matrix<Type> operator --(Matrix<Type> matrix)
        => matrix -= matrix.Value(1);
        #endregion

        /// <summary>
        /// Modifies an element of the Matrix.
        /// </summary>
        /// <param name="indexWidth">The zero-based index of the element on the width of the Matrix.</param>
        /// <param name="indexHeight">The zero-based index of the element on the height of the Matrix.</param>
        /// <returns>The element that its index matches the selected index.</returns>
        public Type this[int indexWidth, int indexHeight]
        {
            get { return elements[indexHeight, indexWidth]; }
            set { elements[indexHeight, indexWidth] = value; }
        }
        /// <summary>
        /// Gets an element from the Matrix.
        /// </summary>
        /// <returns>An element from the Matrix.</returns>
        public IEnumerator<Type> GetEnumerator()
        { foreach (var item in elements) { yield return item; } }

        /// <summary>
        /// Converts the Matrix into a string value.
        /// </summary>
        /// <returns>A string value that represents the Matrix.</returns>
        public override string ToString()
        { SetForm(); return form; }
        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
        /// <summary>
        /// Gives the type of the contained elements within the Matrix.
        /// </summary>
        /// <returns>The type of the contained elements within the Matrix.</returns>
        public Type TypeOf()
        => (dynamic)elements.GetType();
    }
    /// <summary>
    /// A square two-by-two matrix, which is a set of bunch of numbers in a two dimensional rectangle.
    /// </summary>
    /// <typeparam name="Type">The type of the numbers sorted in the Matrix.</typeparam>
    public class Matrix2<Type> : Matrix<Type> where Type : IFormattable
    {
        /// <summary>
        /// Gives the transposed Matrix of the Matrix, (which is a Matrix with its rows replaced with its columns).
        /// </summary>
        public new Matrix2<Type> Transpose
        { get { return new Matrix2<Type>().Fill(base.Transpose.ToList()); } }
        /// <summary>
        /// The adjoint of the Matrix, (usually used to calculate the inverse of the Matrix).
        /// </summary>
        public new Matrix2<Type> Adjoint
        { get { return new Matrix2<Type>().Fill(base.Adjoint.ToList()); } }
        /// <summary>
        /// The inverse of the Matrix, which is One over the Matrix, (when multiplied to the Matrix it returns the Identity Matrix with the same rank).
        /// </summary>
        public new Matrix2<Type> Inverse
        { get { return new Matrix2<Type>().Fill(base.Inverse.ToList()); } }
        /// <summary>
        /// The eigen values of the Matrix.
        /// </summary>
        public Type[] EigenValues
        {
            get
            {
                Type[] eigenValues = new Type[2];
                Type average = Mathematics.Average((dynamic)GetDiagonalElements()[0], (dynamic)GetDiagonalElements()[1]);
                eigenValues[0] =  average + Mathematics.SquareRoot(Mathematics.Square((dynamic)average) - Determenant);
                eigenValues[1] =  average - Mathematics.SquareRoot(Mathematics.Square((dynamic)average) - Determenant);
                return eigenValues;
            }
        }

        /// <summary>
        /// A two-by-two Square Diagonal Matrix were all its diagonal elements are ones.
        /// </summary>
        /// <returns>A two-by-two Square Diagonal Matrix were all its diagonal elements are ones.</returns>
        public new static Matrix2<Type> IdenticalMatrix
        => new Matrix2<Type>().FillDiagonally(new Matrix2<Type>().Value(1));
        /// <summary>
        /// When applied to a two-dimensional Vector, it flips its components.
        /// </summary>
        public static Matrix2<Type> FlippingMatrix
        => new Matrix2<Type>().FillSymmetrically(new Matrix2<Type>().Value(1));
        /// <summary>
        /// When applied to a two-dimensional Vector, it return its reverse.
        /// </summary>
        public static Matrix2<Type> InvertingMatrix
        => -IdenticalMatrix;
        /// <summary>
        /// When applied to a two-dimensional Vector, it rotates it 90 Degrees clockwise.
        /// </summary>
        public static Matrix2<Type> Clockwise90Matrix
        => new Matrix2<Type>().Fill(new Type[] { new Matrix2<Type>().Value(0), new Matrix2<Type>().Value(1), new Matrix2<Type>().Value(-1), new Matrix2<Type>().Value(0) });
        /// <summary>
        /// When applied to a two-dimensional Vector, it rotates it 90 Degrees anti-clockwise.
        /// </summary>
        public static Matrix2<Type> AntiClockwise90Matrix
        => new Matrix2<Type>().Fill(new Type[] { new Matrix2<Type>().Value(0), new Matrix2<Type>().Value(-1), new Matrix2<Type>().Value(1), new Matrix2<Type>().Value(0) });
        /// <summary>
        /// When applied to a two-dimensional Vector, it rotates it with a specified angle clockwise.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>A rotating Matrix with the specified selected angle.</returns>
        public static Matrix2<Type> RotatingMatrix(Type θ)
        => new Matrix2<Type>().Fill(new Type[] { new Matrix2<Type>().Value(Mathematics.Cos((dynamic)θ))
                                          ,new Matrix2<Type>().Value(Mathematics.Sin((dynamic)θ))
                                          ,new Matrix2<Type>().Value(-Mathematics.Sin((dynamic)θ))
                                          ,new Matrix2<Type>().Value(Mathematics.Cos((dynamic)θ)) });
        /// <summary>
        /// A two-by-two Matrix that represents the Imaginary Number 'i', which stands for the square root of -1, or in that case square root of -I, (minus the two-by-two Identical Matrix).
        /// </summary>
        public static Matrix2<Type> iMatrix => AntiClockwise90Matrix;

        /// <summary>
        /// Fills the Matrix with items, (this removes all the old elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after being filled.</returns>
        public new Matrix2<Type> Fill(IEnumerable<Type> items)
        { base.Fill(items); return this; }
        /// <summary>
        /// Fills the Matrix with one item, (this removes all the old elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after being filled.</returns>
        public new Matrix2<Type> Fill(Type item)
        { base.Fill(item); return this; }
        /// <summary>
        /// Fills a row in the Matrix with items, (this removes all the old elements of the row of the Matrix).
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its row being filled.</returns>
        public new Matrix2<Type> FillRow(int index, IEnumerable<Type> items)
        { base.FillRow(index, items); return this; }
        /// <summary>
        /// Fills a row in the Matrix with one item, (this removes all the old elements of the row of the Matrix).
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its row being filled.</returns>
        public new Matrix2<Type> FillRow(int index, Type item)
        { base.FillRow(index, item); return this; }
        /// <summary>
        /// Fills a column in the Matrix with items, (this removes all the old elements of the column of the Matrix).
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its row being filled.</returns>
        public new Matrix2<Type> FillColumn(int index, IEnumerable<Type> items)
        { base.FillColumn(index, items); return this; }
        /// <summary>
        /// Fills a column in the Matrix with one item, (this removes all the old elements of the column of the Matrix).
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its row being filled.</returns>
        public new Matrix2<Type> FillColumn(int index, Type item)
        { base.FillColumn(index, item); return this; }
        /// <summary>
        /// Fills the hypotenuse of the Matrix with items, (this removes all the old elements of the hypotenuse of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its hypotenuse being filled.</returns>
        public new Matrix2<Type> FillDiagonally(IEnumerable<Type> items)
        { base.FillDiagonally(items); return this; }
        /// <summary>
        /// Fills the hypotenuse of the Matrix with one item, (this removes all the old elements of the hypotenuse of the Matrix).
        /// </summary>
        /// <param name="item">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its hypotenuse being filled.</returns>
        public new Matrix2<Type> FillDiagonally(Type item)
        { base.FillDiagonally(item); return this; }
        /// <summary>
        /// Fills the ij'th elements and ji'th elements of the Matrix with same items, (this removes all the old elements of the ij'th elements and ji'th elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its ij'th elements and ji'th elements being filled.</returns>
        public new Matrix2<Type> FillSymmetrically(IEnumerable<Type> items)
        { base.FillSymmetrically(items); return this; }
        /// <summary>
        /// Fills the ij'th elements and ji'th elements of the Matrix with same one item, (this removes all the old elements of the ij'th elements and ji'th elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its ij'th elements and ji'th elements being filled.</returns>
        public new Matrix2<Type> FillSymmetrically(Type item)
        { base.FillSymmetrically(item); return this; }
        /// <summary>
        /// Fills the top triangle elements (and hypotenuse elements as well) of the Matrix with items, (this removes all the old elements of the top triangle elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its top triangle elements being filled.</returns>
        public new Matrix2<Type> FillTopTriangle(IEnumerable<Type> items)
        { base.FillTopTriangle(items); return this; }
        /// <summary>
        /// Fills the top triangle elements (and hypotenuse elements as well) of the Matrix with one item, (this removes all the old elements of the top triangle elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its top triangle elements being filled.</returns>
        public new Matrix2<Type> FillTopTriangle(Type item)
        { base.FillTopTriangle(item); return this; }
        /// <summary>
        /// Fills the bottom triangle elements (and hypotenuse elements as well) of the Matrix with items, (this removes all the old elements of the bottom triangle elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its bottom triangle elements being filled.</returns>
        public new Matrix2<Type> FillBottomTriangle(IEnumerable<Type> items)
        { base.FillBottomTriangle(items); return this; }
        /// <summary>
        /// Fills the bottom triangle elements (and hypotenuse elements as well) of the Matrix with one item, (this removes all the old elements of the bottom triangle elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its bottom triangle elements being filled.</returns>
        public new Matrix2<Type> FillBottomTriangle(Type item)
        { base.FillBottomTriangle(item); return this; }

        /// <summary>
        /// Builds up a new two-by-two Matrix
        /// </summary>
        public Matrix2() : base(2) { }

        #region #Operators With a Number
        public static Matrix2<Type> operator +(Matrix2<Type> matrix, Type v)
        => new Matrix2<Type>().Fill(((Matrix<Type>)matrix + v).ToList());
        public static Matrix2<Type> operator +(Type v, Matrix2<Type> matrix)
        => new Matrix2<Type>().Fill(((Matrix<Type>)matrix + v).ToList());
        public static Matrix2<Type> operator -(Matrix2<Type> matrix, Type v)
        => new Matrix2<Type>().Fill(((Matrix<Type>)matrix - v).ToList());
        public static Matrix2<Type> operator -(Type v, Matrix2<Type> matrix)
        => new Matrix2<Type>().Fill((v - (Matrix<Type>)matrix).ToList());
        public static Matrix2<Type> operator *(Matrix2<Type> matrix, Type v)
        => new Matrix2<Type>().Fill(((Matrix<Type>)matrix * v).ToList());
        public static Matrix2<Type> operator *(Type v, Matrix2<Type> matrix)
        => new Matrix2<Type>().Fill(((Matrix<Type>)matrix * v).ToList());
        public static Matrix2<Type> operator /(Matrix2<Type> matrix, Type v)
        => new Matrix2<Type>().Fill(((Matrix<Type>)matrix / v).ToList());
        public static Matrix2<Type> operator /(Type v, Matrix2<Type> matrix)
        => new Matrix2<Type>().Fill((v / (Matrix<Type>)matrix).ToList());
        #endregion
        #region #Operators With Another Matrix
        public static Matrix2<Type> operator +(Matrix2<Type> matrix1, Matrix2<Type> matrix2)
        => new Matrix2<Type>().Fill(((Matrix<Type>)matrix1 + matrix2).ToList());
        public static Matrix2<Type> operator -(Matrix2<Type> matrix1, Matrix2<Type> matrix2)
        => new Matrix2<Type>().Fill(((Matrix<Type>)matrix1 - matrix2).ToList());
        public static Matrix2<Type> operator *(Matrix2<Type> matrix1, Matrix2<Type> matrix2)
        => new Matrix2<Type>().Fill(((Matrix<Type>)matrix1 * matrix2).ToList());
        public static Matrix2<Type> operator /(Matrix2<Type> matrix1, Matrix2<Type> matrix2)
        => new Matrix2<Type>().Fill(((Matrix<Type>)matrix1 / matrix2).ToList());
        #endregion
        #region #Operators Alone
        public static Matrix2<Type> operator +(Matrix2<Type> matrix)
        => matrix;
        public static Matrix2<Type> operator -(Matrix2<Type> matrix)
        => matrix * matrix.Value(-1);
        public static Matrix2<Type> operator ++(Matrix2<Type> matrix)
        => matrix += matrix.Value(1);
        public static Matrix2<Type> operator --(Matrix2<Type> matrix)
        => matrix -= matrix.Value(1);
        #endregion
    }
    /// <summary>
    /// A square three-by-three matrix, which is a set of bunch of numbers in a two dimensional rectangle.
    /// </summary>
    /// <typeparam name="Type">The type of the numbers sorted in the Matrix.</typeparam>
    public class Matrix3<Type> : Matrix<Type> where Type : IFormattable
    {
        /// <summary>
        /// Gives the transposed Matrix of the Matrix, (which is a Matrix with its rows replaced with its columns).
        /// </summary>
        public new Matrix3<Type> Transpose
        { get { return new Matrix3<Type>().Fill(base.Transpose.ToList()); } }
        /// <summary>
        /// The adjoint of the Matrix, (usually used to calculate the inverse of the Matrix).
        /// </summary>
        public new Matrix3<Type> Adjoint
        { get { return new Matrix3<Type>().Fill(base.Adjoint.ToList()); } }
        /// <summary>
        /// The inverse of the Matrix, which is One over the Matrix, (when multiplied to the Matrix it returns the Identity Matrix with the same rank).
        /// </summary>
        public new Matrix3<Type> Inverse
        { get { return new Matrix3<Type>().Fill(base.Inverse.ToList()); } }

        /// <summary>
        /// A three-by-three Square Diagonal Matrix were all its diagonal elements are ones.
        /// </summary>
        /// <returns>A three-by-three Square Diagonal Matrix were all its diagonal elements are ones.</returns>
        public new static Matrix3<Type> IdenticalMatrix
        => new Matrix3<Type>().FillDiagonally(new Matrix3<Type>().Value(1));
        /// <summary>
        /// When applied to a three-dimensional Vector, it flips its components.
        /// </summary>
        public static Matrix3<Type> FlippingMatrix
        => new Matrix3<Type>().Fill(new Type[] { new Matrix3<Type>().Value(0), new Matrix3<Type>().Value(0), new Matrix3<Type>().Value(1)
                                         , new Matrix3<Type>().Value(0), new Matrix3<Type>().Value(1), new Matrix3<Type>().Value(0)
                                         , new Matrix3<Type>().Value(1), new Matrix3<Type>().Value(0), new Matrix3<Type>().Value(0)});
        /// <summary>
        /// When applied to a three-dimensional Vector, it return its reverse.
        /// </summary>
        public static Matrix3<Type> InvertingMatrix
        => -IdenticalMatrix;
        /// <summary>
        /// When applied to a three-dimensional Vector, it rotates it along the X axis with a specified angle clockwise.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>A rotating Matrix along the X axis with the specified selected angle.</returns>
        public static Matrix3<Type> RotatingXMatrix(Type θ)
        => new Matrix3<Type>().Fill(new Type[] { new Matrix3<Type>().Value(1), new Matrix3<Type>().Value(0), new Matrix3<Type>().Value(0)
                                         , new Matrix3<Type>().Value(0), new Matrix3<Type>().Value(Mathematics.Cos((dynamic)θ)), new Matrix3<Type>().Value(Mathematics.Sin((dynamic)θ))
                                         , new Matrix3<Type>().Value(0), new Matrix3<Type>().Value(-Mathematics.Sin((dynamic)θ)), new Matrix3<Type>().Value(Mathematics.Cos((dynamic)θ))});
        /// <summary>
        /// When applied to a three-dimensional Vector, it rotates it along the Y axis with a specified angle clockwise.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>A rotating Matrix along the Y axis with the specified selected angle.</returns>
        public static Matrix3<Type> RotatingYMatrix(Type θ)
        => new Matrix3<Type>().Fill(new Type[] { new Matrix3<Type>().Value(Mathematics.Cos((dynamic)θ)), new Matrix3<Type>().Value(0), new Matrix3<Type>().Value(-Mathematics.Sin((dynamic)θ))
                                         , new Matrix3<Type>().Value(0), new Matrix3<Type>().Value(1), new Matrix3<Type>().Value(0)
                                         , new Matrix3<Type>().Value(Mathematics.Sin((dynamic)θ)), new Matrix3<Type>().Value(0), new Matrix3<Type>().Value(Mathematics.Cos((dynamic)θ))});
        /// <summary>
        /// When applied to a three-dimensional Vector, it rotates it along the Z axis with a specified angle clockwise.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        /// <returns>A rotating Matrix along the Z axis with the specified selected angle.</returns>
        public static Matrix3<Type> RotatingZMatrix(Type θ)
        => new Matrix3<Type>().Fill(new Type[] { new Matrix3<Type>().Value(Mathematics.Cos((dynamic)θ)), new Matrix3<Type>().Value(Mathematics.Sin((dynamic)θ)), new Matrix3<Type>().Value(0)
                                         , new Matrix3<Type>().Value(-Mathematics.Sin((dynamic)θ)), new Matrix3<Type>().Value(Mathematics.Cos((dynamic)θ)), new Matrix3<Type>().Value(0)
                                         , new Matrix3<Type>().Value(0), new Matrix3<Type>().Value(0), new Matrix3<Type>().Value(1)});
        /// <summary>
        /// When applied to a three-dimensional Vector, it rotates it along all the axis with specified angles clockwise.
        /// </summary>
        /// <param name="θx">The selected angle to rotate along the X axis, (measured in Degrees).</param>
        /// <param name="θy">The selected angle to rotate along the Y axis, (measured in Degrees).</param>
        /// <param name="θz">The selected angle to rotate along the Z axis, (measured in Degrees).</param>
        /// <returns>A rotating Matrix along all the axis with the specified selected angles.</returns>
        public static Matrix3<Type> RotatingMatrix(Type θx, Type θy, Type θz)
        => RotatingXMatrix(θx) * RotatingYMatrix(θy) * RotatingZMatrix(θz);
        /// <summary>
        /// When applied to a three-dimensional Vector, it rotates it along the X axis by 90 Degrees clockwise.
        /// </summary>
        public static Matrix3<Type> ClockwiseX90Matrix
        => RotatingXMatrix(new Matrix3<Type>().Value(90));
        /// <summary>
        /// When applied to a three-dimensional Vector, it rotates it along the Y axis by 90 Degrees clockwise.
        /// </summary>
        public static Matrix3<Type> ClockwiseY90Matrix
        => RotatingYMatrix(new Matrix3<Type>().Value(90));
        /// <summary>
        /// When applied to a three-dimensional Vector, it rotates it along the Z axis by 90 Degrees clockwise.
        /// </summary>
        public static Matrix3<Type> ClockwiseZ90Matrix
        => RotatingZMatrix(new Matrix3<Type>().Value(90));
        /// <summary>
        /// When applied to a three-dimensional Vector, it rotates it along the X axis by 90 Degrees anti-clockwise.
        /// </summary>
        public static Matrix3<Type> AntiClockwiseX90Matrix
        => RotatingXMatrix(new Matrix3<Type>().Value(-90));
        /// <summary>
        /// When applied to a three-dimensional Vector, it rotates it along the Y axis by 90 Degrees anti-clockwise.
        /// </summary>
        public static Matrix3<Type> AntiClockwiseY90Matrix
        => RotatingYMatrix(new Matrix3<Type>().Value(-90));
        /// <summary>
        /// When applied to a three-dimensional Vector, it rotates it along the Z axis by 90 Degrees anti-clockwise.
        /// </summary>
        public static Matrix3<Type> AntiClockwiseZ90Matrix
        => RotatingZMatrix(new Matrix3<Type>().Value(-90));
        /// <summary>
        /// A three-by-three Matrix that represents the Lateral Number 'i', which stands for the square root of -1, or in that case square root of -I, (minus the three-by-three Identical Matrix).
        /// </summary>
        public static Matrix3<Type> iMatrix => AntiClockwiseX90Matrix;
        /// <summary>
        /// A three-by-three Matrix that represents the Lateral Number 'j', which stands for the square root of -1, or in that case square root of -I, (minus the three-by-three Identical Matrix).
        /// </summary>
        public static Matrix3<Type> jMatrix => AntiClockwiseY90Matrix;
        /// <summary>
        /// A three-by-three Matrix that represents the Lateral Number 'k', which stands for the square root of -1, or in that case square root of -I, (minus the three-by-three Identical Matrix).
        /// </summary>
        public static Matrix3<Type> kMatrix => AntiClockwiseZ90Matrix;

        /// <summary>
        /// Fills the Matrix with items, (this removes all the old elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after being filled.</returns>
        public new Matrix3<Type> Fill(IEnumerable<Type> items)
        { base.Fill(items); return this; }
        /// <summary>
        /// Fills the Matrix with one item, (this removes all the old elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after being filled.</returns>
        public new Matrix3<Type> Fill(Type item)
        { base.Fill(item); return this; }
        /// <summary>
        /// Fills a row in the Matrix with items, (this removes all the old elements of the row of the Matrix).
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its row being filled.</returns>
        public new Matrix3<Type> FillRow(int index, IEnumerable<Type> items)
        { base.FillRow(index, items); return this; }
        /// <summary>
        /// Fills a row in the Matrix with one item, (this removes all the old elements of the row of the Matrix).
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its row being filled.</returns>
        public new Matrix3<Type> FillRow(int index, Type item)
        { base.FillRow(index, item); return this; }
        /// <summary>
        /// Fills a column in the Matrix with items, (this removes all the old elements of the column of the Matrix).
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its row being filled.</returns>
        public new Matrix3<Type> FillColumn(int index, IEnumerable<Type> items)
        { base.FillColumn(index, items); return this; }
        /// <summary>
        /// Fills a column in the Matrix with one item, (this removes all the old elements of the column of the Matrix).
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its row being filled.</returns>
        public new Matrix3<Type> FillColumn(int index, Type item)
        { base.FillColumn(index, item); return this; }
        /// <summary>
        /// Fills the hypotenuse of the Matrix with items, (this removes all the old elements of the hypotenuse of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its hypotenuse being filled.</returns>
        public new Matrix3<Type> FillDiagonally(IEnumerable<Type> items)
        { base.FillDiagonally(items); return this; }
        /// <summary>
        /// Fills the hypotenuse of the Matrix with one item, (this removes all the old elements of the hypotenuse of the Matrix).
        /// </summary>
        /// <param name="item">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its hypotenuse being filled.</returns>
        public new Matrix3<Type> FillDiagonally(Type item)
        { base.FillDiagonally(item); return this; }
        /// <summary>
        /// Fills the ij'th elements and ji'th elements of the Matrix with same items, (this removes all the old elements of the ij'th elements and ji'th elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its ij'th elements and ji'th elements being filled.</returns>
        public new Matrix3<Type> FillSymmetrically(IEnumerable<Type> items)
        { base.FillSymmetrically(items); return this; }
        /// <summary>
        /// Fills the ij'th elements and ji'th elements of the Matrix with same one item, (this removes all the old elements of the ij'th elements and ji'th elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its ij'th elements and ji'th elements being filled.</returns>
        public new Matrix3<Type> FillSymmetrically(Type item)
        { base.FillSymmetrically(item); return this; }
        /// <summary>
        /// Fills the top triangle elements (and hypotenuse elements as well) of the Matrix with items, (this removes all the old elements of the top triangle elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its top triangle elements being filled.</returns>
        public new Matrix3<Type> FillTopTriangle(IEnumerable<Type> items)
        { base.FillTopTriangle(items); return this; }
        /// <summary>
        /// Fills the top triangle elements (and hypotenuse elements as well) of the Matrix with one item, (this removes all the old elements of the top triangle elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its top triangle elements being filled.</returns>
        public new Matrix3<Type> FillTopTriangle(Type item)
        { base.FillTopTriangle(item); return this; }
        /// <summary>
        /// Fills the bottom triangle elements (and hypotenuse elements as well) of the Matrix with items, (this removes all the old elements of the bottom triangle elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected items to get into the Matrix.</param>
        /// <returns>The Matrix after its bottom triangle elements being filled.</returns>
        public new Matrix3<Type> FillBottomTriangle(IEnumerable<Type> items)
        { base.FillBottomTriangle(items); return this; }
        /// <summary>
        /// Fills the bottom triangle elements (and hypotenuse elements as well) of the Matrix with one item, (this removes all the old elements of the bottom triangle elements of the Matrix).
        /// </summary>
        /// <param name="items">The selected item to get into the Matrix.</param>
        /// <returns>The Matrix after its bottom triangle elements being filled.</returns>
        public new Matrix3<Type> FillBottomTriangle(Type item)
        { base.FillBottomTriangle(item); return this; }

        /// <summary>
        /// Builds up a new three-by-three Matrix
        /// </summary>
        public Matrix3() : base(3) { }

        #region #Operators With a Number
        public static Matrix3<Type> operator +(Matrix3<Type> matrix, Type v)
        => new Matrix3<Type>().Fill(((Matrix<Type>)matrix + v).ToList());
        public static Matrix3<Type> operator +(Type v, Matrix3<Type> matrix)
        => new Matrix3<Type>().Fill(((Matrix<Type>)matrix + v).ToList());
        public static Matrix3<Type> operator -(Matrix3<Type> matrix, Type v)
        => new Matrix3<Type>().Fill(((Matrix<Type>)matrix - v).ToList());
        public static Matrix3<Type> operator -(Type v, Matrix3<Type> matrix)
        => new Matrix3<Type>().Fill((v - (Matrix<Type>)matrix).ToList());
        public static Matrix3<Type> operator *(Matrix3<Type> matrix, Type v)
        => new Matrix3<Type>().Fill(((Matrix<Type>)matrix * v).ToList());
        public static Matrix3<Type> operator *(Type v, Matrix3<Type> matrix)
        => new Matrix3<Type>().Fill(((Matrix<Type>)matrix * v).ToList());
        public static Matrix3<Type> operator /(Matrix3<Type> matrix, Type v)
        => new Matrix3<Type>().Fill(((Matrix<Type>)matrix / v).ToList());
        public static Matrix3<Type> operator /(Type v, Matrix3<Type> matrix)
        => new Matrix3<Type>().Fill((v / (Matrix<Type>)matrix).ToList());
        #endregion
        #region #Operators With Another Matrix
        public static Matrix3<Type> operator +(Matrix3<Type> matrix1, Matrix3<Type> matrix2)
        => new Matrix3<Type>().Fill(((Matrix<Type>)matrix1 + matrix2).ToList());
        public static Matrix3<Type> operator -(Matrix3<Type> matrix1, Matrix3<Type> matrix2)
        => new Matrix3<Type>().Fill(((Matrix<Type>)matrix1 - matrix2).ToList());
        public static Matrix3<Type> operator *(Matrix3<Type> matrix1, Matrix3<Type> matrix2)
        => new Matrix3<Type>().Fill(((Matrix<Type>)matrix1 * matrix2).ToList());
        public static Matrix3<Type> operator /(Matrix3<Type> matrix1, Matrix3<Type> matrix2)
        => new Matrix3<Type>().Fill(((Matrix<Type>)matrix1 / matrix2).ToList());
        #endregion
        #region #Operators Alone
        public static Matrix3<Type> operator +(Matrix3<Type> matrix)
        => matrix;
        public static Matrix3<Type> operator -(Matrix3<Type> matrix)
        => matrix * matrix.Value(-1);
        public static Matrix3<Type> operator ++(Matrix3<Type> matrix)
        => matrix += matrix.Value(1);
        public static Matrix3<Type> operator --(Matrix3<Type> matrix)
        => matrix -= matrix.Value(1);
        #endregion
    }

    #endregion

    #region #Geometry

    /// <summary>
    /// A point, which represents a position on the Real-Axis.
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Determines the state of a Point to a certain Function.
        /// </summary>
        public enum PointState
        {
            /// <summary>On the Function.</summary>
            On,
            /// <summary>Above the Function.</summary>
            Above,
            /// <summary>Beneath the Function.</summary>
            Beneath,
            /// <summary>Inside the Function.</summary>
            Inside,
            /// <summary>Outside the Function.</summary>
            Outside
        }

        /// <summary>
        /// The amount of the displacement of the Point on the X axis.
        /// </summary>
        private double x;
        /// <summary>
        /// The amount of the displacement of the Point on the Y axis.
        /// </summary>
        private double y;
        /// <summary>
        /// The amount of the displacement of the Point on the Z axis.
        /// </summary>
        private double z;
        /// <summary>
        /// The amount of the displacement of the Point on the X axis.
        /// </summary>
        public double X { get { return x; } set { x = value; } }
        /// <summary>
        /// The amount of the displacement of the Point on the Y axis.
        /// </summary>
        public double Y { get { return y; } set { y = value; } }
        /// <summary>
        /// The amount of the displacement of the Point on the Z axis.
        /// </summary>
        public double Z { get { return z; } set { z = value; } }
        /// <summary>
        /// Determines wether or not the Point is three-dimensional or not.
        /// </summary>
        private bool threeDimensional;
        /// <summary>
        /// Determines wether or not the Point is three-dimensional or not.
        /// </summary>
        public bool ThreeDimensional { get { return threeDimensional; } }

        /// <summary>
        /// The standard form of a Vector.
        /// </summary>
        public const string StandardForm = "(x, y, z)";

        /// <summary>
        /// Gets the distance that's between this Point and another Point.
        /// </summary>
        /// <param name="point">The selected other Point.</param>
        /// <returns>The distance between the two selected Points.</returns>
        public double GetDistance(Point point)
        => Mathematics.GetHypotenuse(X - point.X, Y - point.Y, Z - point.Z);
        /// <summary>
        /// Gets the -shortest- distance that's between this Point and a two-dimensional Vector.
        /// </summary>
        /// <param name="point">The selected two-dimensional Vector.</param>
        /// <returns>The -shortest- distance between the Point and the selected two-dimensional Vector.</returns>
        public double GetDistance(Vector2D vector)
        => Mathematics.Absolute(vector.Equation[0][X] + vector.Equation[1][Y] + vector.Equation[2].Proverbs)
                        / Mathematics.GetHypotenuse(vector.Equation[0].Proverbs, vector.Equation[1].Proverbs);

        /// <summary>
        /// Builds up a new Point.
        /// </summary>
        public Point()
        { x = 0.0d; y = 0.0d; z = 0.0d; threeDimensional = false; }
        /// <summary>
        /// Builds up a new Point with a two dimensional position.
        /// </summary>
        /// <param name="x">The amount of the displacement of the Point on the X axis.</param>
        /// <param name="y">The amount of the displacement of the Point on the Y axis.</param>
        public Point(double x, double y)
        { this.x = x; this.y = y; z = 0.0d; threeDimensional = false; }
        /// <summary>
        /// Builds up a new Point with a three dimensional position.
        /// </summary>
        /// <param name="x">The amount of the displacement of the Point on the X axis.</param>
        /// <param name="y">The amount of the displacement of the Point on the Y axis.</param>
        /// <param name="z">The amount of the displacement of the Point on the Z axis.</param>
        public Point(double x, double y, double z)
        { this.x = x; this.y = y; this.z = z; threeDimensional = true; }

        #region #Operators With a Number
        public static Point operator *(Point point, double v)
        {
            Point point_ = new Point(point.x * v, point.y * v, point.z * v);
            point_.threeDimensional = point.threeDimensional;
            return point_;
        }
        public static Point operator *(double v, Point point)
        {
            Point point_ = new Point(point.x * v, point.y * v, point.z * v);
            point_.threeDimensional = point.threeDimensional;
            return point_;
        }
        public static Point operator /(Point point, double v)
        {
            Point point_ = new Point(point.x / v, point.y / v, point.z / v);
            point_.threeDimensional = point.threeDimensional;
            return point_;
        }
        public static Point operator /(double v, Point point)
        {
            Point point_ = new Point(v / point.x, v / point.y, v / point.z);
            point_.threeDimensional = point.threeDimensional;
            return point_;
        }
        #endregion
        #region #Operators With Another Point
        public static Point operator +(Point point1, Point point2)
        {
            Point point = new Point(point1.x + point2.x, point1.y + point2.y, point1.z + point2.z);
            point.threeDimensional = point1.threeDimensional || point2.threeDimensional;
            return point;
        }
        public static Point operator -(Point point1, Point point2)
        {
            Point point = new Point(point1.x - point2.x, point1.y - point2.y, point1.z - point2.z);
            point.threeDimensional = point1.threeDimensional || point2.threeDimensional;
            return point;
        }
        #endregion
        #region #Operators Alone
        public static Point operator +(Point point)
        => point;
        public static Point operator -(Point point)
        => -point;
        #endregion

        /// <summary>
        /// Converts the Point into a string value.
        /// </summary>
        /// <returns>A string value that represents the Point.</returns>
        public override string ToString()
        => $"({x}, {y}{(threeDimensional ? $", {z}" : "")})";
        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// A two dimensional vector, which is a line that starts at a Point A, and ends at a Point B.
    /// </summary>
    public class Vector2D
    {
        /// <summary>
        /// The Start Point of the Vector.
        /// </summary>
        private Point startPoint;
        /// <summary>
        /// The End Point of the Vector.
        /// </summary>
        private Point endPoint;
        /// <summary>
        /// The Start Point of the Vector.
        /// </summary>
        public Point StartPoint { get { return startPoint; } set { startPoint = value; } }
        /// <summary>
        /// The End Point of the Vector.
        /// </summary>
        public Point EndPoint { get { return endPoint; } set { endPoint = value; } }

        /// <summary>
        /// The length of the Vector on the Real-Axis.
        /// </summary>
        public double Magnitude { get { return endPoint.GetDistance(startPoint); } }
        /// <summary>
        /// The slope of the Vector on the Real-Axis.
        /// </summary>
        public double Slope { get { return (endPoint.Y - startPoint.Y) / (endPoint.X - startPoint.X); } }
        /// <summary>
        /// The Middle Point of the Vector on the Real-Axis.
        /// </summary>
        public Point MiddlePoint { get { return new Point((endPoint.X + startPoint.X) / 2, (endPoint.Y + startPoint.Y)); } }
        /// <summary>
        /// Returns the Vector based into the Origin, (Point (0, 0)).
        /// </summary>
        public Vector2D Based { get { return new Vector2D(new Point(), new Point(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y)); } }
        /// <summary>
        /// The component 'i' of the Vector.
        /// </summary>
        public double i { get { return Based.EndPoint.X; } }
        /// <summary>
        /// The component 'j' of the Vector.
        /// </summary>
        public double j { get { return Based.EndPoint.Y; } }
        /// <summary>
        /// Returns the Vector normalized into a length of One.
        /// </summary>
        public Vector2D Normalized
        {
            get
            {
                double x = (endPoint.X - startPoint.X) / Magnitude;
                double y = (endPoint.Y - startPoint.Y) / Magnitude;
                return new Vector2D(new Point(), new Point(x, y));
            }
        }
        /// <summary>
        /// The angle the Vector makes with the X axis, (measured in Degrees).
        /// </summary>
        public double Angle { get { return Mathematics.Arctan(Slope); } }
        /// <summary>
        /// The Function of the Vector.
        /// </summary>
        public Calculus.Function Function { get { Calculus.Function function; ToFunctionForm(out function); return function; } }
        /// <summary>
        /// The Equation of the Vector.
        /// </summary>
        public Calculus.Equation Equation { get { Calculus.Equation equation; ToEquationForm(out equation); return equation; } }
        /// <summary>
        /// Returns the perpendicular Vector to this Vector.
        /// </summary>
        public Vector2D PerpendicularVector { get { return Matrix2<double>.AntiClockwise90Matrix * this; } }
        /// <summary>
        /// Returns the Vector pointing in the reversed direction. 
        /// </summary>
        public Vector2D Inverse { get { return -this; } }

        /// <summary>
        /// Checks if the Vector parallels another Vector.
        /// </summary>
        /// <param name="vector">The other selected Vector.</param>
        /// <returns>A boolean that represents wether or not the two Vectors parallel each other.</returns>
        public bool Parallels(Vector2D vector) => AngleWith(vector) == 0 || AngleWith(vector) == 180;
        /// <summary>
        /// Checks if the Vector perpendiculates another Vector.
        /// </summary>
        /// <param name="vector">The other selected Vector.</param>
        /// <returns>A boolean that represents wether or not the two Vectors perpendiculate each other.</returns>
        public bool Perpendiculates(Vector2D vector) => AngleWith(vector) == 90 || AngleWith(vector) == 270;
        /// <summary>
        /// Finds the angle that's formed by this Vector and another Vector, (measured in Degrees).
        /// </summary>
        /// <param name="vector">The other selected Vector.</param>
        /// <returns>The angle that's formed by the two Vectors, (measured in Degrees).</returns>
        public double AngleWith(Vector2D vector)
        => Mathematics.Arccos((this * vector) / (Magnitude * vector.Magnitude));
        /// <summary>
        /// Finds the intersection Point with another Vector.
        /// </summary>
        /// <param name="vector">The other selected Vector.</param>
        /// <returns>The Point that represents the Intersection of the two Vectors.</returns>
        public Point InterscetsAt(Vector2D vector)
        => new Point(Mathematics.TwoVariablesEquations(Equation, vector.Equation)[0], Mathematics.TwoVariablesEquations(Equation, vector.Equation)[1]);
        /// <summary>
        /// Finds the location state of a Point according to the Vector.
        /// </summary>
        /// <param name="point">The selected Point.</param>
        /// <returns>The state of the selected Point to the Vector.</returns>
        public Point.PointState PointLocation(Point point)
        {
            // ax + by + c = 0
            double locator = Equation[0][point.X] + Equation[1][point.Y] + Equation[2].Proverbs;
            return locator > 0 ? Point.PointState.Above : locator < 0 ? Point.PointState.Beneath : Point.PointState.On;
        }

        /// <summary>
        /// A shortcut for writing a Vector heading Right.
        /// </summary>
        public static Vector2D Right { get { return new Vector2D(new Point(+1, 0)); } }
        /// <summary>
        /// A shortcut for writing a Vector heading Left.
        /// </summary>
        public static Vector2D Left { get { return new Vector2D(new Point(-1, 0)); } }
        /// <summary>
        /// A shortcut for writing a Vector heading Up.
        /// </summary>
        public static Vector2D Up { get { return new Vector2D(new Point(0, +1)); } }
        /// <summary>
        /// A shortcut for writing a Vector heading Down.
        /// </summary>
        public static Vector2D Down { get { return new Vector2D(new Point(0, -1)); } }
        /// <summary>
        /// The illustrative form of a Vector.
        /// </summary>
        public const string IllustrativeForm = "[(x1, y1) <--> (x2, y2)]";
        /// <summary>
        /// The algebraic form of a Vector.
        /// </summary>
        public const string AlgebraicForm = "v = xi + yj";
        /// <summary>
        /// The standard form of a Vector.
        /// </summary>
        public const string StandardForm = "y - y0 = m(x - x0)";
        /// <summary>
        /// The function form of a Vector.
        /// </summary>
        public const string FunctionForm = "y = mx + c";
        /// <summary>
        /// The equation form of a Vector.
        /// </summary>
        public const string EquationForm = "ax + by + c = 0";
        /// <summary>
        /// The components form of a Vector.
        /// </summary>
        public const string ComponentsForm = "v = <x, y>";
        /// <summary>
        /// The magnitude form of a Vector.
        /// </summary>
        public const string MagnitudeForm = "[ ||v||, θ ]";

        /// <summary>
        /// Builds up a new two-dimensional Vector.
        /// </summary>
        public Vector2D()
        { startPoint = new Point(); endPoint = new Point(); }
        /// <summary>
        /// Builds up a new two-dimensional Vector by declaring only one Point, (so the Start Point'll be from Point (0, 0)).
        /// </summary>
        /// <param name="point">The selected Point that the two-dimensional Vector'll end at.</param>
        public Vector2D(Point point)
        {
            point.Z = 0.0d;
            startPoint = new Point();
            endPoint = point;
        }
        /// <summary>
        /// Builds up a new two-dimensional Vector by declaring a Start Point, and an End Point.
        /// </summary>
        /// <param name="startPoint">The Start Point of the two-dimensional Vector.</param>
        /// <param name="endPoint">The End Point of the two-dimensional Vector.</param>
        public Vector2D(Point startPoint, Point endPoint)
        {
            startPoint.Z = 0.0d; endPoint.Z = 0.0d;
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }
        /// <summary>
        /// Builds up a new two-dimensional Vector by declaring its slope and one Point.
        /// </summary>
        /// <param name="point">The selected Point that the two-dimensional Vector passes through.</param>
        /// <param name="slope">The slope of the two-dimensional Vector, (Tangent of its Angle).</param>
        public Vector2D(Point point, double slope)
        {
            // y - y0 = m(x - x0)
            // y = mx - mx0 + y0
            point.Z = 0.0d;
            startPoint = point;
            endPoint = new Point(0, -slope * point.X + point.Y);
        }
        /// <summary>
        /// Builds up a new two-dimensional Vector by declaring its components.
        /// </summary>
        /// <param name="i">The amount of displacement of the two-dimensional Vector on the X axis.</param>
        /// <param name="j">The amount of displacement of the two-dimensional Vector on the Y axis.</param>
        public Vector2D(double i, double j) : this(new Point(i, j)) { }
        /// <summary>
        /// Builds up a new two-dimensional Vector by declaring the proverbs for an Equation with the form (ax + by + c = 0).
        /// </summary>
        /// <param name="a">The proverbs of x.</param>
        /// <param name="b">The proverbs of y.</param>
        /// <param name="c">The constant.</param>
        public Vector2D(double a, double b, double c)
        {
            // ax + by + c = 0
            // y = (-ax - c) / b
            // y = -a/b (x + c/a)
            startPoint = new Point(-c / a, 0);
            endPoint = new Point(0, -c / b);
        }
        /// <summary>
        /// Builds up a new two-dimensional Vector from a Complex Number.
        /// </summary>
        /// <param name="complex">The selected Complex Number.</param>
        public Vector2D(Complex complex) : this(new Point(complex.RealPart, complex.ImaginaryPart.Proverbs)) { }
        /// <summary>
        /// Builds up a new two-dimensional Vector with a magnitude of One, by declaring an angle.
        /// </summary>
        /// <param name="θ">The selected angle, (measured in Degrees).</param>
        public Vector2D(double θ) : this(Mathematics.Cos(θ), Mathematics.Sin(θ)) { }

        #region #Conversions
        public static explicit operator Vector2D(Vector3D vector)
        => new Vector2D(vector.i, vector.j);
        #endregion
        #region #Operators With a Number
        public static Vector2D operator *(Vector2D vector, double v)
        => new Vector2D(vector.startPoint * v, vector.endPoint * v);
        public static Vector2D operator *(double v, Vector2D vector)
        => new Vector2D(vector.startPoint * v, vector.endPoint * v);
        public static Vector2D operator /(Vector2D vector, double v)
        => new Vector2D(vector.startPoint / v, vector.endPoint / v);
        public static Vector2D operator /(double v, Vector2D vector)
        => new Vector2D(v / vector.startPoint, v / vector.endPoint);
        #endregion
        #region #Operators With Another Vector
        public static Vector2D operator +(Vector2D vector1, Vector2D vector2)
        => new Vector2D(vector1.StartPoint + vector2.StartPoint, vector1.EndPoint + vector2.EndPoint);
        public static Vector2D operator -(Vector2D vector1, Vector2D vector2)
        => new Vector2D(vector1.StartPoint - vector2.StartPoint, vector1.EndPoint - vector2.EndPoint);
        public static double operator *(Vector2D vector1, Vector2D vector2)
        => vector1.i * vector2.i +
           vector1.j * vector2.j;
        public static double operator ^(Vector2D vector1, Vector2D vector2)
        => new Matrix2<double>().Fill(new double[] {
           vector1.i , vector2.i,
           vector1.j , vector2.j }).Determenant;
        #endregion
        #region #Operators With Matrix
        public static Vector2D operator *(Matrix2<double> matrix, Vector2D vector)
        {
            Matrix<double> result = matrix * vector.ToMatrix();
            return new Vector2D(result[0, 0], result[0, 1]);
        }
        public static Vector2D operator *(Matrix2<int> matrix, Vector2D vector)
        {
            List<double> list = new List<double>();
            foreach (var item in matrix.ToList()) { list.Add(item); }
            Matrix2<double> matrix_ = new Matrix2<double>().Fill(list);
            return matrix_ * vector;
        }
        public static Vector2D operator *(Matrix2<float> matrix, Vector2D vector)
        {
            List<double> list = new List<double>();
            foreach (var item in matrix.ToList()) { list.Add(item); }
            Matrix2<double> matrix_ = new Matrix2<double>().Fill(list);
            return matrix_ * vector;
        }
        public static Vector2D operator *(Matrix2<decimal> matrix, Vector2D vector)
        {
            List<double> list = new List<double>();
            foreach (var item in matrix.ToList()) { list.Add(double.Parse(item.ToString())); }
            Matrix2<double> matrix_ = new Matrix2<double>().Fill(list);
            return matrix_ * vector;
        }
        #endregion
        #region #Operators With Complex
        public static Vector2D operator *(Complex c, Vector2D vector)
        => c.ToMatrix() * vector;
        #endregion
        #region #Operators Alone
        public static Vector2D operator +(Vector2D vector)
        => vector;
        public static Vector2D operator -(Vector2D vector)
        => vector * -1;
        #endregion

        /// <summary>
        /// Converts the Vector into a string value in the illustrative form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the illustrative form.</returns>
        public string ToIllustrativeForm()
        => $"[{startPoint} <--> {endPoint}]";
        /// <summary>
        /// Converts the Vector into a string value in the algebraic form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the algebraic form.</returns>
        public string ToAlgebraicForm()
        => Mathematics.CreateFunction(Calculus.FunctionCharacter.V
            , new Calculus.Variable(i, 1, Calculus.VariableCharacter.i)
            , new Calculus.Variable(j, 1, Calculus.VariableCharacter.j)).Replace("V(x)", "v");
        /// <summary>
        /// Converts the Vector into a string value in the standard form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the standard form.</returns>
        public string ToStandardForm()
        => $"{Mathematics.CreateSideEquation(new Calculus.Variable(1, 1, Calculus.VariableCharacter.y), new Calculus.Variable(-MiddlePoint.Y, 0))} = "
            + $"{(Slope == 1 ? "" : Slope == -1 ? "-" : Slope.ToString())}"
            + $"({Mathematics.CreateSideEquation(new Calculus.Variable(), new Calculus.Variable(-MiddlePoint.X, 0))})";
        /// <summary>
        /// Converts the Vector into a string value in the function form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the function form.</returns>
        public string ToFunctionForm()
        => Mathematics.CreateFunction(Calculus.FunctionCharacter.Y
            , new Calculus.Variable(Slope, 1)
            , new Calculus.Variable(-(MiddlePoint.X * Slope - MiddlePoint.Y), 0)).Replace("Y(x)", "y");
        /// <summary>
        /// Converts the Vector into a string value in the function form.
        /// </summary>
        /// <param name="function">The formed Function by the Vector.</param>
        /// <returns>A string value that represents the Vector in the function form.</returns>
        public string ToFunctionForm(out Calculus.Function function)
        => Mathematics.CreateFunction(Calculus.FunctionCharacter.Y, out function
            , new Calculus.Variable(Slope, 1)
            , new Calculus.Variable(-(MiddlePoint.X * Slope - MiddlePoint.Y), 0)).Replace("Y(x)", "y");
        /// <summary>
        /// Converts the Vector into a string value in the equation form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the equation form.</returns>
        public string ToEquationForm()
        => Mathematics.CreateEquation(
            new Calculus.Variable(-Slope, 1)
            , new Calculus.Variable(1, 1, Calculus.VariableCharacter.y)
            , new Calculus.Variable(MiddlePoint.X * Slope - MiddlePoint.Y, 0));
        /// <summary>
        /// Converts the Vector into a string value in the equation form.
        /// </summary>
        /// <param name="equation">The formed Equation by the Vector.</param>
        /// <returns>A string value that represents the Vector in the equation form.</returns>
        public string ToEquationForm(out Calculus.Equation equation)
        => Mathematics.CreateEquation(out equation,
            new Calculus.Variable(-Slope, 1)
            , new Calculus.Variable(1, 1, Calculus.VariableCharacter.y)
            , new Calculus.Variable(MiddlePoint.X * Slope - MiddlePoint.Y, 0));
        /// <summary>
        /// Converts the Vector into a string value in the components form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the components form.</returns>
        public string ToComponentsForm()
        => $"v = <{i}, {j}>";
        /// <summary>
        /// Converts the Vector into a string value in the magnitude form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the magnitude form.</returns>
        public string ToMagnitudeForm()
        => $"[ {Magnitude} , {Angle} ]";
        /// <summary>
        /// Converts the Vector into a Complex Number.
        /// </summary>
        /// <returns>A Complex Number that represents the Vector.</returns>
        public Complex ToComplex()
        => new Complex(i, j * Mathematics.i);
        /// <summary>
        /// Converts the Vector into a two-dimensional only-one-column Matrix.
        /// </summary>
        /// <returns>A Matrix that represents the Vector.</returns>
        public Matrix<double> ToMatrix()
        => new Matrix<double>(1, 2).Fill(new double[] { i, j });

        /// <summary>
        /// Converts the Vector into a string value.
        /// </summary>
        /// <returns>A string value that represents the Vector.</returns>
        public override string ToString()
        => ToIllustrativeForm();
        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// A three dimensional vector, which is a line that starts at a Point A, and ends at a Point B.
    /// </summary>
    public class Vector3D
    {
        /// <summary>
        /// The Start Point of the Vector.
        /// </summary>
        private Point startPoint;
        /// <summary>
        /// The End Point of the Vector.
        /// </summary>
        private Point endPoint;
        /// <summary>
        /// The Start Point of the Vector.
        /// </summary>
        public Point StartPoint { get { return startPoint; } set { startPoint = value; } }
        /// <summary>
        /// The End Point of the Vector.
        /// </summary>
        public Point EndPoint { get { return endPoint; } set { endPoint = value; } }

        /// <summary>
        /// The length of the Vector on the Real-Axis.
        /// </summary>
        public double Magnitude { get { return startPoint.GetDistance(endPoint); } }
        /// <summary>
        /// The Middle Point of the Vector on the Real-Axis.
        /// </summary>
        public Point MiddlePoint { get { return new Point((endPoint.X + startPoint.X) / 2, (endPoint.Y + startPoint.Y) / 2, (endPoint.Z + startPoint.Z) / 2); } }
        /// <summary>
        /// Returns the Vector based into the Origin, (Point (0, 0, 0)).
        /// </summary>
        public Vector3D Based { get { return new Vector3D(new Point(0, 0, 0), new Point(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y, endPoint.Z - startPoint.Z)); } }
        /// <summary>
        /// The component 'i' of the Vector.
        /// </summary>
        public double i { get { return Based.EndPoint.X; } }
        /// <summary>
        /// The component 'j' of the Vector.
        /// </summary>
        public double j { get { return Based.EndPoint.Y; } }
        /// <summary>
        /// The component 'k' of the Vector.
        /// </summary>
        public double k { get { return Based.EndPoint.Z; } }
        /// <summary>
        /// Returns the Vector normalized into a length of One.
        /// </summary>
        public Vector3D Normalized
        {
            get
            {
                double x = (endPoint.X - startPoint.X) / Magnitude;
                double y = (endPoint.Y - startPoint.Y) / Magnitude;
                double z = (endPoint.Z - startPoint.Z) / Magnitude;
                return new Vector3D(new Point(0, 0, 0), new Point(x, y, z));
            }
        }
        /// <summary>
        /// The Cosine of each angle of the Vector.
        /// </summary>
        public double[] DirectionCosines { get { return new double[3] { i / Magnitude, j / Magnitude, k / Magnitude }; } }
        /// <summary>
        /// The angles the Vector makes with all of the axis, (measured in Degrees).
        /// </summary>
        public double[] Angles { get { return new double[3] { Mathematics.Arccos(DirectionCosines[0]), Mathematics.Arccos(DirectionCosines[1]), Mathematics.Arccos(DirectionCosines[2]) }; } }
        /// <summary>
        /// The angle the Vector makes with the X axis, (measured in Degrees).
        /// </summary>
        public double AngleX { get { return Angles[0]; } }
        /// <summary>
        /// The angle the Vector makes with the Y axis, (measured in Degrees).
        /// </summary>
        public double AngleY { get { return Angles[1]; } }
        /// <summary>
        /// The angle the Vector makes with the Z axis, (measured in Degrees).
        /// </summary>
        public double AngleZ { get { return Angles[2]; } }
        /// <summary>
        /// The Functions of the Vector.
        /// </summary>
        public Calculus.Function[] Functions { get { Calculus.Function[] functions; ToFunctionsForm(out functions); return functions; } }
        /// <summary>
        /// The Equations of the Vector.
        /// </summary>
        public Calculus.Equation[] Equations { get { Calculus.Equation[] equations; ToEquationsForm(out equations); return equations; } }
        /// <summary>
        /// Returns the Vector pointing in the reversed direction. 
        /// </summary>
        public Vector3D Inverse { get { return -this; } }

        /// <summary>
        /// Checks if the Vector parallels another Vector.
        /// </summary>
        /// <param name="vector">The other selected Vector.</param>
        /// <returns>A boolean that represents wether or not the two Vectors parallel each other.</returns>
        public bool Parallels(Vector3D vector) => AngleWith(vector) == 0 || AngleWith(vector) == 180;
        /// <summary>
        /// Checks if the Vector perpendiculates another Vector.
        /// </summary>
        /// <param name="vector">The other selected Vector.</param>
        /// <returns>A boolean that represents wether or not the two Vectors perpendiculate each other.</returns>
        public bool Perpendiculates(Vector3D vector) => AngleWith(vector) == 90 || AngleWith(vector) == 270;
        /// <summary>
        /// Finds the angle that's formed by this Vector and another Vector, (measured in Degrees).
        /// </summary>
        /// <param name="vector">The other selected Vector.</param>
        /// <returns>The angle that's formed by the two Vectors, (measured in Degrees).</returns>
        public double AngleWith(Vector3D vector)
        => Mathematics.Arccos((this * vector) / (Magnitude * vector.Magnitude));

        /// <summary>
        /// A shortcut for writing a Vector heading Right.
        /// </summary>
        public static Vector3D Right { get { return new Vector3D(new Point(+1, 0, 0)); } }
        /// <summary>
        /// A shortcut for writing a Vector heading Left.
        /// </summary>
        public static Vector3D Left { get { return new Vector3D(new Point(-1, 0, 0)); } }
        /// <summary>
        /// A shortcut for writing a Vector heading Up.
        /// </summary>
        public static Vector3D Up { get { return new Vector3D(new Point(0, +1, 0)); } }
        /// <summary>
        /// A shortcut for writing a Vector heading Down.
        /// </summary>
        public static Vector3D Down { get { return new Vector3D(new Point(0, -1, 0)); } }
        /// <summary>
        /// A shortcut for writing a Vector heading Forwards.
        /// </summary>
        public static Vector3D Forward { get { return new Vector3D(new Point(0, 0, +1)); } }
        /// <summary>
        /// A shortcut for writing a Vector heading Backwards.
        /// </summary>
        public static Vector3D Backward { get { return new Vector3D(new Point(0, 0, -1)); } }
        /// <summary>
        /// The illustrative form of a Vector.
        /// </summary>
        public const string IllustrativeForm = "[(x1, y1, z1) <--> (x2, y2, z2)]";
        /// <summary>
        /// The algebraic form of a Vector.
        /// </summary>
        public const string AlgebraicForm = "v = xi + yj + zk";
        /// <summary>
        /// The standard form of a Vector.
        /// </summary>
        public const string StandardForm = "(x - x0) / a = (y - y0) / b = (z - z0) / c = λ";
        /// <summary>
        /// The functions form of a Vector.
        /// </summary>
        public const string FunctionsForm = "y = ax + d , z = ax + d";
        /// <summary>
        /// The equations form of a Vector.
        /// </summary>
        public const string EquationsForm = "ax + by + d = 0 , ax + cz + d = 0";
        /// <summary>
        /// The components form of a Vector.
        /// </summary>
        public const string ComponentsForm = "v = <x, y, z>";
        /// <summary>
        /// The magnitude form of a Vector.
        /// </summary>
        public const string MagnitudeForm = "[ ||v||, θx, θy, θz ]";

        /// <summary>
        /// Builds up a new three-dimensional Vector.
        /// </summary>
        public Vector3D()
        {
            startPoint = new Point(0, 0, 0);
            endPoint = new Point(0, 0, 0);
        }
        /// <summary>
        /// Builds up a new three-dimensional Vector by declaring only one Point, (so the Start Point'll be from Point (0, 0, 0)).
        /// </summary>
        /// <param name="point">The selected Point that the three-dimensional Vector'll end at.</param>
        public Vector3D(Point point)
        {
            startPoint = new Point(0, 0, 0);
            endPoint = new Point(point.X, point.Y, point.Z);
        }
        /// <summary>
        /// Builds up a new three-dimensional Vector by declaring a Start Point, and an End Point.
        /// </summary>
        /// <param name="startPoint">The Start Point of the three-dimensional Vector.</param>
        /// <param name="endPoint">The End Point of the three-dimensional Vector.</param>
        public Vector3D(Point startPoint, Point endPoint)
        {
            this.startPoint = new Point(startPoint.X, startPoint.Y, startPoint.Z);
            this.endPoint = new Point(endPoint.X, endPoint.Y, endPoint.Z);
        }
        /// <summary>
        /// Builds up a new three-dimensional Vector by declaring its components.
        /// </summary>
        /// <param name="i">The amount of displacement of the three-dimensional Vector on the X axis.</param>
        /// <param name="j">The amount of displacement of the three-dimensional Vector on the Y axis.</param>
        /// <param name="k">The amount of displacement of the three-dimensional Vector on the Z axis.</param>
        public Vector3D(double i, double j, double k) : this(new Point(i, j, k)) { }
        /// <summary>
        /// Builds up a new three-dimensional Vector with a magnitude of One, by declaring two angles.
        /// </summary>
        /// <param name="θ1">The first selected angle, (measured in Degrees).</param>
        /// <param name="θ2">The second selected angle, (measured in Degrees).</param>
        public Vector3D(double θ1, double θ2) : this(Mathematics.Cos(θ1), Mathematics.Cos(θ2),
                                                     Mathematics.SquareRoot(Mathematics.Absolute(1 - Mathematics.Square(Mathematics.Cos(θ1)) - Mathematics.Square(Mathematics.Cos(θ2)))))
        { endPoint /= Magnitude; }

        #region #Conversions
        public static implicit operator Vector3D(Vector2D vector)
        => new Vector3D(vector.StartPoint, vector.EndPoint);
        #endregion
        #region #Operators With a Number
        public static Vector3D operator *(Vector3D vector, double v)
        => new Vector3D(vector.startPoint * v, vector.endPoint * v);
        public static Vector3D operator *(double v, Vector3D vector)
        => new Vector3D(vector.startPoint * v, vector.endPoint * v);
        public static Vector3D operator /(Vector3D vector, double v)
        => new Vector3D(vector.startPoint / v, vector.endPoint / v);
        public static Vector3D operator /(double v, Vector3D vector)
        => new Vector3D(v / vector.startPoint, v / vector.endPoint);
        #endregion
        #region #Operators With Another Vector
        public static Vector3D operator +(Vector3D vector1, Vector3D vector2)
        => new Vector3D(vector1.StartPoint + vector2.StartPoint, vector1.EndPoint + vector2.EndPoint);
        public static Vector3D operator -(Vector3D vector1, Vector3D vector2)
        => new Vector3D(vector1.StartPoint - vector2.StartPoint, vector1.EndPoint - vector2.EndPoint);
        public static double operator *(Vector3D vector1, Vector3D vector2)
        => vector1.i * vector2.i + vector1.j * vector2.j + vector1.k * vector2.k;
        public static Vector3D operator ^(Vector3D vector1, Vector3D vector2)
        => new Vector3D(
            new Matrix2<double>().Fill(new double[] { vector1.j, vector1.k, vector2.j, vector2.k }).Determenant,
           -new Matrix2<double>().Fill(new double[] { vector1.i, vector1.k, vector2.i, vector2.k }).Determenant,
            new Matrix2<double>().Fill(new double[] { vector1.i, vector1.j, vector2.i, vector2.j }).Determenant);
        #endregion
        #region #Operators With a Matrix
        public static Vector3D operator *(Matrix3<double> matrix, Vector3D vector)
        {
            Matrix<double> result = matrix * vector.ToMatrix();
            return new Vector3D(result[0, 0], result[0, 1], result[0, 2]);
        }
        public static Vector3D operator *(Matrix3<int> matrix, Vector3D vector)
        {
            List<double> list = new List<double>();
            foreach (var item in matrix.ToList()) { list.Add(item); }
            Matrix3<double> matrix_ = new Matrix3<double>().Fill(list);
            return matrix_ * vector;
        }
        public static Vector3D operator *(Matrix3<float> matrix, Vector3D vector)
        {
            List<double> list = new List<double>();
            foreach (var item in matrix.ToList()) { list.Add(item); }
            Matrix3<double> matrix_ = new Matrix3<double>().Fill(list);
            return matrix_ * vector;
        }
        public static Vector3D operator *(Matrix3<decimal> matrix, Vector3D vector)
        {
            List<double> list = new List<double>();
            foreach (var item in matrix.ToList()) { list.Add(double.Parse(item.ToString())); }
            Matrix3<double> matrix_ = new Matrix3<double>().Fill(list);
            return matrix_ * vector;
        }
        #endregion
        #region #Operators Alone
        public static Vector3D operator +(Vector3D vector)
        => vector;
        public static Vector3D operator -(Vector3D vector)
        => vector * -1;
        #endregion

        /// <summary>
        /// Converts the Vector into a string value in the illustrative form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the illustrative form.</returns>
        public string ToIllustrativeForm()
        => $"[{startPoint} <--> {endPoint}]";
        /// <summary>
        /// Converts the Vector into a string value in the algebraic form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the algebraic form.</returns>
        public string ToAlgebraicForm()
        => Mathematics.CreateFunction(Calculus.FunctionCharacter.V
            , new Calculus.Variable(i, 1, Calculus.VariableCharacter.i)
            , new Calculus.Variable(j, 1, Calculus.VariableCharacter.j)
            , new Calculus.Variable(k, 1, Calculus.VariableCharacter.k)).Replace("V(x)", "v");
        /// <summary>
        /// Converts the Vector into a string value in the standard form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the standard form.</returns>
        public string ToStandardForm()
        {
            string x = "(" + Mathematics.CreateSideEquation(new Calculus.Variable()
                                                     , new Calculus.Variable(-startPoint.X, 0)) + ") / " + (i),
                   y = "(" + Mathematics.CreateSideEquation(new Calculus.Variable(1, 1, Calculus.VariableCharacter.y)
                                                     , new Calculus.Variable(-startPoint.Y, 0)) + ") / " + (j),
                   z = "(" + Mathematics.CreateSideEquation(new Calculus.Variable(1, 1, Calculus.VariableCharacter.z)
                                                     , new Calculus.Variable(-startPoint.Z, 0)) + ") / " + (k);
            return $"{x} = {y} = {z} = λ";
        }
        /// <summary>
        /// Converts the Vector into a string value in the functions form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the functions form.</returns>
        public string ToFunctionsForm()
        {
            //(x - x0) / a = (y - y0) / b = (z - z0) / c = λ
            // y = bx/a - bx0/a + y0
            // z = cx/a - cx0/a + z0
            string y = Mathematics.CreateFunction(Calculus.FunctionCharacter.Y
                          , new Calculus.Variable(j / i)
                          , new Calculus.Variable(-j / i * startPoint.X, 0)
                          , new Calculus.Variable(startPoint.Y, 0)).Replace("Y(x)", "y"),
                   z = Mathematics.CreateFunction(Calculus.FunctionCharacter.Z
                          , new Calculus.Variable(k / i)
                          , new Calculus.Variable(-k / i * startPoint.X, 0)
                          , new Calculus.Variable(startPoint.Z, 0)).Replace("Z(x)", "z");
            return $"{y} , {z}";
        }
        /// <summary>
        /// Converts the Vector into a string value in the functions form.
        /// </summary>
        /// <param name="functions">The formed Functions by the Vector.</param>
        /// <returns>A string value that represents the Vector in the functions form.</returns>
        public string ToFunctionsForm(out Calculus.Function[] functions)
        {
            functions = new Calculus.Function[2];
            string y = Mathematics.CreateFunction(Calculus.FunctionCharacter.Y
                          , out functions[0]
                          , new Calculus.Variable(j / i)
                          , new Calculus.Variable(-j / i * startPoint.X, 0)
                          , new Calculus.Variable(startPoint.Y, 0)).Replace("Y(x)", "y"),
                   z = Mathematics.CreateFunction(Calculus.FunctionCharacter.Z
                          , out functions[1]
                          , new Calculus.Variable(k / i)
                          , new Calculus.Variable(-k / i * startPoint.X, 0)
                          , new Calculus.Variable(startPoint.Z, 0)).Replace("Z(x)", "z");
            return $"{y} , {z}";
        }
        /// <summary>
        /// Converts the Vector into a string value in the equations form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the equations form.</returns>
        public string ToEquationsForm()
        {
            //(x - x0) / a = (y - y0) / b = (z - z0) / c = λ
            // bx/a - bx0/a - y + y0 = 0
            // cx/a - cx0/a - z + z0 = 0
            string y = Mathematics.CreateEquation(
                       new Calculus.Variable(j / i)
                       , new Calculus.Variable(-j / i * startPoint.X, 0)
                       , new Calculus.Variable(-1, 1, Calculus.VariableCharacter.y)
                       , new Calculus.Variable(startPoint.Y, 0)),
                   z = Mathematics.CreateEquation(
                       new Calculus.Variable(k / i)
                       , new Calculus.Variable(-k / i * startPoint.X, 0)
                       , new Calculus.Variable(-1, 1, Calculus.VariableCharacter.z)
                       , new Calculus.Variable(startPoint.Z, 0));
            return $"{y} , {z}";
        }
        /// <summary>
        /// Converts the Vector into a string value in the equations form.
        /// </summary>
        /// <param name="equations">The formed Equation by the Vector.</param>
        /// <returns>A string value that represents the Vector in the equations form.</returns>
        public string ToEquationsForm(out Calculus.Equation[] equations)
        {
            equations = new Calculus.Equation[2];
            string y = Mathematics.CreateEquation(out equations[0]
                       , new Calculus.Variable(j / i)
                       , new Calculus.Variable(-j / i * startPoint.X, 0)
                       , new Calculus.Variable(-1, 1, Calculus.VariableCharacter.y)
                       , new Calculus.Variable(startPoint.Y, 0)),
                   z = Mathematics.CreateEquation(out equations[1]
                       , new Calculus.Variable(k / i)
                       , new Calculus.Variable(-k / i * startPoint.X, 0)
                       , new Calculus.Variable(-1, 1, Calculus.VariableCharacter.z)
                       , new Calculus.Variable(startPoint.Z, 0));
            return $"{y} , {z}";
        }
        /// <summary>
        /// Converts the Vector into a string value in the components form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the components form.</returns>
        public string ToComponentsForm()
        => $"v = <{i}, {j}, {k}>";
        /// <summary>
        /// Converts the Vector into a string value in the magnitude form.
        /// </summary>
        /// <returns>A string value that represents the Vector in the magnitude form.</returns>
        public string ToMagnitudeForm()
        => $"[ {Magnitude} , {AngleX} , {AngleY}, {AngleZ} ]";
        /// <summary>
        /// Converts the Vector into a two-dimensional only-one-column Matrix.
        /// </summary>
        /// <returns>A Matrix that represents the Vector.</returns>
        public Matrix<double> ToMatrix()
        => new Matrix<double>(1, 3).Fill(new double[] { i, j, k });

        /// <summary>
        /// Converts the Vector into a string value.
        /// </summary>
        /// <returns>A string value that represents the Vector.</returns>
        public override string ToString()
        => ToIllustrativeForm();
        public override int GetHashCode()
        => base.GetHashCode();
        public override bool Equals(object obj)
        => base.Equals(obj);
    }
    /// <summary>
    /// A curve obtained as the intersection of the surface of a cone with a plane.
    /// </summary>
    public class ConicSection
    {
        /// <summary>
        /// The center point of the Conic Section.
        /// </summary>
        public Point CenterPoint { get; set; }

        //public ConicSection(Vector2D vector)
        //{

        //}
    }
    /// <summary>
    /// An ellipse, which is a Conic Section that has an area and all of its point are connected.
    /// </summary>
    public class Ellipse : ConicSection
    {
        /// <summary>
        /// The bigger radius of the Ellpise' radiuses.
        /// </summary>
        public double MainRadius { get; set; }
        /// <summary>
        /// The smaller radius of the Ellpise' radiuses.
        /// </summary>
        public double SecondRadius { get; set; }

        /// <summary>
        /// Builds up a new Ellipse with radiuses of length One.
        /// </summary>
        public Ellipse() : this(1, 1) { }
        /// <summary>
        /// Builds up a new Ellipse with its radiuses.
        /// </summary>
        /// <param name="mainRadius">The selected length of the bigger radius of the Ellipse' radiuses.</param>
        /// <param name="secondRadius">The selected length of the bigger radius of the Ellipse' radiuses.</param>
        public Ellipse(double mainRadius, double secondRadius) :this(mainRadius,secondRadius,new Point(0, 0)) { }
        /// <summary>
        /// Builds up a new Ellipse with its radiuses and its center point.
        /// </summary>
        /// <param name="mainRadius">The selected length of the bigger radius of the Ellipse' radiuses.</param>
        /// <param name="secondRadius">The selected length of the bigger radius of the Ellipse' radiuses.</param>
        /// <param name="centerPoint">The selected Point to be the Ellipse' center Point.</param>
        public Ellipse(double mainRadius, double secondRadius, Point centerPoint)
        {
            MainRadius = mainRadius;
            SecondRadius = secondRadius;
            CenterPoint = centerPoint;
        }
    }
    #endregion

    #endregion

    #region #Exceptions
    
    /// <summary>
    /// Occurs when attempting to add or substract two Imaginary Numbers with different powers.
    /// </summary>
    [Serializable]
    public class DifferentPowerImaginaryNumbersAdditionOrSubstractionException : Exception
    {
        /// <summary>
        /// Throws a Different Power Imaginary Numbers Addition or Substraction Exception.
        /// </summary>
        public DifferentPowerImaginaryNumbersAdditionOrSubstractionException() : base("Cannot add or substract two Imaginary Numbers with different powers.") { }
    }
    /// <summary>
    /// Occurs when attempting to multiplie two Matrices with no shared width and height.
    /// </summary>
    [Serializable]
    public class NonmultiplicationConformableMatricesException : Exception
    {
        /// <summary>
        /// Throws a Non-Multiplication Conformable Matrices Exception.
        /// </summary>
        public NonmultiplicationConformableMatricesException() : base("Cannot multiplie two Nonmultiplication Conformable Matrices.") { }
    }
    /// <summary>
    /// Occurs when attempting to caculate the determenant of a non-square Matrix.
    /// </summary>
    [Serializable]
    public class DetermenantOfNonquadraticMatrixException : Exception
    {
        /// <summary>
        /// Throws a Determenant of Non-Quadratic Matrix Exception.
        /// </summary>
        public DetermenantOfNonquadraticMatrixException() : base("Cannot calculate the determenant of a non-quadratic Matrix.") { }
    }
    /// <summary>
    /// Occurs when attempting to compute the adjoint of a non-square Matrix.
    /// </summary>
    [Serializable]
    public class AdjointOfNonquadraticMatrixException : Exception
    {
        /// <summary>
        /// Throws an Adjoint of Non-Quadratic Matrix Exception.
        /// </summary>
        public AdjointOfNonquadraticMatrixException() : base("Cannot compute the adjoint of a non-quadratic Matrix.") { }
    }
    /// <summary>
    /// Occurs when attempting to compute the inverse of a non-square Matrix.
    /// </summary>
    [Serializable]
    public class InverseOfNonquadraticMatrixException : Exception
    {
        /// <summary>
        /// Throws an Inverse of Non-Quadratic Matrix Exception.
        /// </summary>
        public InverseOfNonquadraticMatrixException() : base("Cannot compute the inverse of a non-quadratic Matrix.") { }
    }
    /// <summary>
    /// Occurs when attempting to reverse an irreversible Matrix.
    /// </summary>
    [Serializable]
    public class IrreversibleMatrixException : Exception
    {
        /// <summary>
        /// Throws an Irreversible Matrix Exception.
        /// </summary>
        public IrreversibleMatrixException() : base("Cannot reverse an irreversible Matrix.") { }
    }
    /// <summary>
    /// Occurs when attempting to divide with an irreversible Matrix.
    /// </summary>
    [Serializable]
    public class DivideByIrreversibleMatrixException : Exception
    {
        /// <summary>
        /// Throws a Divide by Irreversible Matrix Exception.
        /// </summary>
        public DivideByIrreversibleMatrixException() : base("Cannot divide by an irreversible Matrix.") { }
    }

    #endregion

    /// <summary>
    /// Contains everything about Differentiation, Derivation, Integration, etc..
    /// </summary>
    namespace Calculus
    {
        /// <summary>
        /// The type of the Variable within a Function.
        /// </summary>
        public enum VariableCharacter
        {
            ///<summary>The letter A.</summary>
            a,
            ///<summary>The letter B.</summary>
            b,
            ///<summary>The letter C.</summary>
            c,
            ///<summary>The letter D.</summary>
            d,
            ///<summary>The letter E.</summary>
            e,
            ///<summary>The letter F.</summary>
            f,
            ///<summary>The letter G.</summary>
            g,
            ///<summary>The letter H.</summary>
            h,
            ///<summary>The letter I.</summary>
            i,
            ///<summary>The letter J.</summary>
            j,
            ///<summary>The letter K.</summary>
            k,
            ///<summary>The letter L.</summary>
            l,
            ///<summary>The letter M.</summary>
            m,
            ///<summary>The letter N.</summary>
            n,
            ///<summary>The letter O.</summary>
            o,
            ///<summary>The letter P.</summary>
            p,
            ///<summary>The letter Q.</summary>
            q,
            ///<summary>The letter R.</summary>
            r,
            ///<summary>The letter S.</summary>
            s,
            ///<summary>The letter T.</summary>
            t,
            ///<summary>The letter U.</summary>
            u,
            ///<summary>The letter V.</summary>
            v,
            ///<summary>The letter W.</summary>
            w,
            ///<summary>The letter X.</summary>
            x,
            ///<summary>The letter Y.</summary>
            y,
            ///<summary>The letter Z.</summary>
            z
        }
        /// <summary>
        /// Represents a Variable, in any form.
        /// </summary>
        public class Variable
        {
            /// <summary>
            /// The form of the Variable.
            /// </summary>
            private string form = "#";
            /// <summary>
            /// Gives the proverbs of the Variable.
            /// </summary>
            private double proverbs = 1;
            /// <summary>
            /// The power that the Variable is raised to.
            /// </summary>
            private double power = 1;
            /// <summary>
            /// The character of the Variable.
            /// </summary>
            private VariableCharacter character;
            /// <summary>
            /// The form of the Variable.
            /// </summary>
            public string Form { get { return form; } }
            /// <summary>
            /// Gives the proverbs of the Variable.
            /// </summary>
            public double Proverbs { get { return proverbs; } }
            /// <summary>
            /// The power that the Variable is raised to.
            /// </summary>
            public double Power { get { return power; } }
            /// <summary>
            /// The character of the Variable.
            /// </summary>
            public VariableCharacter Character { get { return character; } }

            /// <summary>
            /// Builds up a Variable.
            /// </summary>
            public Variable()
            { character = VariableCharacter.x; SetForm(); }
            /// <summary>
            /// Builds up a Variable with proverbs only.
            /// </summary>
            /// <param name="proverbs">The proverbs of the Variable.</param>
            public Variable(double proverbs) : this()
            { this.proverbs = proverbs; SetForm(); }
            /// <summary>
            /// Builds up a Variable with proverbs and a power.
            /// </summary>
            /// <param name="proverbs">The proverbs of the Variable.</param>
            /// <param name="power">The power that the Variable is raised to.</param>
            public Variable(double proverbs, double power) : this(proverbs)
            { this.power = power; SetForm(); }
            /// <summary>
            /// Builds up a Variable fulfuilled.
            /// </summary>
            /// <param name="proverbs">The proverbs of the Variable.</param>
            /// <param name="power">The power that the Variable is raised to.</param>
            /// <param name="character">The character of the Variable.</param>
            public Variable(double proverbs, double power, VariableCharacter character) : this(proverbs, power)
            { this.character = character; SetForm(); }

            /// <summary>
            /// Sets the form of the Variable.
            /// </summary>
            private void SetForm()
            {
                string proverbs = this.proverbs == 1 || this.proverbs == 0 ? "" : this.proverbs == -1 ? "-" : this.proverbs.ToString();
                string power = this.power == 1 || this.power == 0 ? "" : this.power < 0 ? $"^({this.power})" : "^" + this.power;
                form = this.proverbs == 0 ? "0" : this.power == 0 ? this.proverbs == 1 || this.proverbs == -1 ? this.proverbs.ToString() : proverbs : proverbs + character.ToString() + power;
            }

            /// <summary>
            /// Calculates the value of the Variable accordinig to a giving value.
            /// </summary>
            /// <param name="number">The number that its value will be giving.</param>
            /// <returns>The value of the Variable when it's replaced with the selected giving value.</returns>
            public double this[double number]
            { get { return proverbs * Mathematics.Power(number, power); } }
            /// <summary>
            /// Converts the Variable into a string value.
            /// </summary>
            /// <returns>A string value that represents the Variable.</returns>
            public override string ToString()
            => form;
            public override int GetHashCode()
            => base.GetHashCode();
            public override bool Equals(object obj)
            => base.Equals(obj);
        }
        /// <summary>
        /// The type of the Function.
        /// </summary>
        public enum FunctionCharacter
        {
            ///<summary>The Sine Function.</summary>
            Sin,
            ///<summary>The Cosine Function.</summary>
            Cos,
            ///<summary>The Tangent Function.</summary>
            Tan,
            ///<summary>The Cotangent Function.</summary>
            Cot,
            ///<summary>The Secant Function.</summary>
            Sec,
            ///<summary>The Cosecant Function.</summary>
            Csc,
            ///<summary>The Arcsine Function.</summary>
            Arcsin,
            ///<summary>The Arccosine Function.</summary>
            Arccos,
            ///<summary>The Arctangent Function.</summary>
            Arctan,
            ///<summary>The Arccotangent Function.</summary>
            Arccot,
            ///<summary>The Arcsecant Function.</summary>
            Arcsec,
            ///<summary>The Arccosecant Function.</summary>
            Arccsc,
            ///<summary>The Hyperbolic Sine Function.</summary>
            Sinh,
            ///<summary>The Hyperbolic Cosine Function.</summary>
            Cosh,
            ///<summary>The Hyperbolic Tangent Function.</summary>
            Tanh,
            ///<summary>The Hyperbolic Cotangent Function.</summary>
            Coth,
            ///<summary>The Hyperbolic Secant Function.</summary>
            Sech,
            ///<summary>The Hyperbolic Cosecant Function.</summary>
            Csch,
            ///<summary>The Hyperbolic Arcsine Function.</summary>
            Arcsinh,
            ///<summary>The Hyperbolic Arccosine Function.</summary>
            Arccosh,
            ///<summary>The Hyperbolic Arctangent Function.</summary>
            Arctanh,
            ///<summary>The Hyperbolic Arccotangent Function.</summary>
            Arccoth,
            ///<summary>The Hyperbolic Arcsecant Function.</summary>
            Arcsech,
            ///<summary>The Hyperbolic Arccosecant Function.</summary>
            Arccsch,
            ///<summary>The Natural Logarithm Function.</summary>
            Ln,
            ///<summary>The letter A.</summary>
            A,
            ///<summary>The letter B.</summary>
            B,
            ///<summary>The letter C.</summary>
            C,
            ///<summary>The letter D.</summary>
            D,
            ///<summary>The letter E.</summary>
            E,
            ///<summary>The letter F.</summary>
            F,
            ///<summary>The letter G.</summary>
            G,
            ///<summary>The letter H.</summary>
            H,
            ///<summary>The letter I.</summary>
            I,
            ///<summary>The letter J.</summary>
            J,
            ///<summary>The letter K.</summary>
            K,
            ///<summary>The letter L.</summary>
            L,
            ///<summary>The letter M.</summary>
            M,
            ///<summary>The letter N.</summary>
            N,
            ///<summary>The letter O.</summary>
            O,
            ///<summary>The letter P.</summary>
            P,
            ///<summary>The letter Q.</summary>
            Q,
            ///<summary>The letter R.</summary>
            R,
            ///<summary>The letter S.</summary>
            S,
            ///<summary>The letter T.</summary>
            T,
            ///<summary>The letter U.</summary>
            U,
            ///<summary>The letter V.</summary>
            V,
            ///<summary>The letter W.</summary>
            W,
            ///<summary>The letter X.</summary>
            X,
            ///<summary>The letter Y.</summary>
            Y,
            ///<summary>The letter Z.</summary>
            Z
        }
        /// <summary>
        /// Represents a Function, which contains Variables sorted in a one sided Equation.
        /// </summary>
        public class Function
        {
            /// <summary>
            /// The form of the Function.
            /// </summary>
            private string form = "#()";
            /// <summary>
            /// The character of the Function.
            /// </summary>
            private FunctionCharacter character;
            /// <summary>
            /// The Variables stored in the Function.
            /// </summary>
            private List<Variable> variables = new List<Variable>();
            /// <summary>
            /// The form of the Function.
            /// </summary>
            public string Form { get { SetForm(); return form; } }
            /// <summary>
            /// The form of the Function.
            /// </summary>
            public FunctionCharacter Character { get { return character; } }
            /// <summary>
            /// The Variables stored in the Function.
            /// </summary>
            public List<Variable> Variables { get { return variables; } }

            /// <summary>
            /// Builds up a Function.
            /// </summary>
            public Function()
            { character = FunctionCharacter.F; }
            /// <summary>
            /// Builds up a Function with a set of Variables.
            /// </summary>
            /// <param name="variables">The selected Variables to insert into the Function.</param>
            public Function(params Variable[] variables)
            {
                character = FunctionCharacter.F;
                this.variables = variables.ToList();
            }
            /// <summary>
            /// Builds up a Function with a specified character.
            /// </summary>
            /// <param name="character">The character of the Function.</param>
            public Function(FunctionCharacter character)
            { this.character = character; }
            /// <summary>
            /// Builds up a Function with a specified character.
            /// </summary>
            /// <param name="character">The character of the Function.</param>
            /// <param name="variables">The selected Variables to insert into the Function.</param>
            public Function(FunctionCharacter character, params Variable[] variables)
            {
                this.character = character;
                this.variables = variables.ToList();
            }

            /// <summary>
            /// Sets the form of the Function.
            /// </summary>
            private void SetForm()
            => form = character + "(x) = " + Mathematics.CreateSideEquation(variables.ToArray());

            /// <summary>
            /// Adds a Variable into the Function.
            /// </summary>
            /// <param name="variable">The Variable that'll be added.</param>
            public void Add(Variable variable)
            {
                bool found = false;
                int j = -1;
                for (int i = 0; i < variables.Count; i++)
                {
                    if (variable.Power == this[i].Power && (variable.Character == this[i].Character || variable.Power == 0))
                    {
                        found = true;
                        j = i;
                        break;
                    }
                }
                if (!found)
                { variables.Insert(variables.Count, variable); }
                else
                { this[j] = new Variable(this[j].Proverbs + variable.Proverbs, this[j].Power, this[j].Character); }
                SortVariables();
            }
            /// <summary>
            /// Adds Variables into the Function.
            /// </summary>
            /// <param name="variables">The Variables that'll be added.</param>
            public void AddRange(IEnumerable<Variable> variables)
            { foreach (var variable in variables) { Add(variable); } }

            /// <summary>
            /// Sorts the Variables of the Fuction alphabetically.
            /// </summary>
            private void SortVariables()
            {
                for (int i = 1; i < variables.Count; i++)
                {
                    if (variables[i].Power == 0)
                    {
                        var variable = variables[i];
                        variables[i] = variables[variables.Count - 1];
                        variables[variables.Count - 1] = variable;
                        continue;
                    }
                    int index1 = char.ConvertToUtf32(variables[i].Character.ToString(), 0),
                        index2 = char.ConvertToUtf32(variables[i - 1].Character.ToString(), 0);
                    if (index1 < index2 || variables[i - 1].Power == 0 || (index1 == index2 && variables[i].Power < variables[i - 1].Power))
                    {
                        var variable = variables[i];
                        variables[i] = variables[i - 1];
                        variables[i - 1] = variable;
                    }
                }
            }

            /// <summary>
            /// Gets a Variable from the Function's Variables.
            /// </summary>
            /// <param name="index">The index of the Variable.</param>
            /// <returns>A Variable sorted with the givin index.</returns>
            public Variable this[int index]
            {
                get { return variables[index]; }
                set { variables[index] = value; }
            }
            /// <summary>
            /// Gets a Variable from the Function's Variables.
            /// </summary>
            /// <returns>A Variable from the Function's Variables.</returns>
            public IEnumerator<Variable> GetEnumerator()
            { foreach (var variable in variables) { yield return variable; } }
            /// <summary>
            /// Converts the Function into a string value.
            /// </summary>
            /// <returns>A string value that represents the Function.</returns>
            public override string ToString()
            { SetForm(); return form; }
            public override int GetHashCode()
            => base.GetHashCode();
            public override bool Equals(object obj)
            => base.Equals(obj);
        }
        /// <summary>
        /// Represents an Equation, which contains Variables sorted in different ways.
        /// </summary>
        public class Equation
        {
            /// <summary>
            /// The form of the Equation.
            /// </summary>
            private string form;
            /// <summary>
            /// The Variables stored in the Function.
            /// </summary>
            private List<Variable> variables = new List<Variable>();
            /// <summary>
            /// The form of the Function.
            /// </summary>
            public string Form { get { SetForm(); return form; } }
            /// <summary>
            /// The Variables stored in the Function.
            /// </summary>
            public List<Variable> Variables { get { return variables; } }

            /// <summary>
            /// Builds up an Equation with a set of Variables.
            /// </summary>
            /// <param name="variables">The selected Variables to insert into the Function.</param>
            public Equation(params Variable[] variables)
            { AddRange(variables); }

            /// <summary>
            /// Sets the form of the Equation.
            /// </summary>
            private void SetForm()
            => form = Mathematics.CreateSideEquation(variables.ToArray()) + " = 0";

            /// <summary>
            /// Adds a Variable into the Equation.
            /// </summary>
            /// <param name="variable">The Variable that'll be added.</param>
            public void Add(Variable variable)
            {
                bool found = false;
                int j = -1;
                for (int i = 0; i < variables.Count; i++)
                {
                    if (variable.Power == this[i].Power && (variable.Character == this[i].Character || variable.Power == 0))
                    {
                        found = true;
                        j = i;
                        break;
                    }
                }
                if (!found)
                { variables.Insert(variables.Count, variable); }
                else
                { this[j] = new Variable(this[j].Proverbs + variable.Proverbs, this[j].Power, this[j].Character); }
                SortVariables();
            }
            /// <summary>
            /// Adds Variables into the Equation.
            /// </summary>
            /// <param name="variables">The Variables that'll be added.</param>
            public void AddRange(IEnumerable<Variable> variables)
            { foreach (var variable in variables) { Add(variable); } }

            /// <summary>
            /// Sorts the Variables of the Equation alphabetically.
            /// </summary>
            private void SortVariables()
            {
                for (int i_ = 0; i_ < 3; i_++)
                {
                    for (int i = 1; i < variables.Count; i++)
                    {
                        if (variables[i].Power == 0)
                        {
                            var variable = variables[i];
                            variables[i] = variables[variables.Count - 1];
                            variables[variables.Count - 1] = variable;
                            continue;
                        }
                        int index1 = char.ConvertToUtf32(variables[i].Character.ToString(), 0),
                            index2 = char.ConvertToUtf32(variables[i - 1].Character.ToString(), 0);
                        if (index1 < index2 || variables[i - 1].Power == 0 || (index1 == index2 && variables[i].Power < variables[i - 1].Power))
                        {
                            var variable = variables[i];
                            variables[i] = variables[i - 1];
                            variables[i - 1] = variable;
                        }
                    }
                }
            }

            /// <summary>
            /// Gets a Variable from the Equation's Variables.
            /// </summary>
            /// <param name="index">The index of the Variable.</param>
            /// <returns>A Variable sorted with the givin index.</returns>
            public Variable this[int index]
            {
                get { return variables[index]; }
                set { variables[index] = value; }
            }
            /// <summary>
            /// Gets a Variable from the Equation's Variables.
            /// </summary>
            /// <returns>A Variable from the Equation's Variables.</returns>
            public IEnumerator<Variable> GetEnumerator()
            { foreach (var variable in variables) { yield return variable; } }
            /// <summary>
            /// Converts the Equation into a string value.
            /// </summary>
            /// <returns>A string value that represents the Equation.</returns>
            public override string ToString()
            { SetForm(); return form; }
            public override int GetHashCode()
            => base.GetHashCode();
            public override bool Equals(object obj)
            => base.Equals(obj);
        }

        /// <summary>
        /// Everything about Derivation is stored here.
        /// </summary>
        public static class Derivation
        {
            /// <summary>
            /// Derivates a Variable.
            /// </summary>
            /// <param name="variable">The selected Variable.</param>
            /// <returns>A new Variable that represents the derivation of the selected old one.</returns>
            public static Variable Derivate(Variable variable)
            {
                if (variable.Power == 0)
                { return new Variable(0, 0, variable.Character); }
                else
                { return new Variable(variable.Proverbs * variable.Power, variable.Power - 1, variable.Character); }
            }
            /// <summary>
            /// Derivates a Function.
            /// </summary>
            /// <param name="function">The selected Function.</param>
            /// <returns>A new Function that represents the derivation of the selected old one.</returns>
            public static Function Derivate(Function function)
            {
                Function newFunction = new Function(function.Character);
                foreach (var variable in function)
                { newFunction.Add(Derivate(variable)); }
                return newFunction;
            }
        }
    }
}