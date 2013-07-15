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
			var definition = new Definition("5 3 7");
			Assert.AreEqual (3, definition.Path[1]);
			Assert.AreEqual (7, definition.Path[2]);
		}
	}
}