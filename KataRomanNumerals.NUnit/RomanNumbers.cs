namespace RomanNumbers {
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public static class RomanNumberExtensions {
    private class RomanValue {
      public string Roman;
      public int Value;
    }

    private static IEnumerable<RomanValue> romanvalues = 
      (new[] { 1000, 500, 100, 50, 10, 5, 1 })
        .Zip(new [] { "M", "D", "C", "L", "X", "V", "I" },
        (value, roman) => new RomanValue { Roman = roman, Value = value });

    public static string ToRoman(this int number) {
      string result = string.Empty;

      foreach (var romanvalue in romanvalues) {
        while (number >= romanvalue.Value) {
          result += romanvalue.Roman;
          number -= romanvalue.Value;
        }
      }

      result = result
        .Replace("DCCCC", "CM")
        .Replace("CCCC", "CD")
        .Replace("LXXXX", "XC")
        .Replace("XXXX", "XL")
        .Replace("VIIII", "IX")
        .Replace("IIII", "IV");

      return result;
    }
  }
}
