using System;

namespace KataGameOfLife.Vse12
{
    public class World
    {
        Cell _cell = new Cell();

        public World(int x, int y)
        {
        }

        public Cell GetCell(int x, int y)
        {
            return _cell;
        }

        public void SetCellAlive(int x, int y)
        {
            _cell.IsAlive = true;
        }
    }
}
