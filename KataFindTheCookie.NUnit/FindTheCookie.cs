using System;
using System.Linq;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	public class FindTheCookie
	{
		int[] _path;

		public FindTheCookie(string definition)
		{
			var definitionNumbers = from definitionNumberString 
				in definition.Split (new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				select Convert.ToInt32 (definitionNumberString);

			CookiePosition = definitionNumbers.First();
			_path = definitionNumbers.Skip(1).ToArray();
		}

		public int CookiePosition { get; set; }

		public Move NextStep()
		{
			return new Move { From = 0, To = _path[0] };
		}
	}
}