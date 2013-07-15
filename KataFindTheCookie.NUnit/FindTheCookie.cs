using System;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace KataFindTheCookie.NUnit
{
	public class FindTheCookie
	{
		int _step;

		Definition _definition;
		CookieTeller _teller;

		public FindTheCookie(Definition definition, CookieTeller teller)
		{
			_teller = teller;
			_definition = definition;
		}

		public string[] Run()
		{
			var hints = new List<string>();

			while(CanMove()) {
				Move nextMove = NextStep();
				hints.Add(_teller.AreWeThereYet(nextMove.From, nextMove.To)); 
			}

			return hints.ToArray();
		}

		private Move NextStep()
		{
			return new Move { From = _definition.Path[_step], To = _definition.Path[++_step] };
		}

		private bool CanMove()
		{
			return _step < _definition.Path.Length - 1;
		}
	}
}