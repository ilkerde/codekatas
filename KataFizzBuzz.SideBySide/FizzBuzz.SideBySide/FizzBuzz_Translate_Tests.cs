using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;

namespace FizzBuzz.SideBySide
{
    public class FizzBuzz_Translate_Tests
    {
        [Fact]
        public void When_Number_Is_Multiples_Of_Three_Then_Returns_Fizz()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            string translation = fizzbuzz.Translate(6);
            Assert.Equal("Fizz", translation);
        }

        [Fact]
        public void When_Number_Is_Multiples_Of_Five_Then_Returns_Buzz()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            string translation = fizzbuzz.Translate(10);
            Assert.Equal("Buzz", translation);
        }

        [Fact]
        public void When_Number_Is_Multiples_Of_Three_And_Five_Then_Returns_FizzBuzz()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            string translation = fizzbuzz.Translate(15);
            Assert.Equal("FizzBuzz", translation);
        }

        [Fact]
        public void When_Number_Is_No_Multiples_Of_Three_Or_Five_Then_Returns_Number()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            string translation = fizzbuzz.Translate(7);
            Assert.Equal("7", translation);
        }
    }
}
