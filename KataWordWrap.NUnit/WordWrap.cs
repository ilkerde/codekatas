namespace KataWordWrap {
  using System;

  public class Wrapper {
    public static string Wrap(string text, int mark) {
      if (text.Length > mark) {
        string firstLineCutoff = text.Substring(0, mark);
        int lastSpacingIndex = firstLineCutoff.LastIndexOf(" ");

        if (lastSpacingIndex < 0)
          return text.Substring(0, mark) + "\n" + text.Substring(mark);

        return text.Substring(0, lastSpacingIndex) + "\n" + text.Substring(lastSpacingIndex + 1);
      }

      return text;
    }
  }
}
