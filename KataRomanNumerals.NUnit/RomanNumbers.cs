namespace RomanNumbers {
  using System;

  public static class RomanNumberExtensions {
    public static string ToRoman(this int number) {
      string result = string.Empty;

      while (number-- >= 1)
        result += "I";

      return result;
    }
  }
}
