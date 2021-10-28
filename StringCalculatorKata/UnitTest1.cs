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
		public void SeparatedNumbersWithCommaReturnsTheSum(string numbers, int result)
		{
			Assert.Equal(result, StringCalculator.Add(numbers));
		}
	}
}
