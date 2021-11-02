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

    }
}
