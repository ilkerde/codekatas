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
          return scoreOfPlayerOne + " Player One";

        return scoreOfPlayerTwo + " Player Two";
      }

      if (pointsOfPlayerTwo > 3)
        return scoreOfPlayerTwo + " Player Two";

      return scoreOfPlayerOne + " " + scoreOfPlayerTwo;
    }

    private static string ScoreForPoint(int point) {
      return (new[] {
        new PointTranslation(p => p == 0, "Love"),
        new PointTranslation(p => p == 1, "Fifteen"),
        new PointTranslation(p => p == 2, "Thirty"),
        new PointTranslation(p => p == 3, "Forty"),
        new PointTranslation(p => p > 3, "Advantage")
      })
        .Where(pt => pt.Matches(point))
        .Select(pt => pt.Score)
        .FirstOrDefault();
    }

    private class PointTranslation {
      public PointTranslation(Func<int, bool> matcher, string score) {
        Matcher = matcher;
        Score = score;
      }

      public bool Matches(int point) {
        return Matcher(point);
      }

      public Func<int, bool> Matcher { get; set; }
      public string Score { get; set; }
    }

    public string Score { get; set; }
    public int PointsOfPlayerOne { get; set; }
    public int PointsOfPlayerTwo { get; set; }
  }
}
