using NUnit.Framework;
using System;
using System.Linq;

namespace KataStringCalculator.XS
{
	public class StringCalculator
	{
		public static int Add (string input)
		{
			if (string.IsNullOrEmpty (input))
				return 0;

			var numbers = input.Split (
				new[] { "," }, 
				StringSplitOptions.RemoveEmptyEntries
			);

			return (from number in numbers select Convert.ToInt32 (number)).Sum ();
		}
	}
}
