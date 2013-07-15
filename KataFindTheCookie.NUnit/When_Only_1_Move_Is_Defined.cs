using System;
using System.Linq;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	[TestFixture]
	public class When_Only_1_Move_Is_Defined 
	{
		Definition _definition;
		CookieTeller _teller;
		FindTheCookie _game;

		[SetUp]
		public void Establish_Only_1_Move_Is_Defined()
		{
			_definition = new Definition("1 1");
			_teller = new CookieTeller(1);
			_game = new FindTheCookie(
				_definition, 
				_teller);
		}

		[Test]
		public void Should_Joey_Only_Move_Once() 
		{
			string[] hints = _game.Run();
			Assert.AreEqual(1, hints.Length);
		}

		[Test]
		public void Should_Return_CookieTeller_Message() 
		{
			string[] hints = _game.Run();
			Assert.AreEqual(_teller.AreWeThereYet(0, 1), hints[0]);
		}
	}
}