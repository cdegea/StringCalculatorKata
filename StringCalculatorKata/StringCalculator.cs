using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace StringCalculatorKata
{
    public static class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;
            char delimiter = '\n';
            if (numbers.StartsWith("//"))
            {
                delimiter = numbers[2];
            }

            var nums = numbers
                .Replace($"//{delimiter}", "")
                .Replace(delimiter.ToString(), ",")
                .Split(",")
                .ToList()
                .Select(n => int.Parse(n));
            if (nums.Any(n => n < 0))
            {
                var negatives = nums
                    .Where(n => n < 0)
                    .Select(n => $"{n}")
                    .Aggregate((a,i) => $"{a} {i}");
                throw new InvalidOperationException($"negatives not allowed {negatives}");
            }

            return nums.Sum();
        }
    }
}