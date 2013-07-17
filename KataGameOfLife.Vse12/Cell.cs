using System;

namespace KataGameOfLife.Vse12
{
    public class Cell
    {
        public bool IsAlive { get; set; }
        public int NumberOfLivingNeighbors { get; set; }

        public void NextGeneration()
        {
            if (NumberOfLivingNeighbors == 3)
                IsAlive = true;
            else
            {
                if (NumberOfLivingNeighbors < 2)
                    IsAlive = false;
            }
        }
    }
}
