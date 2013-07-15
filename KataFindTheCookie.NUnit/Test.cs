using System;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit.
	Given_The_Cookie_Is_At_Position_1
{
	[TestFixture]
	public class When_Joey_Moves_From_0_To_1
	{
		[Test]
		public void Should_Find_The_Cookie ()
		{
			var response = CookieTeller.AreWeThereYet (0, 1);
			Assert.AreEqual ("Moving from 0 to 1: found it!", response);
		}
	}
}
