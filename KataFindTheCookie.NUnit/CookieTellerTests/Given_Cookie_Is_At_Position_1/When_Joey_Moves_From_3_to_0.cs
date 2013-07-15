using System;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit.
	Given_The_Cookie_Is_At_Position_1
{
	[TestFixture]
	public class When_Joey_Moves_From_3_to_0
	{
		[Test]
		public void Should_Say_Warmer ()
		{
			var response = new CookieTeller(1).AreWeThereYet (3, 0);
			Assert.AreEqual ("Moving from 3 to 0: warmer.", response);
		}
	}
}
