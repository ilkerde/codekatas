namespace Kata {
  using System;
  using Machine.Specifications;

  class when_number_is_multiples_of_three {
    It should_translate_to__Fizz__ = 
      () => FizzBuzz.translate(6).ShouldEqual("Fizz");
  }

  class when_number_is_multiples_of_five {
    It should_translate_to__Buzz__ = 
      () => FizzBuzz.translate(10).ShouldEqual("Buzz");
  }

  class when_number_is_multiples_of_three_and_five {
    It should_translate_to__FizzBuzz__ = 
      () => FizzBuzz.translate(15).ShouldEqual("FizzBuzz");
  }
}
