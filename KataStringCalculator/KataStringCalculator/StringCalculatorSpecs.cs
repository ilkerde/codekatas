using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Machine.Specifications;

namespace KataStringCalculator
{
    public class StringCalculatorSpecs
    {
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
                = () => calculator = new StringCalculator();

            protected static int result;
            protected static StringCalculator calculator { get; private set; }
        }
    }
}
