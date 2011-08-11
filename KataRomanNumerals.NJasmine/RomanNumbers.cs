namespace KataRomanNumbers {
  using System;
  using System.Linq;
  using System.Collections.Generic;

  public static class RomanNumberExtensions {
    private static SortedDictionary<int, char> romanLetters = new SortedDictionary<int, char> {
      { 1000, 'M' },
      { 500, 'D' },
      { 100, 'C' },
      { 50, 'L' },
      { 10, 'X' },
      { 5, 'V' },
      { 1, 'I' }
    };

    public static string ToRoman(this int number) {
      foreach (var romanLetter in romanLetters.Reverse()) {
        if (romanLetter.Key == number)
          return romanLetter.Value.ToString();

        if (romanLetter.Key < number)
          return new String(romanLetter.Value, number);
      }

      return null;
    }
  }
}
