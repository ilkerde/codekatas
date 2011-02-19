using Machine.Specifications;

namespace KataFizzBuzz.MSpec
{
    [Subject(typeof(FizzBuzz))]
    public class when_number_is_multiples_of_three_and_five
    {
        It should_translate_to_FizzBuzz
            = () => _translation.ShouldEqual("FizzBuzz");

        Because of
            = () => _translation = _fizzBuzz.Translate(15);

        Establish context
            = () =>
              {
                  _fizzBuzz = new FizzBuzz();
              };

        static FizzBuzz _fizzBuzz;
        static string _translation;
    }
}