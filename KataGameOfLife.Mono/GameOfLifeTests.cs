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
}
