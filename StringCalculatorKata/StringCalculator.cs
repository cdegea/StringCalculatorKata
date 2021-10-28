using System;
using System.Linq;

namespace StringCalculatorKata
{
    public static class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;
            return numbers.Split(",")
                .ToList()
                .Select(n => int.Parse(n))
                .Sum();
        }
    }
}