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

    [Test]
    public void When_word_is_larger_than_wrap_marker_then_does_wrap() {
      var result = Wrapper.Wrap("word", 2);
      Assert.AreEqual("wo\nrd", result);
    }

    [Test]
    public void When_2_words_are_larger_than_wrap_marker_then_does_wrap_at_spacing() {
      var result = Wrapper.Wrap("very cool", 7);
      Assert.AreEqual("very\ncool", result);
    }

    [Test]
    public void When_wrap_marker_is_at_end_of_a_word_from_a_sequence_of_words_then_does_wrap_after_word() {
      var result = Wrapper.Wrap("very cool thing", 9);
      Assert.AreEqual("very cool\nthing", result);
    }

    [Test]
    public void When_text_is_twice_as_long_as_wrap_marker_and_marker_is_within_a_word_then_wraps_twice_at_spacing_before_word() {
      var result = Wrapper.Wrap("very cool thing", 7);
      Assert.AreEqual("very\ncool\nthing", result);
    }
  }
}
