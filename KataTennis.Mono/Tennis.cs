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
      string scoreOfPlayerOne = Game.ScoreForPoint(pointsOfPlayerOne);
      string scoreOfPlayerTwo = Game.ScoreForPoint(pointsOfPlayerTwo);

      if (scoreOfPlayerOne == scoreOfPlayerTwo)
        return scoreOfPlayerOne + " All";

      return scoreOfPlayerOne + " " + scoreOfPlayerTwo;
    }

    private static string ScoreForPoint(int point) {
      if (point == 2) return "Thirty";
      return point > 0 ? "Fifteen" : "Love";
    }

    public string Score { get; set; }
    public int PointsOfPlayerOne { get; set; }
    public int PointsOfPlayerTwo { get; set; }
  }
}
