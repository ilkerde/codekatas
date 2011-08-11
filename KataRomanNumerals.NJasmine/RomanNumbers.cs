namespace KataRomanNumbers {
  using System;
  using System.Collections.Generic;

  public static class RomanNumberExtensions {
    private static Dictionary<int, string> romanLetters = new Dictionary<int, string> {
      { 500, "D" },
      { 100, "C" },
      { 50, "L" },
      { 10, "X" },
      { 5, "V" },
      { 1, "I" }
    };

    public static string ToRoman(this int number) {
      if (romanLetters.ContainsKey(number))
        return romanLetters[number];

      return null;
    }
  }
}
