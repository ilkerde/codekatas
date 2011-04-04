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
				
			return template;
		}
	}
}

