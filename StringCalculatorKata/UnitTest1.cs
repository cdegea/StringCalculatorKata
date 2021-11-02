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
    }
}
