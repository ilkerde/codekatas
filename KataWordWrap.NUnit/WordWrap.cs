namespace KataWordWrap {
  using System;

  public class Wrapper {
    public static string Wrap(string text, int mark) {
      if (text.Length > mark)
        return text.Substring(0, mark) + "\n" + text.Substring(mark);

      return text;
    }
  }
}
