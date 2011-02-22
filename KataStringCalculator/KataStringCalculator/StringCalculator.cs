using System;
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

            string[] parts = this.parser.Parse(source);

            return parts
                .Select(x => Convert.ToInt32(x))
                .Sum();
        }
    }
}