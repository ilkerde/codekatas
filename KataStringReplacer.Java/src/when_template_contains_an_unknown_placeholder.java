import java.util.HashMap;

import org.junit.*;
import static org.junit.Assert.*;

public class when_template_contains_an_unknown_placeholder {
	@Before public void on_replace() {
		_template = "$what$";
		_text = Replacer.replace(_template);
	}
	
	@Test
	public void then_text_does_not_contain_any_placeholders() {
		assertEquals("", _text);
	}
	
	private String _template;
	private String _text;
}
