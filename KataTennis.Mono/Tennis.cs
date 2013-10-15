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

      if (pointsOfPlayerOne == pointsOfPlayerTwo)
        return pointsOfPlayerOne > 2
          ? "Deuce"
          : scoreOfPlayerOne + " All";

      if (pointsOfPlayerOne > 3 || pointsOfPlayerTwo > 3) {
        bool isPlayerOneLeading = pointsOfPlayerOne > pointsOfPlayerTwo;

        if (isPlayerOneLeading)
          return "Advantage Player One";

        return "Advantage Player Two";
      }

      return scoreOfPlayerOne + " " + scoreOfPlayerTwo;
    }

    private static string ScoreForPoint(int point) {
      return (new[] {
        new PointTranslation(0, "Love"),
        new PointTranslation(1, "Fifteen"),
        new PointTranslation(2, "Thirty"),
        new PointTranslation(3, "Forty"),
      })
        .Where(pt => pt.Point == point)
        .Select(pt => pt.Score)
        .FirstOrDefault();
    }

    private class PointTranslation {
      public PointTranslation(int point, string score) {
        Point = point;
        Score = score;
      }
      public int Point { get; set; }
      public string Score { get; set; }
    }

    public string Score { get; set; }
    public int PointsOfPlayerOne { get; set; }
    public int PointsOfPlayerTwo { get; set; }
  }
}
