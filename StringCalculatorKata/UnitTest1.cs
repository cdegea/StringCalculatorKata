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
        public void NumbersInStringReturnsNumbers(string numbers, int expectedNumber)
        {
            var result = StringCalculator.Add(numbers);
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void Numbers1And2Returns3()
        {
            var result = StringCalculator.Add("1,2");
            Assert.Equal(3, result);
        }
    }
}
