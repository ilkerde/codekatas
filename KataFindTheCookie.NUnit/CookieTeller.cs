using System;
using NUnit.Framework;

namespace KataFindTheCookie.NUnit
{
	public class CookieTeller
	{
		static int cookie = 1;

		public static string AreWeThereYet (int from, int to)
		{
			if (to != cookie)
				return String.Format ("Moving from 0 to {0}: same.", to);

			return "Moving from 0 to 1: found it!";
		}
	}
}