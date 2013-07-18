using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

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

			var numbers = from part in input.Split (
				delimiters.ToArray (), 
				StringSplitOptions.RemoveEmptyEntries
			) select Convert.ToInt32 (part);

			if (numbers.Count (x => x < 0) > 0)
				throw new Exception ();

			return numbers.Sum ();
		}
	}
}
