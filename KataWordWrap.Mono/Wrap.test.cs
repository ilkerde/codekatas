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

    [Test]
    public void When_Text_Is__Word_Here__And_Column_Marker_Is_6_Then_Does_Wrap_At_Space() {
      var result = Wrapper.Wrap("word here", 6);
      Assert.AreEqual("word\nhere", result);
    }

    [Test]
    public void When_Text_Is__Word_Here__And_Column_Marker_Is_4_Then_Does_Wrap_At_Space() {
      var result = Wrapper.Wrap("word here", 4);
      Assert.AreEqual("word\nhere", result);
    }

    [Test]
    public void When_Text_Is__Word_Here_Baby__And_Column_Marker_Is_6_Then_Does_Wrap_At_Space_Twice() {
      var result = Wrapper.Wrap("word here baby", 6);
      Assert.AreEqual("word\nhere\nbaby", result);
    }
  }
}
