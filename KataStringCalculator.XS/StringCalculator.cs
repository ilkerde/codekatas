using NUnit.Framework;
using System;

namespace KataStringCalculator.XS
{
	public class StringCalculator
	{
		public static int Add (string numbers)
		{
			if (string.IsNullOrEmpty (numbers))
				return 0;

			return 1;
		}
	}
}
