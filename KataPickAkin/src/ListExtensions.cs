using System;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

namespace KataPickAkin
{
	public static class ListExtensions
	{
		public static Board PickAkin(this List<string> left, List<string> right)
		{
			Board board = new Board(left, right);
			board.Akin.AddRange(board.Left.Union(board.Right));
			board.Left.Clear();
			
			return board;
		}
	}
}
