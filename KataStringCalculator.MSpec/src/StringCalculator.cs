namespace Kata {
  using System;

  public static class StringCalculator {
    public static int Add(string expression) {
      if (string.IsNullOrEmpty(expression))
        return 0;

      char[] separators = new [] { ',', '\n' };

      if (expression.StartsWith("//")) {
        separators = new [] { expression[2] };
        expression = expression.Substring(expression.IndexOf('\n'));
      }

      string[] parts = expression.Split(separators);

      int result = 0;
      foreach (var part in parts)
        result += Convert.ToInt32(part);

      return result;
    }
  }
}
