using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_Cell_Is_Free_And_Has_3_Alive_Neighbors
    {
        [TestMethod]
        public void Then_Cell_Will_Be_Alive_In_Next_Generation()
        {
            Cell cell = new Cell { 
                IsAlive = false, 
                NumberOfLivingNeighbors = 3
            };

            cell.NextGeneration();

            Assert.IsTrue(cell.IsAlive);
        }
    }

    [TestClass]
    public class When_Cell_Is_Free_And_Has_No_Alive_Neighbors
    {
        [TestMethod]
        public void Then_Cell_Will_Stay_Free()
        {
            Cell cell = new Cell
            {
                IsAlive = false,
                NumberOfLivingNeighbors = 0
            };

            cell.NextGeneration();

            Assert.IsFalse(cell.IsAlive);
        }
    }
}
