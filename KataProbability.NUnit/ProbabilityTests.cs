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

  public static class P {
    public static Probability Of(decimal value) {
      return new Probability(value);
    }
  }
}
