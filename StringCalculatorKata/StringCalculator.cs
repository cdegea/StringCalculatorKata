using System;
using System.Linq;

namespace StringCalculatorKata
{
    internal class StringCalculator
    {
        internal static int Add(string numbers)
        {
            var delimiter = '\n';
            if (numbers == "") return 0;

            if (numbers.StartsWith("//"))
            {
                delimiter = numbers.ElementAt(2);
            }

            var numbersValue = numbers
                .Replace($"//{delimiter}", "")
                .Replace(delimiter, ',')
                .Split(',').ToList()
                .Select(x => Convert.ToInt32(x));

            if (numbersValue.Any(x => x < 0))
            {
                var negativos = numbersValue.Where(x => x < 0).ToList();
                var textNegativos = "negatives not allowed";
                for (int i = 0; i < negativos.Count(); i++)
                {
                    textNegativos += " " + negativos[i];
                }
                throw new InvalidOperationException(textNegativos);
            }
           
            return numbersValue.Sum();
        }
    }
}