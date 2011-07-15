namespace KataWordWrap {
  using System;
  
  public class Wrapper {
    public static string Wrap(string input, int columnmarker) {
      if (input.Length <= columnmarker)
        return input;

      string virtualLine = input.Substring(0, columnmarker);
      int lastSpaceIndex = virtualLine.LastIndexOf(" ");

      if (lastSpaceIndex > 0)
        return SplitLine(input, lastSpaceIndex, columnmarker, 1);

      bool isMarkerBeforeSpace = 
        input.Length > columnmarker && 
        input[columnmarker] == ' ';

      return SplitLine(input, columnmarker, columnmarker, isMarkerBeforeSpace ? 1 : 0);
    }

    private static string SplitLine(string text, int splitColumn, int columnMarker, int omitCharsAtSplit=0) {
      return text.Substring(0, splitColumn)
        + "\n"
        + Wrap(text.Substring(splitColumn + omitCharsAtSplit), columnMarker);
    }
  }
}
