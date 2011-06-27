namespace KataWordWrap {
  using System;

  public class Wrapper {
    public static string Wrap(string text, int mark) {
      if (text.Length > mark) {
        string firstLineCutoff = text.Substring(0, mark);
        
        if (IsSpaceAfterMark(text, mark))
          return firstLineCutoff + NewLine + text.Substring(mark + 1);

        int lastSpacingIndex = firstLineCutoff.LastIndexOf(" ");

        if (lastSpacingIndex < 0)
          return firstLineCutoff + NewLine + text.Substring(mark);

        return text.Substring(0, lastSpacingIndex) + NewLine + text.Substring(lastSpacingIndex + 1);
      }

      return text;
    }

    private static bool IsSpaceAfterMark(string text, int mark) {
      return (text[mark - 1] != ' ') && (text[mark] == ' ');
    }

    private const string NewLine = "\n";
  }
}
