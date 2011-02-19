using Machine.Specifications;

namespace KataFizzBuzz.MSpec
{
    [Subject(typeof(FizzBuzz))]
    public class when_number_is_multiples_of_three
    {
        It should_translate_to_Fizz
            = () => _translation.ShouldEqual("Fizz");

        Because of
            = () => _translation = _fizzBuzz.Translate(6);

        Establish context
            = () =>
                {
                    _fizzBuzz = new FizzBuzz();
                };

        static FizzBuzz _fizzBuzz;
        static string _translation;
    }
}
