using System;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit.
	Given_The_Cookie_Is_At_Position_1
{
	[TestFixture]
	public class When_Joey_Moves_From_0_To_3
	{
		[Test]
		public void Should_Say_Colder ()
		{
			var response = new CookieTeller(1).AreWeThereYet (0, 3);
			Assert.AreEqual ("Moving from 0 to 3: colder.", response);
		}
	}
	
}
