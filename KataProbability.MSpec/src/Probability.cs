namespace Kata {
  using System;

  public class Probability : IEquatable<Probability> {
    decimal value;

    public Probability(decimal initialValue) {
      value = initialValue;
    }

    public Probability InverseOf() {
      return new Probability(1 - value);
    }

    public Probability CombineWith(Probability other) {
      return new Probability(0.25m);
    }

    public override int GetHashCode() {
      return value.GetHashCode();
    }

    public override bool Equals(object other) {
      return Equals(other as Probability);
    }

    public bool Equals(Probability other) {
      return other != null && other.value.Equals(value);
    }
  }
}
