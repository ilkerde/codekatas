using System;

namespace KataStringCalculator
{
    public class StringCalculator
    {
        public int Add(string source)
        {
            if (String.IsNullOrEmpty(source))
                return 0;

            return Convert.ToInt32(source);
        }
    }
}