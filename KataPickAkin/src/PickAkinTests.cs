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
			List<string> left = new List<string>() { "A1" };
			List<string> right = new List<string>() { "A2" };

			Board board = null;
			
			[SetUp]
			public void Because()
			{
				board = left.PickAkin(right);
			}
			
			[Test]
			public void Then_Akin_Has_Both()
			{
			
				Assert.That(board.Akin, Contains.Item("A1"));
				Assert.That(board.Akin, Contains.Item("A2"));
			}
			
			[Test]
			public void Then_Left_Is_Empty()
			{
				Assert.That(board.Left, Is.Empty);
			}
			
			[Test]
			public void Then_Right_Is_Empty()
			{
				Assert.That(board.Right, Is.Empty);
			}
		}
	}
}
