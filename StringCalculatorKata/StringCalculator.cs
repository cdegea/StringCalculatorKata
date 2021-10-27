using System;
using System.Linq;

namespace StringCalculatorKata
{
    internal class StringCalculator
    {
        internal static int Add(string numbers)
        {
            if (numbers == String.Empty)
                return 0;

            return numbers.Split(',', '\n').ToList().Select(number => int.Parse(number)).Sum();
        }
    }
}