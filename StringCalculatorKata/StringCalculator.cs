using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculatorKata
{
    internal class StringCalculator
    {
        internal static int Add(string numbers)
        {
            if (numbers == String.Empty)
                return 0;
            var delimiters = GetDelimiters(ref numbers);
            var numValues = numbers
                .Split( delimiters.ToArray(), StringSplitOptions.None )
                .ToList()
                .Select( number => int.Parse( number ))
                .Where(num => num <= 1000);
            if (numValues.Any(number => number < 0)) {
                throw new ArgumentException( "negatives not allowed",
                        numValues
                            .Where( num => num < 0 )
                            .Select(num => $"{num}")
                            .Aggregate((seed,item)=> seed + "," + item) 
                    );
			}
            return numValues.Sum();
        }

        private static List<string> GetDelimiters(ref string numbers)
        {
            var delimiters = new List<string>() { ",", "\n" };
            if (numbers.Contains("//"))
            {
                if (numbers.Contains("[") && numbers.Contains("]"))
                {
                    Regex regex = new Regex(@"\[(.+?)\]");
                    var delimits = regex.Matches(numbers);
                    delimiters.AddRange(delimits.Select(delimit => delimit.Groups[1].Value));
                    numbers = numbers.Substring(numbers.IndexOf("\n") + 1);
                }
                else
                {
                    delimiters.Add(numbers.Substring(2, 1));
                    numbers = numbers.Substring(4);
                }
            }
            return delimiters;
        }
    }
}