using System.Collections.Generic;
using Machine.Specifications;

namespace KataFizzBuzz.MSpec
{
    [Subject(typeof(FizzBuzz))]
    public class when_bulk_translation_starts_with_1_and_ends_with_100
    {
        It should_return_100_translation_entries
            = () => _translationEntries.Count.ShouldEqual(100);

        Because of
            = () => _translationEntries = _fizzBuzz.TranslateRange(1, 100);

        Establish context
            = () =>
              {
                  _fizzBuzz = new FizzBuzz();
              };

        static FizzBuzz _fizzBuzz;
        static List<TranslationEntry> _translationEntries;
    }
}