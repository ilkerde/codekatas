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
            if ((number % 3 == 0) && (number % 5 == 0))
                return "FizzBuzz";

            if (number % 5 == 0)
                return "Buzz";

            return "Fizz";
        }
    }
}
