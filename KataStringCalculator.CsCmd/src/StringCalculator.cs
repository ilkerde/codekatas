namespace Kata {
  using System;

  public class StringCalculator {
    public static int Add(string numbers) {
      if (numbers == string.Empty)
      {
        return 0;
      }

      var tokens = numbers.Split(',');

      if (tokens.Length > 1)
      {
        return Convert.ToInt32(tokens[0]) + Convert.ToInt32(tokens[1]);
      }

      return Convert.ToInt32(numbers);
    }
  }
}
