namespace KataWordWrap.MSTest
{
  public static class Wrapper {
    public static string Wrap(string text, int marker) {
      const string newline = "\n";

      if (text.Length <= marker) return text;

      string line = text.Substring(0, marker + 1);
      int lastSpaceOnLine = line.LastIndexOf(" ");

      if(lastSpaceOnLine > 0)
        return text.Substring(0, lastSpaceOnLine) + newline + Wrap(text.Substring(lastSpaceOnLine + 1), marker);

      return text.Substring(0, marker) + newline + Wrap(text.Substring(marker), marker);
    }
  }
}