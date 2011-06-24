namespace KataWordWrap {
  using System;
  using NUnit.Framework;

  [TestFixture]
  public class WordWrapTests {
    [Test]
    public void When_Text_Is__Word__And_Column_Marker_Is_6_Then_Does_Not_Wrap() {
      var result = Wrapper.Wrap("word", 6);
      Assert.AreEqual("word", result);
    }

    [Test]
    public void When_Text_Is__Word__And_Column_Marker_Is_2_Then_Does_Wrap() {
      var result = Wrapper.Wrap("word", 2);
      Assert.AreEqual("wo\nrd", result);
    }
  }
}
