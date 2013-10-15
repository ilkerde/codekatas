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
  }
}
