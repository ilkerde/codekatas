using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FizzBuzz.SideBySide
{
    public class FizzBuzz_TranslateAll_Tests
    {
        [Fact]
        public void When_Range_Is_From_1_To_100_Then_Returns_100_Entries()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Dictionary<int, string> translations = fizzbuzz.TranslateAll(1, 100);
            Assert.Equal(100, translations.Count);
        }

        [Fact]
        public void When_Range_Is_From_1_To_100_Then_Returns_100_Translated_Entries()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Dictionary<int, string> translations = fizzbuzz.TranslateAll(1, 100);

            for (int i = 1; i <= 100; i++)
                Assert.Equal(fizzbuzz.Translate(i), translations[i]);
        }
    }
}
