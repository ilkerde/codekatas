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

            if (IsValidPosition(x - 1, y - 1) && IsCellAlive(x - 1, y - 1))
                cell.NumberOfLivingNeighbors++;

            if (IsValidPosition(x - 1, y) && IsCellAlive(x - 1, y))
                cell.NumberOfLivingNeighbors++;

            if (IsValidPosition(x, y - 1) && IsCellAlive(x, y - 1))
                cell.NumberOfLivingNeighbors++;

            if (IsValidPosition(x + 1, y - 1) && IsCellAlive(x + 1, y - 1))
                cell.NumberOfLivingNeighbors++;

            if (IsValidPosition(x + 1, y + 1) && IsCellAlive(x + 1, y + 1))
                cell.NumberOfLivingNeighbors++;

            if (IsValidPosition(x + 1, y) && IsCellAlive(x + 1, y))
                cell.NumberOfLivingNeighbors++;

            if (IsValidPosition(x, y + 1) && IsCellAlive(x, y + 1))
                cell.NumberOfLivingNeighbors++;

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
            return (x-1)*y+(y-1);
        }

        private bool IsValidPosition(int x, int y)
        {
            return (x > 0 && y > 0) 
                && (x < _width + 1 && y < _height + 1);
        }
    }
}
