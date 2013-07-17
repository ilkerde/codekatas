using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_Cell_Is_Alive_And_Has_2_Alive_Neighbors
    {
        [TestMethod]
        public void Then_Cell_Will_Stay_Alive()
        {
            Cell cell = new Cell
            {
                IsAlive = true,
                NumberOfLivingNeighbors = 2
            };

            cell.NextGeneration();

            Assert.IsTrue(cell.IsAlive);
        }
    }
}
