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
	}
}
