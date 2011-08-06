namespace KataWordWrap.MSTest
{
  public static class Wrapper {
    public static string Wrap(string text, int marker) {
      return text.Substring(0, marker) + "\n" + text.Substring(marker);
    }
  }
}