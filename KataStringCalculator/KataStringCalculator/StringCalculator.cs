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

            var parts = source
                .Split(new string[] { ",", "\n" }, StringSplitOptions.None);

            if (parts.Where(String.IsNullOrEmpty).Any())
                throw new InvalidOperationException();

            return parts
                .Select(x => Convert.ToInt32(x))
                .Sum();
        }
    }
}