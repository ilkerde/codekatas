using System;
using System.Linq;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	[TestFixture]
	public class Case_2 
	{
		Definition _definition;
		CookieTeller _teller;
		FindTheCookie _game;

		[SetUp]
		public void Establish()
		{
			_definition = new Definition("3 10 10 7 3");
			_teller = new CookieTeller(_definition.Target);
			_game = new FindTheCookie(
				_definition, 
				_teller);
		}

		[Test]
		public void Result() 
		{
			string[] hints = _game.Run();
			Assert.AreEqual(@"Moving from 0 to 10: colder.
Moving from 10 to 10: same.
Moving from 10 to 7: warmer.
Moving from 7 to 3: found it!", String.Join(Environment.NewLine, hints));
		}
	}
	
}