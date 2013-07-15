using System;
using System.Linq;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	public class FindTheCookie
	{
		int[] _path;
		int _step;

		public FindTheCookie(string definition)
		{
			var definitionNumbers = from definitionNumberString 
				in definition.Split (new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				select Convert.ToInt32 (definitionNumberString);

			CookiePosition = definitionNumbers.First();
			_path = definitionNumbers.ToArray();
			_path[0] = 0;
		}

		public int CookiePosition { get; set; }

		public Move NextStep()
		{
			return new Move { From = _path[_step], To = _path[++_step] };
		}
	}
}