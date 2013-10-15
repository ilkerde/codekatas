namespace KataTennis {
  using System;
  using System.Linq;

  public class Game {
    public static Game Start() {
      return new Game();
    }

    public string Score { get; set; }
  }
}
