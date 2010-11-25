using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KataFizzBuzz
{
    [TestFixture]
    public class FizzBuzzTranslateRangeTests
    {
        [Test]
        public void Range_From_1_To_100_Returns_100_Elements()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Dictionary<int, string> translations = fizzbuzz.TranslateRange(1, 100);

            Assert.That(translations, Has.Count.EqualTo(100));
        }
    }
}
