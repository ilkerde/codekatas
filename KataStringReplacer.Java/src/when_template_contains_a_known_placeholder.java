import java.util.HashMap;

import org.junit.*;
import static org.junit.Assert.*;

public class when_template_contains_a_known_placeholder {
	@Before public void on_replace() {
		_template = "$key$";
		_placeholders = new HashMap<String, String>();
		_placeholders.put("key", "value");
		
		Replacer.setPlaceholders(_placeholders);
		_text = Replacer.replace(_template);
	}
	
	@Test
	public void then_text_contains_value_of_known_placeholder() {
		assertEquals("value", _text);
	}
	
	private HashMap<String, String> _placeholders;
	private String _template;
	private String _text;
}
