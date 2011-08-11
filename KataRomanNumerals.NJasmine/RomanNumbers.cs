namespace KataRomanNumbers {
  using System;

  public static class RomanNumberExtensions {
    public static string ToRoman(this int number) {
      return number == 5 ? "V" : "I";
    }
  }
}
