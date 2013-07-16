namespace Kata {
  using System;
  using System.Linq;

  public class Game {
    Func<int, SplitPair> _splitter;

    public Game(Func<int, SplitPair> splitter) {
      _splitter = splitter;
    }

    public int Go(int number) {
      _splitter(0);
      return 0;
    }
  }
}
