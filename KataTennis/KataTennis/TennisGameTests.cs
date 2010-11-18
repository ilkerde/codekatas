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
            TennisGame game = new TennisGame("0:0");
            Assert.False(game.IsOver);
        }
    }
}
