using System;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{

	[TestFixture]
	public class When_Game_Definition_Has_Already_Moved_To_3_And_Has_Second_Move_7 
	{
		[Test]
		public void Should_Joey_Move_From_3_To_7_At_Second_Step() 
		{
			var game = new FindTheCookie("5 3 7");
			game.NextStep();
			var move = game.NextStep();
			Assert.AreEqual (3, move.From);
			Assert.AreEqual (7, move.To);
		}
	}
}