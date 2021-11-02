using System;
using System.Linq;

namespace StringCalculatorKata
{
    internal class StringCalculator
    {
        internal static int Add(string numbers)
        {
            var delimiter = '\n';

            if (numbers.StartsWith("//"))
            {
                delimiter = numbers.ElementAt(2);
            }

            numbers = numbers
                .Replace($"//{delimiter}", "")
                .Replace(delimiter, ',');

            if (numbers.Contains(",") || numbers.Contains('\n'))
            {
                return numbers.Split(',').ToList().Sum(Convert.ToInt32);
            }

            if (numbers != "")
                return Convert.ToInt32(numbers);
            return 0;
        }
    }
}