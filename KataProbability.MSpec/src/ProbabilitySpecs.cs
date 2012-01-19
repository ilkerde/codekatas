namespace Kata {
  using System;
  using Machine.Specifications;

  class When_the_inversion_prob_of_prob_1_is_required {
    It should_return_0 = () => new Probability(1)
      .InverseOf()
      .ShouldEqual(new Probability(0));
  }
}
