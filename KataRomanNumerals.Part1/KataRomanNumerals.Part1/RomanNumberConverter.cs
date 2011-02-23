using System;
using NUnit.Framework;

namespace KataRomanNumerals.Part1
{
	public class RomanNumberConverter 
	{
		public string Convert(int number)
		{
			if (number == 5)
				return "V";
		
			return new String('I', number);
		}
	}
}
