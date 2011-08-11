namespace KataRomanNumbers {
  using System;
  using System.Linq;
  using System.Collections.Generic;

  public static class RomanNumberExtensions {
    private static SortedDictionary<int, char> romanLetters = new SortedDictionary<int, char> {
      { 1000, 'M' }, { 500, 'D' }, { 100, 'C' }, { 50, 'L' }, { 10, 'X' }, { 5, 'V' }, { 1, 'I' }
    };

    public static string ToRoman(this int number) {
      string roman = string.Empty;

      foreach (var romanLetter in romanLetters.Reverse()) {
        while (romanLetter.Key <= number) {
          roman += romanLetter.Value.ToString();
          number -= romanLetter.Key;
        }
      }

      return roman
        .Replace("IIII", "IV")
        .Replace("VIV", "IX")
        .Replace("XXXX", "XL")
        .Replace("LXL", "XC")
        .Replace("CCCC", "CD")
        .Replace("DCD", "CM");
    }
  }
}
