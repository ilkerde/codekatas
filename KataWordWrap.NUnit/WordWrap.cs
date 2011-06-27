namespace KataWordWrap {
  using System;

  public class Wrapper {
    public static string Wrap(string text, int mark) {
      if (text.Length > mark) {
        string firstLineCutoff = text.Substring(0, mark);
        
        if (IsSpaceAfterMark(text, mark))
          return firstLineCutoff + NewLine + Wrap(text.Substring(mark + 1), mark);

        int lastSpacingIndex = firstLineCutoff.LastIndexOf(" ");

        if (lastSpacingIndex < 0)
          return firstLineCutoff + NewLine + Wrap(text.Substring(mark), mark);

        return text.Substring(0, lastSpacingIndex) + NewLine + Wrap(text.Substring(lastSpacingIndex + 1), mark);
      }

      return text;
    }

    private static bool IsSpaceAfterMark(string text, int mark) {
      return (text[mark - 1] != ' ') && (text[mark] == ' ');
    }

    private const string NewLine = "\n";
  }
}
