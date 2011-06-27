namespace KataWordWrap {
  using System;
  using NUnit.Framework;

  [TestFixture]
  public class TestWordWrap {
    [Test]
    public void When_word_is_smaller_than_wrap_marker_then_does_not_wrap() {
      var result = Wrapper.Wrap("word", 7);
      Assert.AreEqual("word", result);
    }
  }
}
