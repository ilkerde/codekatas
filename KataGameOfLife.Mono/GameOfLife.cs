namespace GameOfLife {
  using System;

  public class GOL {
    public static int[,] Spin(int[,] world) {
      int xMax = world.GetLength(0);
      int yMax = world.GetLength(1);

      int[,] newWorld = new int[xMax,yMax];

      for (int x = 0; x < xMax; x++) {
        for (int y = 0; y < yMax; y++) {
          int neighbors = GetNumberOfNeighbors(x, y, world);
          newWorld[x,y] = neighbors == 3 ? 1 : world[x,y];
        }
      }

      return newWorld;
    }

    private static int GetNumberOfNeighbors(int x, int y, int[,] world) {
      int xMax = world.GetLength(0);
      int yMax = world.GetLength(1);

      int neighbors = 0;

      for (int ex = x-1; ex <= x+1; ex++) {
        for (int ey = y-1; ey <= y+1; ey++) {
          if ((ex >= 0) && (ey >= 0) &&
              (ex < xMax) &&
              (ey < yMax))
            neighbors += world[ex, ey];
        }
      }

      return neighbors;
    }
  }
}
