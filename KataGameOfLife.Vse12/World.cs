using System;
using System.Linq;

namespace KataGameOfLife.Vse12
{
    public class World
    {
        Cell[] _cells;
        int _width;
        int _height;

        public World(int x, int y)
        {
            _width = x;
            _height = y;
            _cells = (from i in Enumerable.Range(1, x * y)
                select new Cell()).ToArray();
        }

        public Cell GetCell(int x, int y)
        {
            Cell cell = _cells[GetCellIndex(x, y)];

            Cell neighborCell = new Cell();

            if (x > 1 && y > 1)
                cell.NumberOfLivingNeighbors += _cells[GetCellIndex(x - 1, y - 1)].IsAlive ? 1 : 0;

            if (x > 1 && y == 1)
                cell.NumberOfLivingNeighbors += _cells[GetCellIndex(x - 1, y)].IsAlive ? 1 : 0;

            if (x == 1 && y > 1)
                cell.NumberOfLivingNeighbors += _cells[GetCellIndex(x, y - 1)].IsAlive ? 1 : 0;

            if (x < _width && y < _height)
                cell.NumberOfLivingNeighbors += _cells[GetCellIndex(x + 1, y + 1)].IsAlive ? 1 : 0;

            return cell;
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
