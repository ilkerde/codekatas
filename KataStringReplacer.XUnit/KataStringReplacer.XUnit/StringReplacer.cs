﻿using System;
using System.Collections.Generic;

namespace KataStringReplacer.XUnit {
    public class StringReplacer {
        private Dictionary<string, string> _table;

        public StringReplacer(Dictionary<string, string> table)
        {
            _table = table ?? new Dictionary<string, string>();
        }

        public string Replace(string template) {
            var text = template;

            foreach (var entry in _table) {
                text = text.Replace(GetPlaceHolder(entry.Key), entry.Value);
            }

            return text;
        }

        private static string GetPlaceHolder(string key) {
            return String.Format("${0}$", key);
        }
    }
}