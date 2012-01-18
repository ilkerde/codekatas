namespace Kata {
  using System;
  using Machine.Specifications;

  class When_having_numbers_separated_by_comma {
    It should_return_the_sum_of_both_numbers = () 
      => StringCalculator.Add("2,2").ShouldEqual(4); 
  }

  class When_having_just_a_single_number {
    It should_return_just_the_number = ()
      => StringCalculator.Add("3").ShouldEqual(3);
  }

  class When_having_nothing_at_all {
    It should_return_zero = ()
      => StringCalculator.Add("").ShouldEqual(0);
  }

  class When_having_numbers_separated_by_newline {
    It should_return_the_sum_of_all_numbers = ()
      => StringCalculator.Add("3\n5").ShouldEqual(8);
  }

  class When_having_expression_with_first_line_being_doubleslash_plus_char {
    It should_use_given_char_as_valid_separator = ()
      => StringCalculator.Add("//:\n2:8").ShouldEqual(10);
  }
}
