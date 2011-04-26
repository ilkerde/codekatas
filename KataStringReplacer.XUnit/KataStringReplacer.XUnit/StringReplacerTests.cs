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
            var replacer = new StringReplacer(table: null);

            var text = replacer.Replace(template);

            Assert.Equal(string.Empty, text);
        }

        [Fact]
        public void when_template_contains_no_placeholder_then_text_equals_template() {
            var template = "Test";
            var replacer = new StringReplacer(table: null);

            var text = replacer.Replace(template);

            Assert.Equal("Test", text);
        }

        [Fact]
        public void when_template_has_known_placeholder_then_text_contains_corresponding_value() {
            var table = new Dictionary<string, string>() {
                {"key", "value"}
            };

            var template = "$key$";
            var replacer = new StringReplacer(table);

            var text = replacer.Replace(template);

            Assert.Equal("value", text);
        }

        [Fact]
        public void when_template_has_unknown_placeholder_then_text_does_not_contain_that_placeholder() {
            var table = new Dictionary<string, string>() {
                {"key", "value"}
            };

            var template = "$what$";
            var replacer = new StringReplacer(table);

            var text = replacer.Replace(template);

            Assert.Equal(string.Empty, text);
        }
    }
}
