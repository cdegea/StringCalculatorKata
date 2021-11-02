using System;

namespace StringCalculatorKata
{
    internal class StringCalculator
    {
        internal static int Add(string numbers)
        {
            if (numbers.Contains(","))
            {
                return Convert.ToInt32(numbers.Split(',')[0]) + Convert.ToInt32(numbers.Split(',')[1]);
            }

            if (numbers != "")
                return Convert.ToInt32(numbers);
            return 0;
        }
    }
}