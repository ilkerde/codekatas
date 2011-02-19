using System;

namespace KataFizzBuzz.MSpec
{
    public class TranslationEntry : Tuple<int, string>
    {
        public TranslationEntry(int number, string translation) : base(number, translation)
        {
        }
    }
}