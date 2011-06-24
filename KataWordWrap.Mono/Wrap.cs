namespace KataWordWrap {
  using System;
  
  public class Wrapper {
    public static string Wrap(string input, int columnmarker) {
      if (input.Length < columnmarker)
        return input;

      return input.Substring(0, columnmarker)
        + "\n"
        + input.Substring(columnmarker);
    }
  }
}
