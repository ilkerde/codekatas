namespace GameOfLife {
  using System;
  using NUnit.Framework;

  [TestFixture]
  public class when_dead_center_of_3x3_grid_has_exactly_3_neighbors {
    int[,] world = new int[,]{
      {0,0,0},
      {0,0,0},
      {1,1,1}
    };

    [Test]
    public void then_center_becomes_alive() {
      int[,] nextworld = GOL.Spin(world);
      Assert.AreEqual(1, nextworld[1,1]);
    }
  }

  [TestFixture]
  public class when_dead_center_of_3x3_grid_has_no_neighbors {
    int[,] world = new int[,]{
      {0,0,0},
      {0,0,0},
      {0,0,0}
    };

    [Test]
    public void then_center_stays_as_is() {
      int[,] nextworld = GOL.Spin(world);
      Assert.AreEqual(0, nextworld[1,1]);
    }
  }

  [TestFixture]
  public class when_dead_corner_of_3x3_grid_has_exactly_3_neighbors {
    int[,] world = new int[,]{
      {0,0,0},
      {1,1,0},
      {0,1,0}
    };

    [Test]
    public void then_corner_becomes_alive() {
      int[,] nextworld = GOL.Spin(world);
      Assert.AreEqual(1, nextworld[2,0]);
    }
  }

  [TestFixture]
  public class when_center_row_of_3x3_grid_is_all_alive_and_others_are_all_dead {
    int[,] world = new int[,]{
      {0,0,0},
      {1,1,1},
      {0,0,0}
    };

    [Test]
    public void then_center_top_becomes_alive() {
      int[,] nextworld = GOL.Spin(world);
      Assert.AreEqual(1, nextworld[0,1]);
    }

    [Test]
    public void then_right_top_stays_dead() {
      int[,] nextworld = GOL.Spin(world);
      Assert.AreEqual(0, nextworld[2,0]);
    }
  }

  [TestFixture]
  public class when_alive_center_of_3x3_grid_has_no_neighbors {
    int[,] world = new int[,]{
      {0,0,0},
      {0,1,0},
      {0,0,0}
    };

    [Test]
    public void then_center_dies() {
      int[,] nextworld = GOL.Spin(world);
      Assert.AreEqual(0, nextworld[1,1]);
    }
  }

  [TestFixture]
  public class when_alive_center_of_3x3_grid_has_two_neighbors {
    int[,] world = new int[,]{
      {0,0,0},
      {1,1,1},
      {0,0,0}
    };

    [Test]
    public void then_center_stays_alive() {
      int[,] nextworld = GOL.Spin(world);
      Assert.AreEqual(1, nextworld[1,1]);
    }
  }

  [TestFixture]
  public class when_alive_center_of_3x3_grid_has_three_neighbors {
    int[,] world = new int[,]{
      {0,1,0},
      {1,1,1},
      {0,0,0}
    };

    [Test]
    public void then_center_stays_alive() {
      int[,] nextworld = GOL.Spin(world);
      Assert.AreEqual(1, nextworld[1,1]);
    }
  }

  [TestFixture]
  public class when_alive_center_of_3x3_grid_has_more_than_three_neighbors {
    int[,] world = new int[,]{
      {0,1,0},
      {1,1,1},
      {0,1,0}
    };

    [Test]
    public void then_center_dies() {
      int[,] nextworld = GOL.Spin(world);
      Assert.AreEqual(0, nextworld[1,1]);
    }
  }

  [TestFixture]
  public class when_alive_center_of_3x3_grid_has_less_than_two_neighbors {
    int[,] world = new int[,]{
      {0,0,0},
      {1,1,0},
      {0,0,0}
    };

    [Test]
    public void then_center_dies() {
      int[,] nextworld = GOL.Spin(world);
      Assert.AreEqual(0, nextworld[1,1]);
    }
  }
}
