﻿using System;

namespace KataGameOfLife.Vse12
{
    public class Cell
    {
        public bool IsAlive { get; set; }
        public int NumberOfLivingNeighbors { get; set; }

        public void NextGeneration()
        {
            IsAlive = NumberOfLivingNeighbors > 1 && NumberOfLivingNeighbors < 4;
        }
    }
}
