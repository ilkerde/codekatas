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
            Cell cell = new Cell(false, 3);
            cell.NextGeneration();
            Assert.IsTrue(cell.IsAlive);
        }
    }
}
