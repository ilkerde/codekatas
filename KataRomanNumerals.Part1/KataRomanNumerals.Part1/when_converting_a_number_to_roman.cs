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

		[Test]
		public void convert_6_should_give_vi() 
		{
			Assert.That(converter.Convert(6), Is.EqualTo("VI"));
		}
		
		[Test]
		public void convert_4_should_give_iv() 
		{
			Assert.That(converter.Convert(4), Is.EqualTo("IV"));
		}
		
		[Test]
		public void convert_10_should_give_x() 
		{
			Assert.That(converter.Convert(10), Is.EqualTo("X"));
		}

		[Test]
		public void convert_9_should_give_IX() 
		{
			Assert.That(converter.Convert(9), Is.EqualTo("IX"));
		}
		
		[Test]
		public void convert_50_should_give_L() 
		{
			Assert.That(converter.Convert(50), Is.EqualTo("L"));
		}

		private RomanNumberConverter converter;
	
		[SetUp]
		public void establish_context()
		{
			converter = new RomanNumberConverter();
		}
	}
}
