namespace KataWordWrap {
  using System;

  public class Wrapper {
    public static string Wrap(string text, int size) {
      if (text.Length < size)
        return text;

      int lastSpaceIndex = text.LastIndexOf(" ", size);
      if (lastSpaceIndex < 0)
        return SplitText(text, size, false);

      return SplitText(text, lastSpaceIndex, true);
    }

    private static string SplitText(string text, int position, bool omitSpace) {
      return 
          text.Substring(0, position) 
        + NewLine 
        + text.Substring(position + (omitSpace ? 1 : 0));
    }

    private const char NewLine = '\n';
  }
}
