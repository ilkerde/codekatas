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
    }
}
