using System;
using System.Collections.Generic;

namespace KataStringReplacer.NUnit
{
    public class StringReplacer
    {
        public string Replace(string template)
        {
            string text = template;

            foreach (var entry in _table)
            {
                text = text.Replace(GetPlaceholder(entry.Key), entry.Value);                
            }

            return text;
        }

        public StringReplacer(Dictionary<string, string> table)
        {
            _table = table;
        }

        private static string GetPlaceholder(string key)
        {
            return String.Format("${0}$", key);
        }

        public StringReplacer() { }

        Dictionary<string, string> _table = new Dictionary<string,string>();
    }
}
