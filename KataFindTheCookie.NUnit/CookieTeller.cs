using System;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	public class CookieTeller
	{
		int _target;

		public CookieTeller(int target)
		{
			_target = target;
		}

		public string AreWeThereYet(int from, int to)
		{
			if (to != _target)
				return String.Format ("Moving from 0 to {0}: same.", to);

			return "Moving from 0 to 1: found it!";
		}
	}
}