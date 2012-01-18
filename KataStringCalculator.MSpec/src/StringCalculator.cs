namespace Kata {
  using System;

  public static class StringCalculator {
    public static int Add(string expression) {
      string[] parts = expression.Split(',');
     
      int result = 0;
      foreach (var part in parts)
        result += Convert.ToInt32(part);

      return result;
    }
  }
}
