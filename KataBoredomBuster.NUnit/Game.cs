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
      var result = split.X * split.Y;

      if (split.Y > 1) {
        var subSplit = _splitter(split.Y);
        result += subSplit.X * subSplit.Y;
      }

      if (split.X > 1) {
        var subSplit = _splitter(split.X);
        result += subSplit.X * subSplit.Y;
      }

      return result;
    }
  }
}
