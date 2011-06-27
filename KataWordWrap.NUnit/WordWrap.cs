namespace KataWordWrap {
  using System;

  public class Wrapper {
    public static string Wrap(string text, int mark) {
      bool canWrap = text.Length > mark;

      if (!canWrap)
        return text;

      string textLine = text.Substring(0, mark);
      string remainingText = text.Substring(mark);

      if (IsSpaceAfterMark(text, mark))
        return textLine + NewLine + Wrap(remainingText.Substring(1), mark);

      int lastSpacingIndex = textLine.LastIndexOf(" ");
      bool hasPrecedingSpacing = lastSpacingIndex > 0;

      if (!hasPrecedingSpacing)
        return textLine + NewLine + Wrap(remainingText, mark);

      return text.Substring(0, lastSpacingIndex) + NewLine + Wrap(text.Substring(lastSpacingIndex + 1), mark);
    }

    private static bool IsSpaceAfterMark(string text, int mark) {
      return (text[mark - 1] != ' ') && (text[mark] == ' ');
    }

    private const string NewLine = "\n";
  }
}
