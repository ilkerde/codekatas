using System;

namespace KataGameOfLife.Vse12
{
    public class World
    {
        public World(int x, int y)
        {
        }

        public Cell GetCell(int x, int y)
        {
            return new Cell();
        }

        internal void SetCellAlive(int p1, int p2)
        {
            throw new NotImplementedException();
        }
    }
}
