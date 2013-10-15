namespace KataTennis {
  using System;
  using System.Linq;
  using System.Collections.Generic;

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
        points.AreEqual() ?
          points.IsAnyAboveThirty() ?
            "Deuce"
          :
            scoreOfPlayerOne + " All"
        :
          points.IsAnyInAdvantage() ?
            points.IsPlayerOneLeading() ?
              "Advantage Player One"
            :
              "Advantage Player Two"
          :
            scoreOfPlayerOne + " " + scoreOfPlayerTwo
        ;
    }

    private static string ScoreForPoint(int point) {
      return PointTranslations
        .Where(pt => pt.Key == point)
        .Select(pt => pt.Value)
        .FirstOrDefault();
    }

    static Dictionary<int, string> PointTranslations = new Dictionary<int, string> {
      { 0, "Love" },
      { 1, "Fifteen" },
      { 2, "Thirty" },
      { 3, "Forty" }
    };

    public class Points {
      public bool AreEqual() {
        return PlayerOne == PlayerTwo;
      }

      public bool IsAnyAboveThirty() {
        return PlayerOne > 2 || PlayerTwo > 2;
      }

      public bool IsAnyInAdvantage() {
        return PlayerOne > 3 || PlayerTwo > 3;
      }

      public bool IsPlayerOneLeading() {
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
