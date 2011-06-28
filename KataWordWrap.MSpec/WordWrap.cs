namespace KataWordWrap {
  using System;

  public class Wrapper {
    public static string Wrap(string text, int size) {
      if (text.Length < size)
        return text;

      return text.Substring(0, size) + '\n' + text.Substring(2);
    }
  }
}
