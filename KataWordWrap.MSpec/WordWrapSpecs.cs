namespace KataWordWrap {
  using System;
  using Machine.Specifications;

  public class WordWrapTests {
    public class when_word_is_shorter_than_wrap_marker {
      It should_not_wrap = () => text.ShouldEqual("word");
      Because of = () => text = new Wrapper(7).Wrap("word");

      static string text;
    }

    public class when_word_is_longer_than_wrap_marker {
      It should_wrap_word = () => text.ShouldEqual("wo\nrd");
      Because of = () => text = new Wrapper(2).Wrap("word");

      static string text;
    }

    public class when_marker_is_within_second_word {
      It should_wrap_at_space_before = () => text.ShouldEqual("very\ncool");
      Because of = () => text = new Wrapper(7).Wrap("very cool");

      static string text;
    }

    public class when_marker_is_at_end_of_first_word {
      It should_wrap_at_space_after = () => text.ShouldEqual("very cool\nthing");
      Because of = () => text = new Wrapper(9).Wrap("very cool thing");

      static string text;
    }

    public class when_marker_is_within_second_word_on_two_lines {
      It should_wrap_at_space_before_twice = () => text.ShouldEqual("very\ncool\nthing");
      Because of = () => text = new Wrapper(6).Wrap("very cool thing");

      static string text;
    }
  }
}
