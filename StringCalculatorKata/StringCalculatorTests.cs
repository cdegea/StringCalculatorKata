using System;
using Xunit;

namespace StringCalculatorKata
{
    public class StringCalculatorTests
    {
        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("", 0)]
        public void StringWithNumberReturnsNumber(string number, int expected)
        {
            var result = StringCalculator.Add(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("1,3", 4)]
        [InlineData("1,3,5", 9)]
        [InlineData("1\n3,5", 9)]
        [InlineData("1\n3\n5", 9)]
        [InlineData("@1@3@5", 9)]
        public void StringWithNumbersReturnsSum(string numbers, int expected)
        {
            var result = StringCalculator.Add(numbers);
            Assert.Equal(expected, result);
        }


    }
}
