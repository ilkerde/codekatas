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

            return
                this.parser.Parse(source)
                .Sum();
        }
    }
}