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
			var diffToTarget = Math.Abs(to - _target);
			var diffFromTarget = Math.Abs(from - _target);

			return DescribeDistanceDifference(from, to, diffFromTarget, diffToTarget);
		}

		private string DescribeDistanceDifference(int from, int to, int oldDistance, int newDistance)
		{
			var difference = "same.";

			if (oldDistance < newDistance)
				difference = "colder.";

			if (oldDistance > newDistance)
				difference = "warmer.";

			if (newDistance == 0)
				difference = "found it!";

			return String.Format("Moving from {0} to {1}: {2}", from, to, difference);
		}
	}
}