namespace KataWordWrap {
  using System;
  
  public class Wrapper {
    public static string Wrap(string input, int columnmarker) {
      if (input.Length < columnmarker)
        return input;

      string virtualLine = input.Substring(0, columnmarker);
      int lastSpaceIndex = virtualLine.LastIndexOf(" ");

      if (lastSpaceIndex > 0)
        return input.Substring(0, lastSpaceIndex)
          + "\n"
          + input.Substring(lastSpaceIndex + 1);

      return input.Substring(0, columnmarker)
        + "\n"
        + input.Substring(columnmarker);
    }
  }
}
