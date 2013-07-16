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
  }
}
