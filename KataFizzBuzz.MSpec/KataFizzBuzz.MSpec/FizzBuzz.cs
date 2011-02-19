using System;

namespace KataFizzBuzz.MSpec
{
    public class FizzBuzz
    {
        public string Translate(int number)
        {
            if (number % 5 == 0)
                return "Buzz";

            return "Fizz";
        }
    }
}