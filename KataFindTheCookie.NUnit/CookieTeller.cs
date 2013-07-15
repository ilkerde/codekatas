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

			return DescribeDistanceDifference (from, to, diffFromTarget, diffToTarget);
		}

		private string DescribeDistanceDifference(int from, int to, int oldDistance, int newDistance)
		{
			var difference = oldDistance == newDistance ? "same" : "colder";
			return String.Format("Moving from 0 to {0}: {1}.", to, difference);
		}
	}
}