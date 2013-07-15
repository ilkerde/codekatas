using System;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	[TestFixture]
	public class When_Game_Definition_Starts_With_2 
	{
		[Test]
		public void Should_Cookie_Be_Placed_At_2() 
		{
			var definition = new Definition("2 0");
			Assert.AreEqual(2, definition.Target);
		}
	}
}