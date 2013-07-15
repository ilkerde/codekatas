using System;
using System.Linq;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	public class Definition 
	{
		public Definition(string definition)
		{
			var definitionNumbers = from definitionNumberString 
				in definition.Split (new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
					select Convert.ToInt32 (definitionNumberString);

			Target = definitionNumbers.First();
			Path = definitionNumbers.ToArray();
			Path[0] = 0;
		}

		public int Target { get; private set; }
		public int[] Path { get; private set; }
	}
}