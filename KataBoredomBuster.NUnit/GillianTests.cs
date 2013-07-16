namespace Kata {
  using System;
  using NUnit.Framework;

  [TestFixture] 
  public class When_number_is_divisible_by_2 {
    [Test]
    public void Then_returns_X_as_number_divided_by_2() {
      var split = Gillian.Split(2);
      Assert.AreEqual(1, split.X);
    }

    [Test]
    public void Then_returns_Y_as_number_divided_by_2() {
      var split = Gillian.Split(2);
      Assert.AreEqual(1, split.Y);
    }
  }

  [TestFixture] 
  public class When_number_is_4 {
    [Test]
    public void Then_returns_X_as_number_divided_by_2() {
      var split = Gillian.Split(4);
      Assert.AreEqual(2, split.X);
    }

    [Test]
    public void Then_returns_Y_as_number_divided_by_2() {
      var split = Gillian.Split(4);
      Assert.AreEqual(2, split.Y);
    }
  }
}
