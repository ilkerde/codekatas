using System;
using System.Linq;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	[TestFixture]
	public class Case_1 
	{
		Definition _definition;
		CookieTeller _teller;
		FindTheCookie _game;

		[SetUp]
		public void Establish()
		{
			_definition = new Definition("5 10 11 12 3 4 5");
			_teller = new CookieTeller(_definition.Target);
			_game = new FindTheCookie(
				_definition, 
				_teller);
		}

		[Test]
		public void Result() 
		{
			string[] hints = _game.Run();
			Assert.AreEqual(@"Moving from 0 to 10: same.
Moving from 10 to 11: colder.
Moving from 11 to 12: colder.
Moving from 12 to 3: warmer.
Moving from 3 to 4: warmer.
Moving from 4 to 5: found it!", String.Join(Environment.NewLine, hints));
		}
	}
	
}