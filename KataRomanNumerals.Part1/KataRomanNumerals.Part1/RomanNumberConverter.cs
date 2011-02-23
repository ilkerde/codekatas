using System;
using NUnit.Framework;

namespace KataRomanNumerals.Part1
{
	public class RomanNumberConverter 
	{
		public string Convert(int number)
		{
			if (number >= 5)
				return "V" 
					+ Convert(number - 5);
	
			if (number >= 1)
				return new String('I', number);
		
			return String.Empty;
		}
	}
}
