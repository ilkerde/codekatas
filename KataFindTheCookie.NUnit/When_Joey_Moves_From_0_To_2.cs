using System;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit.
	Given_The_Cookie_Is_At_Position_1
{
	[TestFixture]
	public class When_Joey_Moves_From_0_To_2
	{
		[Test]
		public void Should_Say_Same ()
		{
			var response = CookieTeller.AreWeThereYet (0, 2);
			Assert.AreEqual ("Moving from 0 to 2: same.", response);
		}
	}
}
