namespace KataWordWrap {
  using System;
  using System.Linq;
  
  public class Wrapper {
    public static string Wrap(string input, int columnmarker) {
      Func<string, int, int, string> doSplitLine;
      
      doSplitLine = (text, splitPosition, splitOffset) => {
        return text.Substring(0, splitPosition)
          + "\n"
          + Wrap(text.Substring(splitPosition + splitOffset), columnmarker);
      };

      if (input.Length <= columnmarker)
        return input;

      int lastSpaceIndex = input.LastIndexOf(" ", columnmarker);

      bool hasSpaceInFirstLine = lastSpaceIndex > 0;
      bool isMarkerBeforeSpace = 
        input.Length > columnmarker && 
        input[columnmarker] == ' ';

      int splitColumn = hasSpaceInFirstLine 
        ? lastSpaceIndex : columnmarker;

      int omitCharsAtSplit = 
        hasSpaceInFirstLine || isMarkerBeforeSpace
        ? 1 : 0;

      return doSplitLine(input, splitColumn, omitCharsAtSplit);
    }
  }
}
