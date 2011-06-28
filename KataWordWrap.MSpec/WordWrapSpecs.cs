namespace KataWordWrap {
  using System;
  using Machine.Specifications;

  public class WordWrapTests {
    public class when_word_is_shorter_than_wrap_marker {
      It should_not_wrap = () => text.ShouldEqual("word");
      Because of = () => text = Wrapper.Wrap("word", 7);

      static string text;
    }

    public class when_word_is_longer_than_wrap_marker {
      It should_wrap_word = () => text.ShouldEqual("wo\nrd");
      Because of = () => text = Wrapper.Wrap("word", 2);

      static string text;
    }

    public class when_marker_is_within_second_word {
      It should_wrap_at_space_before = () => text.ShouldEqual("very\ncool");
      Because of = () => text = Wrapper.Wrap("very cool", 7);

      static string text;
    }

    public class when_marker_is_at_end_of_first_word {
      It should_wrap_at_space_after = () => text.ShouldEqual("very cool\nthing");
      Because of = () => text = Wrapper.Wrap("very cool thing", 9);

      static string text;
    }
  }
}
