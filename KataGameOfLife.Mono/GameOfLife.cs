namespace GameOfLife {
  using System;

  public class GOL {
    public static int[,] Spin(int[,] world) {
      world[1,1] = 1;
      return world;
    }
  }
}
