import java.util.HashMap;
import java.util.Map;

public class Replacer {
	private static HashMap<String, String> _placeholders;
	
	public static String replace(String template) {
		return
		removeUnknownPlaceholderTokens(
			replaceKnownPlaceholderTokens(
				template
			)
		);
	}

	public static void setPlaceholders(HashMap<String, String> placeholders) {
		Replacer._placeholders = new HashMap<String, String>();
		Replacer._placeholders.putAll(placeholders);
	}

	private static String replaceKnownPlaceholderTokens(String text) {
		if (_placeholders != null)
			for (Map.Entry<String, String> placeholder : _placeholders.entrySet())
				text = text.replaceAll(getPlaceholderTokenRegex(placeholder), placeholder.getValue());
		return text;
	}

	private static String removeUnknownPlaceholderTokens(String text) {
		text = text.replaceAll("\\$.*?\\$", "");
		return text;
	}

	private static String getPlaceholderTokenRegex(Map.Entry<String, String> placeholder) {
		return String.format("\\$%s\\$", placeholder.getKey());
	}
}