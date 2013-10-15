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

    public Game ScorePlayerOne() {
      return Game.At(++Points.PlayerOne, 0);
    }

    private static string ScoreForPoints(GamePoints points) {
      return points.AreEqual()
        ? ScoreForPlayersEqual(points)
        : ScoreForPlayerLeading(points);
    }

    private static string ScoreForPlayerLeading(GamePoints points) {
      string scoreOfPlayerOne = Game.ScoreForPoint(points.PlayerOne);
      string scoreOfPlayerTwo = Game.ScoreForPoint(points.PlayerTwo);

      return points.IsAnyInAdvantage()
        ? ScoreForPlayerLeadingInAdvantage(points)
        : scoreOfPlayerOne + " " + scoreOfPlayerTwo;
    }

    private static string ScoreForPlayerLeadingInAdvantage(GamePoints points) {
      return points.IsAnyLeadingBy(2) 
        ? points.IsPlayerOneLeading() ? "Game Player One" : "Game Player Two"
        : points.IsPlayerOneLeading() ? "Advantage Player One" : "Advantage Player Two";
    }

    private static string ScoreForPlayersEqual(GamePoints points) {
      string scoreOfPlayerOne = Game.ScoreForPoint(points.PlayerOne);

      return points.IsAnyAboveThirty()
        ? "Deuce"
        : scoreOfPlayerOne + " All";
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

      public bool IsAnyLeadingBy(int difference) {
        return Math.Abs(PlayerTwo - PlayerOne) >= difference;
      }

      public int PlayerOne { get; set; }
      public int PlayerTwo { get; set; }
    }

    public GamePoints Points { get; set; }
    public string Score { get; set; }
  }
}
