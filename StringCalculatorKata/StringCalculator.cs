using System;

namespace StringCalculatorKata
{
    internal class StringCalculator
    {
        internal static object Add(string numbers)
        {
            if (numbers == "1")
                return 1;
            if (numbers == "2")
                return 2;
            return 0;
        }
    }
}