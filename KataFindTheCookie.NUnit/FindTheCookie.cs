using System;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

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

		public string[] Run()
		{
			var hints = new List<string>();

			while(CanMove()) {
				Move nextMove = NextStep();
				hints.Add(_teller.AreWeThereYet (nextMove.From, nextMove.To)); 
			}

			return hints.ToArray();
		}

		public Move NextStep()
		{
			return new Move { From = _path[_step], To = _path[++_step] };
		}

		private bool CanMove()
		{
			return _step < _path.Length - 1;
		}
	}
}