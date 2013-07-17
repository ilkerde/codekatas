using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_Cell_Is_Alive_And_Has_Less_Than_2_Neighbors
    {
        [TestMethod]
        public void Then_Cell_Will_Be_Freed()
        {
            Cell cell = new Cell
            {
                IsAlive = true,
                NumberOfLivingNeighbors = 1
            };

            cell.NextGeneration();

            Assert.IsFalse(cell.IsAlive);
        }
    }
}
