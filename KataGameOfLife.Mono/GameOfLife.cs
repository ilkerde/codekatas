namespace GameOfLife {
  using System;

  public class GOL {
    public static int[,] Spin(int[,] world) {
      int x = 1, y = 1;

      int neighbors = 0;

      for (int ex = x-1; ex <= x+1; ex++)
        for (int ey = y-1; ey <= x+1; ey++)
          neighbors += world[ex, ey];

      world[1,1] = neighbors == 3 ? 1 : world[1,1];

      return world;
    }
  }
}
