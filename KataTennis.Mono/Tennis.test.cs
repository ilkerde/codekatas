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
      Assert.AreEqual(0, _game.Points.PlayerOne);
    }

    [Test]
    public void Then_Player_Two_Has_No_Points() {
      Assert.AreEqual(0, _game.Points.PlayerTwo);
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

  [TestFixture]
  public class When_Both_Players_Have_Three_Points {
    [Test]
    public void Then_Score_Is_Deuce() {
      var game = Game.At(3, 3);
      Assert.AreEqual("Deuce", game.Score);
    }
  }

  [TestFixture]
  public class When_Player_One_Has_1_Point_More_From_Deuce {
    [Test]
    public void Then_Score_Is_Advantage_Player_One() {
      var game = Game.At(4, 3);
      Assert.AreEqual("Advantage Player One", game.Score);
    }
  }

  [TestFixture]
  public class When_Player_Two_Has_1_Point_More_From_Deuce {
    [Test]
    public void Then_Score_Is_Advantage_Player_Two() {
      var game = Game.At(3, 4);
      Assert.AreEqual("Advantage Player Two", game.Score);
    }
  }

  [TestFixture]
  public class When_Opponent_Equalizes_Again_From_Advantage {
    [Test]
    public void Then_Score_Is_Deuce() {
      var game = Game.At(4, 4);
      Assert.AreEqual("Deuce", game.Score);
    }
  }

  [TestFixture]
  public class When_Player_Two_Has_1_Point_More_From_Deuce_Again {
    [Test]
    public void Then_Score_Is_Advantage_Player_Two() {
      var game = Game.At(4, 5);
      Assert.AreEqual("Advantage Player Two", game.Score);
    }
  }

  [TestFixture]
  public class When_Player_One_Has_2_Points_More_From_Deuce_Onwards {
    [Test]
    public void Then_Score_Is_Game_Player_One() {
      var game = Game.At(5, 3);
      Assert.AreEqual("Game Player One", game.Score);
    }
  }

  [TestFixture]
  public class When_Player_Two_Has_3_Points {
    [Test]
    public void Then_Is_Any_Above_Thirty_Is_True() {
      var points = new Game.GamePoints { PlayerTwo = 3 };
      Assert.IsTrue(points.IsAnyAboveThirty());
    }
  }
}
