namespace Kata {
  using System;
  using NUnit.Framework;

  [TestFixture] public class When_the_inverse_probability_of_a_probability_is_required {
    [TestCase(1, 0)]
    [TestCase(0, 1)]
    public void Then_a_probability_should_invert_to_1_minus_probability(decimal originalValue, decimal invertedValue) {
      Assert.AreEqual(
        P.Of(originalValue).InverseOf(), P.Of(invertedValue)
      );
    }
  }

  [TestFixture] 
  public class When_the_combined_probability_of_two_is_required {
    [TestCase(0.5, 0.5, 0.25)] 
    [TestCase(0.5, 0.1, 0.05)] 
    public void Then_the_combination_is_the_product_of_both(decimal firstValue, decimal secondValue, decimal expectedValue) {
      Assert.AreEqual(
        P.Of(firstValue).CombineWith(P.Of(secondValue)),
        P.Of(expectedValue)
      );
    }
  }

  public static class P {
    public static Probability Of(decimal value) {
      return new Probability(value);
    }
  }
}
