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
            return _cells[GetCellIndex(x, y)];
        }

        public void SetCellAlive(int x, int y)
        {
            _cells[GetCellIndex(x, y)].IsAlive = true;
        }

        private int GetCellIndex(int x, int y) {
            return (x-1)*y+(y-1);
        }
    }
}
