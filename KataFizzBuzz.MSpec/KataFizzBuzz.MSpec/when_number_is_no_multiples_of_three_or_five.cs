using Machine.Specifications;

namespace KataFizzBuzz.MSpec
{
    [Subject(typeof(FizzBuzz))]
    public class when_number_is_no_multiples_of_three_or_five
    {
        It should_translate_to_number
            = () => _translation.ShouldEqual("7");

        Because of
            = () => _translation = _fizzBuzz.Translate(7);

        Establish context
            = () =>
              {
                  _fizzBuzz = new FizzBuzz();
              };

        static FizzBuzz _fizzBuzz;
        static string _translation;
    }
}