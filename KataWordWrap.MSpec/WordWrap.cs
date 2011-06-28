namespace KataWordWrap {
  using System;

  public class Wrapper {
    public static string Wrap(string text, int size) {
      if (text.Length <= size)
        return text;

      int lastSpaceIndex = text.LastIndexOf(" ", size);
      if (lastSpaceIndex < 0)
        return SplitText(text, size, size, false);

      return SplitText(text, lastSpaceIndex, size, true);
    }

    private static string SplitText(string text, int position, int size, bool omitSpace) {
      return 
          text.Substring(0, position) 
        + NewLine 
        + Wrap(text.Substring(position + (omitSpace ? 1 : 0)), size);
    }

    private const char NewLine = '\n';
  }
}
