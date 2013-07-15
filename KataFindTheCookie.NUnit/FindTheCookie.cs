using System;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	public class FindTheCookie
	{
		public FindTheCookie(string definition)
		{
			CookiePosition = 2;
		}

		public int CookiePosition { get; set; }
	}
}