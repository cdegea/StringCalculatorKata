using System;
using Xunit;

namespace StringCalculatorKata
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyStringReturns0()
        {
            var result = StringCalculator.Add("");
            Assert.Equal(0, result);
        }

        [Fact]
        public void String1Returns1()
        {
            var result = StringCalculator.Add("1");
            Assert.Equal(1, result);
        }

    }
}
