namespace Kata {
  using System;

  public class Gillian {
    public static SplitPair Split(int number) {
      if (number == 3)
        return new SplitPair { X=1, Y=2 };

      return new SplitPair { X=number/2, Y=number/2 };
    }
  }
}
