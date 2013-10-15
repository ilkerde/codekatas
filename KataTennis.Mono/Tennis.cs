namespace KataTennis {
  using System;
  using System.Linq;
  using System.Collections.Generic;

  public class Game {
    public static Game Start() {
      return Game.At(0, 0);
    }

    public static Game At(int pointsOfPlayerOne, int pointsOfPlayerTwo) {
      var points = new GamePoints { PlayerOne = pointsOfPlayerOne, PlayerTwo = pointsOfPlayerTwo };
      var score = Game.ScoreForPoints(points);

      return new Game {
        Points = points,
        Score = score
      };
    }

    private static string ScoreForPoints(GamePoints points) {
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
      return Game.PointTranslations
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

    public class GamePoints {
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

    public GamePoints Points { get; set; }
    public string Score { get; set; }
  }
}
