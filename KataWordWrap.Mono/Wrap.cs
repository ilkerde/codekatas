namespace KataWordWrap {
  using System;
  
  public class Wrapper {
    public static string Wrap(string input, int columnmarker) {
      if (input.Length < columnmarker)
        return input;

      string virtualLine = input.Substring(0, columnmarker);
      int lastSpaceIndex = virtualLine.LastIndexOf(" ");

      if (lastSpaceIndex > 0)
        return SplitLine(input, lastSpaceIndex, 1);

      return SplitLine(input, columnmarker);
    }

    private static string SplitLine(string text, int splitColumn, int omitCharsAtSplit=0) {
      return text.Substring(0, splitColumn)
        + "\n"
        + text.Substring(splitColumn + omitCharsAtSplit);
    }
  }
}
