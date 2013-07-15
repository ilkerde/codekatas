using System;
using System.Linq;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	[TestFixture]
	public class Case_3 
	{
		Definition _definition;
		CookieTeller _teller;
		FindTheCookie _game;

		[SetUp]
		public void Establish()
		{
			_definition = new Definition("12 5 -3 1 4 6 7 8 9 12");
			_teller = new CookieTeller(_definition.Target);
			_game = new FindTheCookie(
				_definition, 
				_teller);
		}

		[Test]
		public void Result() 
		{
			string[] hints = _game.Run();
			Assert.AreEqual(@"Moving from 0 to 5: warmer.
Moving from 5 to -3: colder.
Moving from -3 to 1: warmer.
Moving from 1 to 4: warmer.
Moving from 4 to 6: warmer.
Moving from 6 to 7: warmer.
Moving from 7 to 8: warmer.
Moving from 8 to 9: warmer.
Moving from 9 to 12: found it!", String.Join(Environment.NewLine, hints));
		}
	}
	
}