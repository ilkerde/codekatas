using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KataFizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void Multiples_Of_Three_Returns_Fizz()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            string translation = fizzbuzz.Translate(6);

            Assert.That(translation, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Multiples_Of_Five_Returns_Buzz()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            string translation = fizzbuzz.Translate(10);

            Assert.That(translation, Is.EqualTo("Buzz"));
        }

        [Test]
        public void Multiples_Of_Three_And_Five_Returns_FizzBuzz()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            string translation = fizzbuzz.Translate(15);

            Assert.That(translation, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void No_Multiples_Of_Three_Or_Five_Returns_Number()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            string translation = fizzbuzz.Translate(7);

            Assert.That(translation, Is.EqualTo("7"));
        }
    }
}
