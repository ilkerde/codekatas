namespace Kata {
  using System;
  using Machine.Specifications;

  class when_number_is_multiples_of_three {
    It should_translate_to__Fizz__ = 
      () => FizzBuzz.translate(6).ShouldEqual("Fizz");
  }
}
