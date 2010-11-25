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
    }
}
