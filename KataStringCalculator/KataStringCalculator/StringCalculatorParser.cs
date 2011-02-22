using System;
using System.Collections.Generic;
using System.Linq;

namespace KataStringCalculator
{
    public class StringCalculatorParser
    {
        public IEnumerable<int> Parse(string source)
        {
            List<string> delimiters = new List<string>() {",", "\n"};

            if (source.StartsWith("//"))
            {
                delimiters.Add(Convert.ToString(source[2]));
                source = source.Substring(4);
            }

            var parts = source
                .Split(delimiters.ToArray(), StringSplitOptions.None);

            if (parts.Where(String.IsNullOrEmpty).Any())
                throw new InvalidOperationException();

            return
                from part in parts
                select Convert.ToInt32(part);
        }
    }
}