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

            int tokenBegin = text.IndexOf('$');

            if (tokenBegin > -1)
            {
                int tokenEnd = text.IndexOf('$', tokenBegin + 1);

                if (tokenEnd > -1)
                {
                    string unknownToken = text.Substring(tokenBegin, tokenEnd - tokenBegin + 1);
                    text = text.Replace(unknownToken, string.Empty);
                }
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
