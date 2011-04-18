using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace KataPickAkin
{
	public class PickTests 
	{
		[TestFixture]
		public class When_Left_Has_One_Akin_Of_One_Right
		{
			[Test]
			public void Then_Akin_Has_Both()
			{
				List<string> left = new List<string>() { "A1" };
				List<string> right = new List<string>() { "A2" };
		
				Board board = left.PickAkin(right);
			
				Assert.That(board.Akin, Contains.Item("A1"));
				Assert.That(board.Akin, Contains.Item("A2"));
			}
		}
	}
}

