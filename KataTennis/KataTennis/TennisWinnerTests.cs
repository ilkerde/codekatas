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
    }
}
