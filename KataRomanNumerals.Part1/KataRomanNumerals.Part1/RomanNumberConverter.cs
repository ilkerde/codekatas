using System;
using NUnit.Framework;

namespace KataRomanNumerals.Part1
{
	public class RomanNumberConverter 
	{
		public string Convert(int number)
		{
			if (number >= 50)
				return "L"
					+ Convert(number - 50);
			
			if (number >= 10)
				return "X"
					+ Convert(number - 10);
		
			if (10 - number == 1)
				return "IX";
			
			if (number >= 5)
				return "V" 
					+ Convert(number - 5);
	
			if (5 - number == 1)
				return "IV";
			
			if (number >= 1)
				return new String('I', number);
		
			return String.Empty;
		}
	}
}
