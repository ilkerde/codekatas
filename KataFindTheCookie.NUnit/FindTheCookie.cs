using System;
using System.Linq;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	public class FindTheCookie
	{
		int[] _path;
		int _target;
		int _step;

		CookieTeller _teller;

		public FindTheCookie(Definition definition, CookieTeller teller)
		{
			_teller = teller;
			_path = definition.Path;
			_target = definition.Target;
		}

		public int CookiePosition { get; set; }

		public string[] Run ()
		{
			return new string[] { "1" };
		}

		public Move NextStep()
		{
			return new Move { From = _path[_step], To = _path[++_step] };
		}
	}
}