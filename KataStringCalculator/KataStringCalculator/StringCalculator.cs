using System;
using System.Linq;

namespace KataStringCalculator
{
    public class StringCalculator
    {
        public int Add(string source)
        {
            if (String.IsNullOrEmpty(source))
                return 0;

            return source
                .Split(',')
                .Select(x => Convert.ToInt32(x))
                .Sum();
        }
    }
}