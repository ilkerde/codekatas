using System;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	[TestFixture]
	public class When_Game_Definition_Starts_With_5 
	{
		[Test]
		public void Should_Cookie_Be_Placed_At_5() 
		{
			var game = new FindTheCookie("5 0");
			Assert.AreEqual(5, game.CookiePosition);
		}
	}
}