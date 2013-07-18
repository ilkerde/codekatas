using System;

namespace Kata {
  public class Probability : IEquatable<Probability> {
    decimal _value;
    
    public static implicit operator decimal(Probability p) {
      return p._value;
    }

    public Probability(decimal value) {
      _value = value;
    }

    public static Probability Of(decimal value) {
      return new Probability(value);
    }

    public Probability Inverse() {
      return Probability.Of(1 - _value);
    }

    public Probability CombineWith(Probability other) {
      return Probability.Of(other._value * _value);
    }

    public Probability Either(Probability other) {
      return Probability.Of(_value + other._value - CombineWith(other)._value);
    }

    public bool Equals(Probability other) {
      return other._value.Equals(_value);
    }

    public override bool Equals(object other) {
      return Equals(other as Probability);
    }

    public override int GetHashCode() {
      return _value.GetHashCode();
    }
  }
}
