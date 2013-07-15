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

		public FindTheCookie(Definition definition)
		{
			_path = definition.Path;
			_target = definition.Target;
		}

		public int CookiePosition { get; set; }

		public Move NextStep()
		{
			return new Move { From = _path[_step], To = _path[++_step] };
		}
	}
}