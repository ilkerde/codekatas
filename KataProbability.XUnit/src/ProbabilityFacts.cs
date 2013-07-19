using System;
using Xunit;

namespace Kata {
  using P = Probability;

  public class When_A_Number_Is_Multiplied_To_A_Probability_Of_1 {
    [Fact] public void Then_The_Product_Equals_To_The_Number_Multiplied() {
      Assert.Equal(15, 15 * P.Of(1));
    }
  }

  public class When_A_Number_Is_Multiplied_To_A_Probability_Of_0 {
    [Fact] public void Then_Then_Product_Equals_To_0() {
      Assert.Equal(0, 15 * P.Of(0));
    }
  }

  public class When_Inverse_Of_Probability_1_Is_Calculated {
    [Fact] public void Then_Inverse_Equals_Probability_Of_0() {
      Assert.Equal(P.Of(0), P.Of(1).Inverse());
    }
  }

  public class When_Inverse_Of_Probability_0_Is_Calculated {
    [Fact] public void Then_Inverse_Equals_Probability_Of_1() {
      Assert.Equal(P.Of(1), P.Of(0).Inverse());
    }
  }

  public class When_Probability_Of_1_Is_Combined_With_Prabability_Of_1 {
    [Fact] public void Then_Combination_Equals_Probability_Of_1() {
      Assert.Equal(P.Of(1), P.Of(1).CombineWith(P.Of(1)));
    }
  }

  public class When_Probability_Of_1_Is_Combined_With_Prabability_Of_0 {
    [Fact] public void Then_Combination_Equals_Probability_Of_0() {
      Assert.Equal(P.Of(0), P.Of(1).CombineWith(P.Of(0)));
    }
  }

  public class When_Probability_Of_0_Is_Combined_With_Prabability_Of_1 {
    [Fact] public void Then_Combination_Equals_Probability_Of_0() {
      Assert.Equal(P.Of(0), P.Of(0).CombineWith(P.Of(1)));
    }
  }

  public class When_Probability_Of_Either_1_Or_1_Is_Calculated {
    [Fact] public void Then_Resulting_Probability_Is_1() {
      Assert.Equal(P.Of(1), P.Of(1).Either(P.Of(1)));
    }
  }

  public class When_Probability_Of_Either_1_Half_Or_1_Half_Is_Calculated {
    [Fact] public void Then_Resulting_Probability_Is_3_4th() {
      Assert.Equal(P.Of(.75m), P.Of(.5m).Either(P.Of(.5m)));
    }
  }
}
