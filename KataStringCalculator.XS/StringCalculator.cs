using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;

namespace KataStringCalculator.XS
{
	public class StringCalculator
	{
		public static int Add (string input)
		{
			if (string.IsNullOrEmpty (input))
				return 0;

			var delimiters = new List<string> { ",", Environment.NewLine };

			if (input.StartsWith ("//")) {
				delimiters.Add (input.Substring (2, 1));
				input = input.Substring (input.IndexOf (Environment.NewLine));
			}

			var numbers = input.Split (
				delimiters.ToArray(), 
				StringSplitOptions.RemoveEmptyEntries
			);

			return (from number in numbers select Convert.ToInt32 (number)).Sum ();
		}
	}
}
