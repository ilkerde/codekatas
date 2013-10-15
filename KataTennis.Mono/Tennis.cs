namespace KataTennis {
  using System;
  using System.Linq;

  public class Game {
    public static Game Start() {
      return Game.At(0, 0);
    }

    public static Game At(int pointsOfPlayerOne, int pointsOfPlayerTwo) {
      return new Game {
        PointsOfPlayerOne = pointsOfPlayerOne,
        PointsOfPlayerTwo = pointsOfPlayerTwo,
        Score = Game.ScoreForPoints(pointsOfPlayerOne, pointsOfPlayerTwo)
      };
    }

    private static string ScoreForPoints(int pointsOfPlayerOne, int pointsOfPlayerTwo) {
      if ((pointsOfPlayerOne == 0) && (pointsOfPlayerTwo == 0))
        return "Love All";

      if ((pointsOfPlayerOne == 1) && (pointsOfPlayerTwo == 0))
        return "Fifteen Love";

      return "Fifteen All";
    }

    public string Score { get; set; }
    public int PointsOfPlayerOne { get; set; }
    public int PointsOfPlayerTwo { get; set; }
  }
}
