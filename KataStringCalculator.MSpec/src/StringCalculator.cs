namespace Kata {
  using System;
  using System.Collections.Generic;

  public static class StringCalculator {
    public static int Add(string expression) {
      if (string.IsNullOrEmpty(expression))
        return 0;

      var separators = new List<char> { ',', '\n' };

      if (expression.StartsWith("//")) {
        separators.Add(expression[2]);
        expression = expression.Substring(expression.IndexOf('\n') + 1);
      }

      string[] parts = expression.Split(separators.ToArray());

      int result = 0;
      foreach (var part in parts)
        result += Convert.ToInt32(part);

      return result;
    }
  }
}
