using Machine.Specifications;

namespace KataFizzBuzz.MSpec
{
    [Subject(typeof(FizzBuzz))]
    public class when_number_is_multiples_of_five
    {
        It should_translate_to_Buzz
            = () => _translation.ShouldEqual("Buzz");

        Because of
            = () => _translation = _fizzBuzz.Translate(10);

        Establish context
            = () =>
              {
                  _fizzBuzz = new FizzBuzz();
              };

        static FizzBuzz _fizzBuzz;
        static string _translation;
    }
}