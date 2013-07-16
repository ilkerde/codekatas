namespace Kata {
  using System;

  public class Gillian {
    public static SplitPair Split(int number) {
      if (number < 2)
        throw new ArgumentException();

      if (number % 3 == 0)
        return new SplitPair { X=number/3, Y=2*number/3 };

      if (number % 2 == 0)
        return new SplitPair { X=number/2, Y=number/2 };

      return new SplitPair { X=1, Y=4 };
    }
  }
}
