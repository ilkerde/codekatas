namespace Kata {
  using System;
  using NUnit.Framework;

  [TestFixture] public class When_the_inverse_probability_of_a_probability_is_required {
    [Test] public void Then_a_probability_of_1_should_invert_to_0() {
      Assert.AreEqual(
        new Probability(1).InverseOf(),
        new Probability(0)
      );
    }
  }
}