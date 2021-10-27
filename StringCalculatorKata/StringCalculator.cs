using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    internal class StringCalculator
    {
        internal static int Add(string numbers)
        {
            if (numbers == String.Empty)
                return 0;
            var delimiters = new List<string>() { ",", "\n" };
            if (numbers.Contains("//")) {
                delimiters.Add(numbers.Substring(2,1));
                numbers = numbers.Substring( 4 );
			}
            var numValues = numbers
                .Split( delimiters.ToArray(), StringSplitOptions.None )
                .ToList()
                .Select( number => int.Parse( number ) );
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
    }
}