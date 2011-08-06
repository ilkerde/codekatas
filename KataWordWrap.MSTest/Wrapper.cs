namespace KataWordWrap.MSTest
{
  public static class Wrapper {
    public static string Wrap(string text, int marker) {
      if (text.Length < marker) return text;
      string line = text.Substring(0, marker);
      int lastSpaceOnLine = line.LastIndexOf(" ");

      if(lastSpaceOnLine > 0)
        return text.Substring(0, lastSpaceOnLine) + "\n" + text.Substring(lastSpaceOnLine + 1);

      return text.Substring(0, marker) + "\n" + text.Substring(marker);
    }
  }
}