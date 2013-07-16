namespace Kata {
  using System;
  using NUnit.Framework;

  [TestFixture] 
  public class When_number_is_divisible_by_2 {
    [TestCase(2, 1, 1)]
    [TestCase(4, 2, 2)]
    public void Then_returns_X_and_y_as_number_divided_by_2(int number, int expectedX, int expectedY) {
      var split = Gillian.Split(number);
      split.ShouldSplitTo(expectedX, expectedY);
    }
  }

  public static class ShouldExtensions {
    public static void ShouldSplitTo(this SplitPair pair, int x, int y) {
      Assert.AreEqual(x, pair.X);
      Assert.AreEqual(y, pair.Y);
    }
  }
}
