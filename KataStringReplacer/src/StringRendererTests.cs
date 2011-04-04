using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace KataStringReplacer {
	[TestFixture]
	public class StringRendererTests {
		[Test]
		public void When_Template_Is_Empty_Then_Text_Is_Empty() {
			StringRenderer renderer = new StringRenderer(null);
			string template = String.Empty;
			
			string text = renderer.Render(template);
			
			Assert.That(text, Is.Empty);
		}
		
		[Test]
		public void When_Template_Contains_Text_Without_Placeholders_Then_Text_Is_Same_As_Template() {
			StringRenderer renderer = new StringRenderer(null);
			string template = "A simple text message.";
			
			string text = renderer.Render(template);
			
			Assert.That(text, Is.EqualTo(template));
		}
		
		[Test]
		public void When_Template_Contains_A_Known_Placeholder_Then_Text_Contains_Value_Of_Placeholder() {
			var placeholderDefinition = new Dictionary<string, string>()
			{
				{ "KEY", "VALUE" }
			};
			
			StringRenderer renderer = new StringRenderer(placeholderDefinition);
			string template = "THE $KEY$";
			
			string text = renderer.Render(template);
			
			Assert.That(text, Is.EqualTo("THE VALUE"));
		}
		
		[Test]
		public void When_Template_Contains_An_Unknown_Placeholder_Then_Text_Does_No_Longer_Have_That_Placeholder() {
			var placeholderDefinition = new Dictionary<string, string>()
			{
				{ "KEY", "VALUE" }
			};
			
			StringRenderer renderer = new StringRenderer(placeholderDefinition);
			string template = "THE $UNKNOWN$";
			
			string text = renderer.Render(template);
			
			Assert.That(text, Is.EqualTo("THE "));
		}
		
		[Test]
		public void When_Template_Contains_Multiple_Unknown_Placeholders_Then_Text_Does_Not_Contain_Any_Of_Them() {
			var placeholderDefinition = new Dictionary<string, string>()
			{
				{ "KEY", "VALUE" }
			};
			
			StringRenderer renderer = new StringRenderer(placeholderDefinition);
			string template = "THE $UNKNOWN$$NOBODY$";
			
			string text = renderer.Render(template);
			
			Assert.That(text, Is.EqualTo("THE "));
		}
	}
}