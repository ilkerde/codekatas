using System;
using System.Linq;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	public class FindTheCookie
	{
		public FindTheCookie(string definition)
		{
			var definitionNumbers = from definitionNumberString 
				in definition.Split (new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				select Convert.ToInt32 (definitionNumberString);

			CookiePosition = definitionNumbers.First();
		}

		public int CookiePosition { get; set; }

		public Move NextStep()
		{
			return new Move();
		}
	}
}