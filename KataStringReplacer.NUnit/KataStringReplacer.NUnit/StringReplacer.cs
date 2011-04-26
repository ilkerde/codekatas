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
                text = text.Replace(String.Format("${0}$", entry.Key), entry.Value);                
            }

            return text;
        }

        public StringReplacer(Dictionary<string, string> table)
        {
            _table = table;
        }

        public StringReplacer() {}

        Dictionary<string, string> _table = new Dictionary<string,string>();
    }
}
