using System;
using System.Collections.Generic;
using System.Linq;

namespace KataStringCalculator
{
    public class StringCalculator
    {
        private StringCalculatorParser parser;

        public StringCalculator(StringCalculatorParser parser)
        {
            this.parser = parser;
        }

        public int Add(string source)
        {
            if (String.IsNullOrEmpty(source))
                return 0;

            IEnumerable<int> numbers = this.parser.Parse(source);

            IEnumerable<int> negativenumbers = 
                numbers.Where(number => number < 0);

            if (negativenumbers.Any())
                throw new ArgumentException(
                    String.Format(
                        "Invalid operation: found negative numbers: {0}",
                        String.Join(",", negativenumbers))
                    );

            return
                this.parser.Parse(source)
                .Sum();
        }
    }
}