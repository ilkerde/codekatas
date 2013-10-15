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
        Score = Game.ScoreForPoints(new Points { PlayerOne = pointsOfPlayerOne, PlayerTwo = pointsOfPlayerTwo })
      };
    }

    private static string ScoreForPoints(Points points) {
      string scoreOfPlayerOne = Game.ScoreForPoint(points.PlayerOne);
      string scoreOfPlayerTwo = Game.ScoreForPoint(points.PlayerTwo);

      return
        points.ArePointsEqual() ?
          IsAboveThirty(points.PlayerOne) ?
            "Deuce"
          :
            scoreOfPlayerOne + " All"
        :
          points.IsAnyAdvantage() ?
            points.IsFirstLeading() ?
              "Advantage Player One"
            :
              "Advantage Player Two"
          :
            scoreOfPlayerOne + " " + scoreOfPlayerTwo
        ;
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

    private static bool IsAboveThirty(int p) {
      return p > 2;
    }

    private class PointTranslation {
      public PointTranslation(int point, string score) {
        Point = point;
        Score = score;
      }
      public int Point { get; set; }
      public string Score { get; set; }
    }

    private class Points {
      public bool ArePointsEqual() {
        return PlayerOne == PlayerTwo;
      }

      public bool IsAnyAdvantage() {
        return PlayerOne > 3 || PlayerTwo > 3;
      }

      public bool IsFirstLeading() {
        return PlayerOne > PlayerTwo;
      }

      public int PlayerOne { get; set; }
      public int PlayerTwo { get; set; }
    }

    public string Score { get; set; }
    public int PointsOfPlayerOne { get; set; }
    public int PointsOfPlayerTwo { get; set; }
  }
}
