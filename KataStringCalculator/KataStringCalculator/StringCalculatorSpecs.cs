using System;
using System.Linq;
using System.Text;

using Machine.Specifications;

namespace KataStringCalculator
{
    public class StringCalculatorSpecs
    {
        public class when_source_has_more_than_one_negative_number : for_calculator_add
        {
            It should_throw_an_argumentexception
                = () => exception.ShouldBeOfType(typeof(ArgumentException));

            It should_have_all_negative_numbers_within_the_exception_message
                = () => (
                    exception.Message.Contains("-1")
                    && exception.Message.Contains("-2")
                    ).ShouldBeTrue();

            Because of 
                = () => 
                {
                    exception = Catch.Exception(() => calculator.Add("-1,-2"));
                };

            static Exception exception;
        }

        public class when_source_has_a_negative_number : for_calculator_add
        {
            It should_throw_an_argumentexception
                = () => exception.ShouldBeOfType(typeof(ArgumentException));

            It should_have_the_negative_number_within_the_exception_message
                = () => exception.Message.ShouldContain("-1");

            Because of 
                = () => 
                {
                    exception = Catch.Exception(() => calculator.Add("-1"));
                };

            static Exception exception;
        }

        public class when_source_has_three_numbers : for_calculator_add
        {
            It should_result_the_sum_of_all_numbers
                = () => result.ShouldEqual(24);

            Because of
                = () => result = calculator.Add("7,8,9");
        }

        public class when_source_has_two_numbers : for_calculator_add
        {
            It should_result_the_sum_of_both_numbers
                = () => result.ShouldEqual(15);

            Because of
                = () => result = calculator.Add("7,8");
        }

        public class when_source_is_single_number : for_calculator_add
        {
            It should_result_the_number_given
                = () => result.ShouldEqual(5);

            Because of
                = () => result = calculator.Add("5");
        }

        public class when_source_is_empty : for_calculator_add
        {
            It should_result_to_zero
                = () => result.ShouldEqual(0);

            Because of
                = () => result = calculator.Add(String.Empty);
        }

        public abstract class for_calculator_add
        {
            Establish context
                = () => calculator = new StringCalculator(new StringCalculatorParser());

            protected static int result;
            protected static StringCalculator calculator { get; private set; }
        }
    }
}
