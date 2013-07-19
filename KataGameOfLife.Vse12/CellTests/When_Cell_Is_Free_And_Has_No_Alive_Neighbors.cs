using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_Cell_Is_Free_And_Has_No_Alive_Neighbors
    {
        [TestMethod]
        public void Then_Cell_Will_Stay_Free()
        {
            Cell cell = new Cell(false, 0);
            cell.NextGeneration();
            Assert.IsFalse(cell.IsAlive);
        }
    }
}
