namespace KataTennis {
  using System;
  using NUnit.Framework;

  [TestFixture]
  public class When_Game_Starts {
    [Test]
    public void Then_Score_Is_Love_All() {
      var game = Game.Start();
      Assert.AreEqual("Love All", game.Score);
    }

    [Test]
    public void Then_Player_One_Has_No_Points() {
      var game = Game.Start();
      Assert.AreEqual(0, game.PointsOfPlayerOne);
    }

    [Test]
    public void Then_Player_Two_Has_No_Points() {
      var game = Game.Start();
      Assert.AreEqual(0, game.PointsOfPlayerTwo);
    }
  }
}
