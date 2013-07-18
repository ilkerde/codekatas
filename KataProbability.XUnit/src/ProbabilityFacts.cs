using System;
using Xunit;

namespace Kata {
  public class When_A_Number_Is_Multiplied_To_A_Probability_Of_1 {
    [Fact] public void Then_The_Product_Equals_To_The_Number_Multiplied() {
      Assert.Equal(15, 15 * Probability.Of(1));
    }
  }

  public class When_A_Number_Is_Multiplied_To_A_Probability_Of_0 {
    [Fact] public void Then_Then_Product_Equals_To_0() {
      Assert.Equal(0, 15 * Probability.Of(0));
    }
  }

  public class When_Inverse_Of_Probability_1_Is_Calculated {
    [Fact] public void Then_Inverse_Equals_Probability_Of_0() {
      Assert.Equal(Probability.Of(0), Probability.Of(1).Inverse());
    }
  }

  public class When_Inverse_Of_Probability_0_Is_Calculated {
    [Fact] public void Then_Inverse_Equals_Probability_Of_1() {
      Assert.Equal(Probability.Of(1), Probability.Of(0).Inverse());
    }
  }

  public class When_Probability_Of_1_Is_Combined_With_Prabability_Of_1 {
    [Fact] public void Then_Combination_Equals_Probability_Of_1() {
      Assert.Equal(Probability.Of(1), Probability.Of(1).CombineWith(Probability.Of(1)));
    }
  }

  public class When_Probability_Of_1_Is_Combined_With_Prabability_Of_0 {
    [Fact] public void Then_Combination_Equals_Probability_Of_0() {
      Assert.Equal(Probability.Of(0), Probability.Of(1).CombineWith(Probability.Of(0)));
    }
  }

  public class When_Probability_Of_0_Is_Combined_With_Prabability_Of_1 {
    [Fact] public void Then_Combination_Equals_Probability_Of_0() {
      Assert.Equal(Probability.Of(0), Probability.Of(0).CombineWith(Probability.Of(1)));
    }
  }

  public class When_Probability_Of_Either_1_Or_1_Is_Calculated {
    [Fact] public void Then_Resulting_Probability_Is_1() {
      Assert.Equal(Probability.Of(1), Probability.Of(1).Either(Probability.Of(1)));
    }
  }
}
