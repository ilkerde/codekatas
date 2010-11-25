using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataFizzBuzz
{
    public class FizzBuzz
    {
        public string Translate(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";

            if (number % 5 == 0)
                return "Buzz";

            if (number % 3 == 0)
                return "Fizz";

            return number.ToString();
        }

        public Dictionary<int, string> TranslateRange(int from, int to)
        {
            Dictionary<int, string> translations = new Dictionary<int, string>();

            for (int i = from; i <= to; i++)
                translations.Add(i, null);

            return translations;
        }
    }
}
