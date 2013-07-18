using NUnit.Framework;
using System;

namespace KataStringCalculator.XS
{
	[TestFixture]
	public class When_No_Number_Is_Given
	{
		[Test]
		public void Should_Sum_To_0 ()
		{
			StringCalculator.Add ("")
				.ShouldEqual (0);
		}
	}
}
