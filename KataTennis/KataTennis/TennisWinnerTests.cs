using System;
using Xunit;

namespace KataTennis
{
    public class TennisWinnerTests
    {
        [Fact]
        public void When_Love_Love_Then_Theres_No_Winner()
        {
            TennisGame game = new TennisGame(Score.Love, Score.Love);

            Assert.False(game.IsWinner(Player.One));
            Assert.False(game.IsWinner(Player.Two));
        }

        [Fact]
        public void When_Forty_Love_And_PlayerOne_Scores_Then_PlayerOne_Wins()
        {
            TennisGame game = new TennisGame(Score.Forty, Score.Love);
            game.Score(Player.One);

            Assert.True(game.IsWinner(Player.One));
        }

        [Fact]
        public void When_Love_Forty_And_PlayerTwo_Scores_Then_PlayerTwo_Wins()
        {
            TennisGame game = new TennisGame(Score.Love, Score.Forty);
            game.Score(Player.Two);

            Assert.True(game.IsWinner(Player.Two));
        }
    }
}
