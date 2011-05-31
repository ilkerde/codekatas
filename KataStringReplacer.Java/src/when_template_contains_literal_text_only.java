import static org.junit.Assert.assertEquals;
import org.junit.*;

public class when_template_contains_literal_text_only {
	@Before public void on_replace() {
		_template = "literal only";
		_text = Replacer.replace(_template);
	}
	
	@Test
	public void then_text_contains_literal_text_only() {
		assertEquals("literal only", _text);
	}
	
	private String _template;
	private String _text;
}
