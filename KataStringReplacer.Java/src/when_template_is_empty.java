import org.junit.*;
import static org.junit.Assert.*;

public class when_template_is_empty {
	@Before public void on_replace() {
		_template = "";
		_text = Replacer.replace(_template);
	}
	
	@Test
	public void then_text_is_empty() {
		assertEquals("", _text);
	}
	
	private String _template;
	private String _text;  
}
