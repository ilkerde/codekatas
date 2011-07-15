namespace KataWordWrap {
  using System;

  public class Wrapper {
    private int _size;

    public Wrapper(int size) {
      _size = size;
    }

    public string Wrap(string text) {
      if (text.Length <= _size)
        return text;

      int lastSpaceIndex = text.LastIndexOf(" ", _size);
      if (lastSpaceIndex < 0)
        return SplitText(text, _size, false);

      return SplitText(text, lastSpaceIndex, true);
    }

    private string SplitText(string text, int position, bool omitSpace) {
      return 
          text.Substring(0, position) 
        + NewLine 
        + Wrap(text.Substring(position + (omitSpace ? 1 : 0)));
    }

    private const char NewLine = '\n';
  }
}
