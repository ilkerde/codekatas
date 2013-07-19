namespace Kata {
  using System;
  using System.Linq;

  public class Game {
    Func<int, SplitPair> _splitter;

    public Game(Func<int, SplitPair> splitter) {
      _splitter = splitter;
    }

    public int Go(int number) {
      if (number < 2)
        return 0;

      var split = _splitter(number);
      
      return split.X * split.Y + Go(split.X) + Go(split.Y);
    }
  }
}
