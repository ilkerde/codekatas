namespace Kata {
  using System;
  using System.Collections.Generic;

  public static class StringCalculator {
    public static int Add(string expression) {
      if (string.IsNullOrEmpty(expression))
        return 0;

      char[] separators;
      expression = AquireSeparators(expression, out separators);

      string[] parts = expression.Split(separators);

      int result = 0;
      foreach (var part in parts)
        result += Convert.ToInt32(part);

      return result;
    }

    private static string AquireSeparators(string expression, out char[] separators) {
      var separatorList = new List<char> { ',', '\n' };

      if (expression.StartsWith("//")) {
        separatorList.Add(expression[2]);
        expression = expression.Substring(expression.IndexOf('\n') + 1);
      }

      separators = separatorList.ToArray();
      return expression;
    }
  }
}
