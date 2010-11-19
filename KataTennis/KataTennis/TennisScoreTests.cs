using System;
using Xunit;

namespace KataTennis
{
    public class TennisScoreTests
    {
        [Fact]
        public void When_Love_Love_Then_Score_Is_Love_Love()
        {
            TennisGame game = new TennisGame(Score.Love, Score.Love);

            Assert.Equal(Score.Love, game.GetScoreOf(Player.One));
            Assert.Equal(Score.Love, game.GetScoreOf(Player.Two));
        }

        [Fact]
        public void When_Thirty_Forty_And_PlayerOne_Scores_Then_Score_Is_Forty_Forty()
        {
            TennisGame game = new TennisGame(Score.Thirty, Score.Forty);
            game.GrantScoreTo(Player.One);

            Assert.Equal(Score.Forty, game.GetScoreOf(Player.One));
            Assert.Equal(Score.Forty, game.GetScoreOf(Player.Two));
        }

        [Fact]
        public void When_Thirty_Forty_And_PlayerTwo_Scores_Then_Score_Is_Love_Game()
        {
            TennisGame game = new TennisGame(Score.Thirty, Score.Forty);
            game.GrantScoreTo(Player.Two);

            Assert.Equal(Score.Love, game.GetScoreOf(Player.One));
            Assert.Equal(Score.Game, game.GetScoreOf(Player.Two));
        }

        [Fact]
        public void When_Forty_Forty_And_PlayerOne_Scores_Then_Score_Is_Advantage_Forty()
        {
            TennisGame game = new TennisGame(Score.Forty, Score.Forty);
            game.GrantScoreTo(Player.One);
            Assert.Equal(Score.Advantage, game.GetScoreOf(Player.One));
            Assert.Equal(Score.Forty, game.GetScoreOf(Player.Two));
        }
    }
}
