using System;
using NUnit.Framework;

namespace KataRomanNumerals.Part1
{
	[TestFixture]
	public class when_converting_a_number_to_roman
	{
		[Test]
		public void convert_1_should_give_i() 
		{
			Assert.That(converter.Convert(1), Is.EqualTo("I"));
		}

		[Test]
		public void convert_5_should_give_v() 
		{
			Assert.That(converter.Convert(5), Is.EqualTo("V"));
		}

		[Test]
		public void convert_2_should_give_ii() 
		{
			Assert.That(converter.Convert(2), Is.EqualTo("II"));
		}
		
		private RomanNumberConverter converter;
	
		[SetUp]
		public void establish_context()
		{
			converter = new RomanNumberConverter();
		}
	}
}
