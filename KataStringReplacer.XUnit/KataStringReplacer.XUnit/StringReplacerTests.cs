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
    }
}
