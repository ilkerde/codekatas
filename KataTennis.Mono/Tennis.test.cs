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

  [TestFixture]
  public class When_Both_Players_Have_No_Points {
    [Test]
    public void Then_Score_Is_Love_All() {
      var game = Game.At(0, 0);
      Assert.AreEqual("Love All", game.Score);
    }
  }

  [TestFixture]
  public class When_Both_Players_Have_A_Single_Point {
    [Test]
    public void Then_Score_Is_Fifteen_All() {
      var game = Game.At(1, 1);
      Assert.AreEqual("Fifteen All", game.Score);
    }
  }

  [TestFixture]
  public class When_Only_Player_One_Has_A_Single_Point {
    [Test]
    public void Then_Score_Is_Fifteen_Love() {
      var game = Game.At(1, 0);
      Assert.AreEqual("Fifteen Love", game.Score);
    }
  }

  [TestFixture]
  public class When_Only_Player_Two_Has_2_Points {
    [Test]
    public void Then_Score_Is_Love_Thirty() {
      var game = Game.At(0, 2);
      Assert.AreEqual("Love Thirty", game.Score);
    }
  }

  [TestFixture]
  public class When_Player_One_Has_3_And_Player_Two_Has_2_Points {
    [Test]
    public void Then_Score_Is_Forty_Thirty() {
      var game = Game.At(3, 2);
      Assert.AreEqual("Forty Thirty", game.Score);
    }
  }
}