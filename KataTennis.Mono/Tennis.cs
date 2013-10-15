namespace KataTennis {
  using System;
  using System.Linq;

  public class Game {
    public static Game Start() {
      return new Game {
        Score = "Love All"
      };
    }

    public string Score { get; set; }
    public int PointsOfPlayerOne { get; set; }
    public int PointsOfPlayerTwo { get; set; }
  }
}
