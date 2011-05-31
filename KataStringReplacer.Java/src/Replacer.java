import java.util.HashMap;
import java.util.Map;

public class Replacer {
	private static HashMap<String, String> _placeholders;
	
	public static String replace(String template) {
		String text = template;
		
		if (_placeholders != null)
			for (Map.Entry<String, String> placeholder : _placeholders.entrySet())
				text = text.replaceAll(getPlaceholderTokenRegex(placeholder), placeholder.getValue());
		
		text = text.replaceAll("\\$.*?\\$", "");
		
		return text;
	}

	public static void setPlaceholders(HashMap<String, String> placeholders) {
		Replacer._placeholders = new HashMap<String, String>();
		Replacer._placeholders.putAll(placeholders);
	}

	private static String getPlaceholderTokenRegex(Map.Entry<String, String> placeholder) {
		return String.format("\\$%s\\$", placeholder.getKey());
	}
}