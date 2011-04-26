using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KataStringReplacer.NUnit
{
    [TestFixture]
    public class StringReplacerTests
    {
        [Test]
        public void when_template_is_empty_then_text_is_empty() 
        {
            StringReplacer replacer = new StringReplacer();
            string text = replacer.Replace(string.Empty);

            Assert.That(text, Is.Empty);
        }
    
        [Test]
        public void when_template_contains_no_placeholder_then_text_equals_template()
        {
            StringReplacer replacer = new StringReplacer();
            string text = replacer.Replace("Hello");

            Assert.That(text == "Hello");
        }
    }
}
