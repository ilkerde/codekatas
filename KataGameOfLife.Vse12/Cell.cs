using System;

namespace KataGameOfLife.Vse12
{
    public class Cell
    {
        public Cell() { }
        
        public Cell(bool isAlive)
        {
            IsAlive = isAlive;
        }

        public Cell(bool isAlive, int numberOfLivingNeighbors)
        {
            IsAlive = isAlive;
            NumberOfLivingNeighbors = numberOfLivingNeighbors;
        }

        public bool IsAlive { get; private set; }
        public int NumberOfLivingNeighbors { get; private set; }

        public Cell NextGeneration()
        {
            IsAlive = NumberOfLivingNeighbors > 1 && NumberOfLivingNeighbors < 4;
            return this;
        }
    }
}
