using System;
using System.Linq;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	[TestFixture]
	public class When_Only_1_Move_Is_Defined 
	{
		[Test]
		public void Should_Joey_Only_Move_Once() 
		{
			FindTheCookie game = new FindTheCookie(
				new Definition("1 1"), 
				new CookieTeller(1));
			string[] hints = game.Run();
			Assert.AreEqual(1, hints.Length);
		}

		[Test]
		public void Should_Return_CookieTeller_Message() 
		{
			var teller = new CookieTeller(1);
			FindTheCookie game = new FindTheCookie(
				new Definition("1 1"), 
				teller);
			string[] hints = game.Run();
			Assert.AreEqual(teller.AreWeThereYet(0, 1), hints[0]);
		}
	}
}