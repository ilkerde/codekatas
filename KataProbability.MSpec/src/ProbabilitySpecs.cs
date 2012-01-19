namespace Kata {
  using System;
  using Machine.Specifications;

  class When_the_inversion_prob_of_prob_1_is_required {
    It should_return_0 = () => P.Of(1)
      .InverseOf()
      .ShouldEqual(P.Of(0));
  }

  class When_the_inversion_prob_of_prob_dot3_is_required {
    It should_return_dot7 = () => P.Of(0.3m)
      .InverseOf()
      .ShouldEqual(P.Of(0.7m));
  }

  class When_the_combination_of_dot5_and_dot5_is_required {
    It should_return_dot25 = () => P.Of(0.5m)
      .CombineWith(P.Of(0.5m))
      .ShouldEqual(P.Of(0.25m));
  }

  class When_the_combination_of_dot5_and_dot1_is_required {
    It should_return_dot05 = () => P.Of(0.5m)
      .CombineWith(P.Of(0.1m))
      .ShouldEqual(P.Of(0.05m));
  }

  class When_the_either_prob_of_dot5_and_dot5_is_required {
    It should_return_dot75 = () => P.Of(0.5m)
      .Either(P.Of(0.5m))
      .ShouldEqual(P.Of(0.75m));
  }

  class When_the_either_prob_of_dot5_and_dot1_is_required {
    It should_return_dot55 = () => P.Of(0.5m)
      .Either(P.Of(0.1m))
      .ShouldEqual(P.Of(0.55m));
  }

  public static class P {
    public static Probability Of(decimal value) {
      return new Probability(value);
    }
  }
}
