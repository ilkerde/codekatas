using System;
using System.Collections.Generic;
using System.Linq;

namespace KataStringReplacer
{
	public class StringRenderer
	{
		private Dictionary<string, string> _placeholders;
		
		public StringRenderer(Dictionary<string, string> placeholders)
		{ 
			_placeholders = placeholders;
		}
		
		public string Render(string template)
		{
			if (_placeholders != null)
				foreach (var keyValue in _placeholders)
					template = template.Replace(String.Format("${0}$", keyValue.Key), keyValue.Value);
			
			template = RemoveUnrecognizedPlaceholders(template);
			
			return template;
		}
		
		private string RemoveUnrecognizedPlaceholders(string text)
		{
			int tokenStart = text.IndexOf('$');
			
			if (tokenStart > -1) 
			{
				int tokenEnd = text.IndexOf('$', tokenStart + 1);
				
				if (tokenEnd > tokenStart)
					text = text.Substring(0, tokenStart) + text.Substring(tokenEnd + 1);
			}
			
			return text;
		}
 	}
}

