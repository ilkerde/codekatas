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
			if (to == _target)
				return "Moving from 0 to 1: found it!";

			var diffToTarget = Math.Abs(to - _target);
			var diffFromTarget = Math.Abs(from - _target);

			if (diffFromTarget == diffToTarget)
				return String.Format ("Moving from 0 to {0}: same.", to);

			return String.Format ("Moving from 0 to {0}: colder.", to);
		}
	}
}