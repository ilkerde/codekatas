using NUnit.Framework;
using System;

namespace KataStringCalculator.XS
{
	[TestFixture]
	public class StringCalculatorTests
	{
		[Test]
		public void When_No_Number_Is_Given_Should_Sum_To_0 ()
		{
			StringCalculator.Add ("")
				.ShouldEqual (0);
		}

		[Test]
		public void When_1_Is_Given_Should_Sum_To_1 ()
		{
			StringCalculator.Add ("1")
				.ShouldEqual (1);
		}

		[Test]
		public void When_2_Is_Given_Should_Sum_To_2 ()
		{
			StringCalculator.Add ("2")
				.ShouldEqual (2);
		}

		[Test]
		public void When_Two_Numbers_Are_Given_Should_Return_Sum_Of_Both ()
		{
			StringCalculator.Add ("2,2")
				.ShouldEqual (2+2);
		}

		[Test]
		public void When_Two_Numbers_Are_Given_Separated_By_Newline_Should_Return_Sum_Of_Both ()
		{
			StringCalculator.Add (@"2
2")
				.ShouldEqual (2+2);
		}

		[Test]
		public void When_Delimiter_Is_Set_To_Semicolon_Should_Return_Sum_Of_Semicolon_Separated_Numbers ()
		{
			StringCalculator.Add (@"//;
2;2")
				.ShouldEqual (2+2);
		}
	}
}
