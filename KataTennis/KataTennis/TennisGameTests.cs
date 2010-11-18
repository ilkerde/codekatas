using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace KataTennis
{
    public class TennisGameTests
    {
        [Fact]
        public void When_Love_Love_Then_Game_Is_Not_Over()
        {
            TennisGame game = new TennisGame(0, 0);
            Assert.False(game.IsOver);
        }

        [Fact]
        public void When_Forty_Love_And_PlayerOne_Scores_Then_Game_Is_Over()
        {
            TennisGame game = new TennisGame(3, 0);
            game.Score(Player.One);
            Assert.True(game.IsOver);
        }

        [Fact]
        public void When_Forty_Love_And_PlayerTwo_Scores_Then_Game_Is_Not_Over()
        {
            TennisGame game = new TennisGame(3, 0);
            game.Score(Player.Two);
            Assert.False(game.IsOver);
        }
    }
}
