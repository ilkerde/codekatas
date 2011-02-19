using System;

namespace KataFizzBuzz.MSpec
{
    public class FizzBuzz
    {
        public string Translate(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";

            if (number % 5 == 0)
                return "Buzz";

            return "Fizz";
        }
    }
}