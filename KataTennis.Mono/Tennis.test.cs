namespace KataTennis {
  using System;
  using NUnit.Framework;

  [TestFixture]
  public class When_Game_Starts {
    Game _game = Game.Start();

    [Test]
    public void Then_Score_Is_Love_All() {
      Assert.AreEqual("Love All", _game.Score);
    }

    [Test]
    public void Then_Player_One_Has_No_Points() {
      Assert.AreEqual(0, _game.PointsOfPlayerOne);
    }

    [Test]
    public void Then_Player_Two_Has_No_Points() {
      Assert.AreEqual(0, _game.PointsOfPlayerTwo);
    }
  }
}
