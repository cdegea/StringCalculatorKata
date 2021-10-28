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

		[Fact]
		public void Number1Returns1()
		{
			int result = StringCalculator.Add("1");
			Assert.Equal(1, result);
		}

		[Fact]
		public void Numbers1And2Returns3()
		{
			int result = StringCalculator.Add("1,2");
			Assert.Equal(3, result);
		}
	}
}
