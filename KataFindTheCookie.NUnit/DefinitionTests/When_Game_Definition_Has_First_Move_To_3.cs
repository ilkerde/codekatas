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
			var definition = new Definition("5 3");
			Assert.AreEqual (0, definition.Path[0]);
			Assert.AreEqual (3, definition.Path[1]);
		}
	}
}