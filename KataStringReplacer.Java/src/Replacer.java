import java.util.HashMap;
import java.util.Map;

public class Replacer {
	private static HashMap<String, String> _placeholders;
	
	public static String replace(String template) {
		String text = template;
		
		if (_placeholders != null)
			for (Map.Entry<String, String> placeholder : _placeholders.entrySet())
				text = text.replaceAll(String.format("\\$%s\\$", placeholder.getKey()), placeholder.getValue());
		
		return text;
	}

	public static void setPlaceholders(HashMap<String, String> placeholders) {
		Replacer._placeholders = new HashMap<String, String>();
		Replacer._placeholders.putAll(placeholders);
	}
}