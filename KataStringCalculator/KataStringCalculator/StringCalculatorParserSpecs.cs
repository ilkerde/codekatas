using System;
using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace KataStringCalculator
{
    public class StringCalculatorParserSpecs
    {
        public class when_source_starts_with_line_with_double_slash_followed_by_a_delimiter : for_parsing_calculator_source
        {
            It should_parse_two_numbers_separated_by_the_delimiter
                = () => numbers.Count().ShouldEqual(2);

            Because of
                = () => numbers = parser.Parse("//;\n7;8");
        }

        public class when_source_has_newline_and_comma_as_separator_for_three_numbers : for_parsing_calculator_source
        {
            It should_parse_three_numbers
                = () => numbers.Count().ShouldEqual(3);

            Because of
                = () => numbers = parser.Parse("7,8\n9");
        }

        public class when_source_has_newline_as_number_separator_between_two_numbers : for_parsing_calculator_source
        {
            It should_parse_two_numbers
                = () => numbers.Count().ShouldEqual(2);

            Because of
                = () => numbers = parser.Parse("7\n8");
        }

        public class when_source_has_newline_and_comma_as_separator_without_number_in_between : for_parsing_calculator_source
        {
            It should_throw_an_invalidoperationexception
                = () => exception.ShouldNotBeNull();

            Because of
                = () =>
                  {
                      exception = Catch.Exception(() => parser.Parse("7,\n9"));
                  };

            static Exception exception;
        }

        public abstract class for_parsing_calculator_source
        {
            Establish context
                = () => parser = new StringCalculatorParser();

            protected static IEnumerable<int> numbers;
            protected static StringCalculatorParser parser { get; private set; }
        }
    }
}