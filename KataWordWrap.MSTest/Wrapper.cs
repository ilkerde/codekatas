namespace KataWordWrap.MSTest
{
  public static class Wrapper {
    public static string Wrap(string text, int marker) {
      if (text.Length < marker) return text;
      return text.Substring(0, marker) + "\n" + text.Substring(marker);
    }
  }
}