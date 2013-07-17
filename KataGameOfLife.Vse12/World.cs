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

            cell.NumberOfLivingNeighbors = (
                from xn in Enumerable.Range(x - 1, x + 1)
                from yn in Enumerable.Range(y - 1, y + 1)
                where GetCellIndex(x, y) != GetCellIndex(xn, yn) 
                && IsValidPosition(xn, yn) && IsCellAlive(xn, yn)
                select 1).Count();

            return cell;
        }

        public void SetCellAlive(int x, int y)
        {
            _cells[GetCellIndex(x, y)].IsAlive = true;
        }

        private bool IsCellAlive(int x, int y)
        {
            return _cells[GetCellIndex(x, y)].IsAlive;
        }

        private int GetCellIndex(int x, int y) {
            return (x-1)+(y-1)*_width;
        }

        private bool IsValidPosition(int x, int y)
        {
            return (x > 0 && y > 0) 
                && (x < _width + 1 && y < _height + 1);
        }

        public void NextGeneration()
        {
            _cells[GetCellIndex(1, 1)] = new Cell(_cells[GetCellIndex(1, 1)]);
        }
    }
}
