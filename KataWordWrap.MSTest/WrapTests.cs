using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataWordWrap.MSTest {
  [TestClass]
  public class WrapTests {
    [TestMethod]
    public void When_Word_Is_Longer_Than_Marker_Then_Wraps_Word_At_Marker() {
      Assert.AreEqual("word\nwrap", Wrapper.Wrap("wordwrap", 4));
    }
    [TestMethod]
    public void When_Word_Is_Shorter_Than_Marker_Then_Does_Not_Wrap() {
      Assert.AreEqual("wordwrap", Wrapper.Wrap("wordwrap", 12));
    }
    [TestMethod]
    public void When_Marker_Is_On_2nd_Word_Then_Wraps_At_Spacing() {
      Assert.AreEqual("word\nwrap", Wrapper.Wrap("word wrap", 7));
    }
    [TestMethod]
    public void When_Marker_Is_On_End_Of_1st_Word_Right_Before_Space_Then_Wraps_At_Spacing() {
      Assert.AreEqual("word\nwrap", Wrapper.Wrap("word wrap", 4));
    }
  }
}
