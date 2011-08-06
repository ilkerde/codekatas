namespace KataWordWrap.MSTest
{
  public static class Wrapper {
    public static string Wrap(string text, int marker) {
      if (text.Length <= marker) return text;
      string line = text.Substring(0, marker + 1);
      int lastSpaceOnLine = line.LastIndexOf(" ");

      if(lastSpaceOnLine > 0)
        return text.Substring(0, lastSpaceOnLine) + "\n" + Wrap(text.Substring(lastSpaceOnLine + 1), marker);

      return text.Substring(0, marker) + "\n" + Wrap(text.Substring(marker), marker);
    }
  }
}