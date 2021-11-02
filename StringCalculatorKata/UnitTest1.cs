using System;
using Xunit;

namespace StringCalculatorKata
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("", 0)]
        [InlineData ("1", 1)]
        [InlineData ("2", 2)]
        [InlineData ("1,2", 3)]
        [InlineData ("2,3", 5)]
        [InlineData ("2,4", 6)]
        [InlineData("1,2,3", 6)]
        [InlineData("1\n2,3", 6)]
        [InlineData("//;\n1;2", 3)]        
        public void NumbersInStringReturnsNumbers(string numbers, int expectedNumber)
        {
            var result = StringCalculator.Add(numbers);
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void StringNegativeNumberThrowsException()
        {
            var result = Assert.Throws<InvalidOperationException>(() => StringCalculator.Add("//;\n-1;2"));
            Assert.Equal("negatives not allowed -1", result.Message);
        }
    }
}
