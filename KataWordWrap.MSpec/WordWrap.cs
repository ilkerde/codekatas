namespace KataWordWrap {
  using System;

  public class Wrapper {
    public static string Wrap(string text, int size) {
      if (text.Length < size)
        return text;

      int lastSpaceIndex = text.LastIndexOf(" ", size);
      if (lastSpaceIndex < 0)
        return text.Substring(0, size) + '\n' + text.Substring(2);

      return text.Substring(0, lastSpaceIndex) + '\n' + text.Substring(lastSpaceIndex + 1);
    }
  }
}
