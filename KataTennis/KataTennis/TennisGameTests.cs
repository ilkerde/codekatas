using System;
using Xunit;

namespace KataTennis
{
    public class TennisGameTests
    {
        [Fact]
        public void When_Love_Love_Then_Game_Is_Not_Over()
        {
            TennisGame game = new TennisGame(Score.Love, Score.Love);
            Assert.False(game.IsOver);
        }

        [Fact]
        public void When_Forty_Love_And_PlayerOne_Scores_Then_Game_Is_Over()
        {
            TennisGame game = new TennisGame(Score.Forty, Score.Love);
            game.Score(Player.One);
            Assert.True(game.IsOver);
        }

        [Fact]
        public void When_Forty_Love_And_PlayerTwo_Scores_Then_Game_Is_Not_Over()
        {
            TennisGame game = new TennisGame(Score.Forty, Score.Love);
            game.Score(Player.Two);
            Assert.False(game.IsOver);
        }

        [Fact]
        public void When_Deuce_And_PlayerOne_Scores_Then_Game_Is_Not_Over()
        {
            TennisGame game = new TennisGame(Score.Forty, Score.Forty);
            game.Score(Player.One);
            Assert.False(game.IsOver);
        }

        [Fact]
        public void When_Deuce_And_PlayerOne_Scores_Twice_Then_Game_Is_Over()
        {
            TennisGame game = new TennisGame(Score.Forty, Score.Forty);
            game.Score(Player.One);
            game.Score(Player.One);
            Assert.True(game.IsOver);
        }

        [Fact]
        public void When_Deuce_And_PlayerOne_Scores_And_PlayerTwo_Scores_Then_Game_Is_Not_Over()
        {
            TennisGame game = new TennisGame(Score.Forty, Score.Forty);
            game.Score(Player.One);
            game.Score(Player.Two);
            Assert.False(game.IsOver);
        }
    }
}
