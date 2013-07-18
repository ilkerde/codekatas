using System;
using Xunit;

namespace Kata {
  public class When_A_Number_Is_Multiplied_To_A_Probability_Of_1 {
    [Fact] public void Then_The_Product_Equals_To_The_Number_Multiplied() {
      Assert.Equal(15, 15 * Probability.Of(1));
    }
  }
}
