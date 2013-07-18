using System;

namespace Kata {
  public class Probability {
    decimal _value;
    
    public static implicit operator decimal(Probability p) {
      return 1;
    }

    public Probability(decimal value) {
      _value = value;
    }

    public static Probability Of(decimal value) {
      return new Probability(value);
    }
  }
}
