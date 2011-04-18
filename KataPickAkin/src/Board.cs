using System;
using System.Collections.Generic;

namespace KataPickAkin
{
	public class Board
	{
		public Board(List<string> left, List<string> right)
		{
			this.Left = new List<string>(left);
			this.Right = new List<string>(right);
			this.Akin = new List<string>();
		}
		
		public List<string> Left { get; private set; }
		public List<string> Right { get; private set; }
		public List<string> Akin { get; private set; }
	}
}
