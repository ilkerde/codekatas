using System;
using System.Linq;

namespace KataGameOfLife.Vse12
{
    public class World
    {
        Cell[] _cells;

        public World(int x, int y)
        {
            _cells = (from i in Enumerable.Range(1, x*y)
                select new Cell()).ToArray();
        }

        public Cell GetCell(int x, int y)
        {
            return _cells[(x-1)*y+(y-1)];
        }

        public void SetCellAlive(int x, int y)
        {
            _cells[y-1].IsAlive = true;
        }
    }
}
