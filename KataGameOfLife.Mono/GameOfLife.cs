namespace GameOfLife {
  using System;

  public class GOL {
    public static int[,] Spin(int[,] world) {
      for (int x = 0; x < world.GetLength(0); x++) {
        for (int y = 0; y < world.GetLength(1); y++) {
          int neighbors = 0;

          for (int ex = x-1; ex <= x+1; ex++) {
            for (int ey = y-1; ey <= y+1; ey++) {
              if ((ex >= 0) && (ey >= 0) &&
                  (ex < world.GetLength(0)) &&
                  (ey < world.GetLength(1)))
                neighbors += world[ex, ey];
            }
          }

          world[x,y] = neighbors == 3 ? 1 : world[1,1];
        }
      }

      return world;
    }
  }
}
