namespace Kata {
  using System;

  public class Gillian {
    public static SplitPair Split(int number) {
      return new SplitPair { X=number/2, Y=number/2 };
    }
  }
}
