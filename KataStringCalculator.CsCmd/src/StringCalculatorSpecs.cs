namespace Kata {
  using System;
  using Machine.Specifications;

  class When_empty_string_is_given {
    It should_return_0 = () 
      => StringCalculator.Add(string.Empty).ShouldEqual(0);
  }

  class When_a_single_number_is_given {
    It should_return_the_number = ()
      => StringCalculator.Add("7").ShouldEqual(7);
  }

  class When_two_numbers_separated_by_comma_are_given {
    It should_return_the_sum_of_numbers = ()
      => StringCalculator.Add("7,4").ShouldEqual(11);
  }
}
