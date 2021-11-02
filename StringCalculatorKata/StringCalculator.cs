using System;

namespace StringCalculatorKata
{
    internal class StringCalculator
    {
        internal static int Add(string numbers)
        {
            if (numbers != "")
                return Convert.ToInt32(numbers);
            return 0;
        }
    }
}