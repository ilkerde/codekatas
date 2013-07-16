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

  [TestFixture]
  public class When_number_is_divisible_by_3 {
    [TestCase(3, 1, 2)]
    [TestCase(9, 3, 6)]
    public void Then_returns_X_as_one_third_of_number_and_Y_as_remainder(int number, int expectedX, int expectedY) {
      var split = Gillian.Split(9);
      split.ShouldSplitTo(3, 6);
    }
  }

  [TestFixture]
  public class When_number_is_1 {
    [Test]
    public void Then_does_not_split() {
      Assert.That(() => Gillian.Split(1), Throws.TypeOf<ArgumentException>());
    }
  }

  [TestFixture]
  public class When_number_is_not_divisible_by_2_or_3 {
    [TestCase(5, 1, 4)]
    [TestCase(11, 1, 10)]
    public void Then_returns_X_as_1_and_Y_as_remainder(int number, int expectedX, int expectedY) {
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
