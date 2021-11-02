using System;
using System.Linq;

namespace StringCalculatorKata
{
    internal class StringCalculator
    {
        internal static int Add(string numbers)
        {
            if (numbers.Contains(","))
            {
                return numbers.Split(',').ToList().Sum(Convert.ToInt32);
            }

            if (numbers != "")
                return Convert.ToInt32(numbers);
            return 0;
        }
    }
}