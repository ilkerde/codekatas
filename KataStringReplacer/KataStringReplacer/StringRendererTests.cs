using System;
using NUnit.Framework;

namespace KataStringReplacer {
	[TestFixture]
	public class StringRendererTests {
		[Test]
		public void When_Template_Is_Empty_Then_Text_Is_Empty() {
			StringRenderer renderer = new StringRenderer();
			string template = String.Empty;
			
			string text = renderer.Render(template);
			
			Assert.That(text, Is.Empty);
		}
		
		[Test]
		public void When_Template_Contains_Text_Without_Placeholders_Then_Text_Is_Same_As_Template() {
			StringRenderer renderer = new StringRenderer();
			string template = "A simple text message.";
			
			string text = renderer.Render(template);
			
			Assert.That(text, Is.EqualTo(template));
		}
	}
}