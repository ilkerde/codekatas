namespace Kata {
  using System;
  using System.Linq;

  public class Game {
    Func<int, SplitPair> _splitter;

    public Game(Func<int, SplitPair> splitter) {
      _splitter = splitter;
    }

    public int Go(int number) {
      var split = _splitter(number);

      if (split.X > 1)
        _splitter(number);

      return split.X * split.Y;
    }
  }
}
