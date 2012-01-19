namespace Kata {
  using System;

  class Probability : IEquatable<Probability> {
    decimal value;

    public Probability(decimal initialValue) {
      value = initialValue;
    }

    public Probability InverseOf() {
      return new Probability(0);
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
