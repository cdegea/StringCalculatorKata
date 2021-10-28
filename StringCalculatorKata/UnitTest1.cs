using System;
using Xunit;

namespace StringCalculatorKata
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyStringReturns0()
        {
            int result = StringCalculator.Add("");
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void ANumberReturnsTheNumber(string numbers, int result)
        {
            Assert.Equal(result, StringCalculator.Add(numbers));
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,4", 6)]
        [InlineData("0,1,1,2,3,5,8,13", 33)]
        [InlineData("3\n1,2", 6)]
        public void SeparatedNumbersWithCommaReturnsTheSum(string numbers, int result)
        {
            Assert.Equal(result, StringCalculator.Add(numbers));
        }

        [Theory]
        [InlineData("//.\n1.2", 3)]
        [InlineData("//?\n6?7", 13)]
        public void SeparatedNumbersWithSeparatorReturnsTheSum(string numbers, int result)
        {
            Assert.Equal(result, StringCalculator.Add(numbers));
        }

        [Theory]
        [InlineData("-1,2", "negatives not allowed -1")]
        public void SeparatedNegativeNumbersWithCommaThrowsException(string numbers, string expectedMessage)
        {
            var exception = Assert.Throws<InvalidOperationException>(() => StringCalculator.Add(numbers));
            Assert.Equal(expectedMessage, exception.Message);
        }
    }
}