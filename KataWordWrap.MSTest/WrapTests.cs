using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataWordWrap.MSTest {
  [TestClass]
  public class WrapTests {
    [TestMethod]
    public void When_Word_Is_Longer_Than_Marker_Then_Wraps_Word_At_Marker() {
      Assert.AreEqual("word\nwrap", Wrapper.Wrap("wordwrap", 4));
    }
  }

  public static class Wrapper {
    public static string Wrap(string text, int marker) {
      throw new NotImplementedException();
    }
  }
}
