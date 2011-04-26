using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace KataStringReplacer.XUnit
{
    public class StringReplacerTests {
        [Fact]
        public void when_template_is_emply_then_text_is_empty() {
            var template = string.Empty;
            var replacer = new StringReplacer();

            var text = replacer.Replace(template);

            Assert.Equal(string.Empty, text);
        }

        [Fact]
        public void when_template_contains_no_placeholder_then_text_equals_template() {
            var template = "Test";
            var replacer = new StringReplacer();

            var text = replacer.Replace(template);

            Assert.Equal("Test", text);
        }
    }
}
