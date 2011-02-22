using System;
using System.Collections.Generic;
using System.Linq;

namespace KataStringCalculator
{
    public class StringCalculatorParser
    {
        public IEnumerable<int> Parse(string source)
        {
            var parts = source
                .Split(new string[] { ",", "\n" }, StringSplitOptions.None);

            if (parts.Where(String.IsNullOrEmpty).Any())
                throw new InvalidOperationException();

            return
                from part in parts
                select Convert.ToInt32(part);
        }
    }
}