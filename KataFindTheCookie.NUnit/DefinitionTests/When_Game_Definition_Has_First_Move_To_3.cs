using System;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	[TestFixture]
	public class When_Game_Definition_Has_First_Move_To_3 
	{
		[Test]
		public void Should_Joey_Move_From_0_To_3_At_First_Step() 
		{
			var game = new FindTheCookie("5 3");
			var move = game.NextStep();
			Assert.AreEqual (0, move.From);
			Assert.AreEqual (3, move.To);
		}
	}
}