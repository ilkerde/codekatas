using System;
using System.Linq;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	[TestFixture]
	public class When_3_Moves_Are_Defined 
	{
		Definition _definition;
		CookieTeller _teller;
		FindTheCookie _game;

		[SetUp]
		public void Establish_3_Moves_Are_Defined()
		{
			_definition = new Definition("1 0 2 1");
			_teller = new CookieTeller(1);
			_game = new FindTheCookie(
				_definition, 
				_teller);
		}

		[Test]
		public void Should_Joey_Have_Three_Steps() 
		{
			string[] hints = _game.Run();
			Assert.AreEqual(3, hints.Length);
		}
	}
	
}