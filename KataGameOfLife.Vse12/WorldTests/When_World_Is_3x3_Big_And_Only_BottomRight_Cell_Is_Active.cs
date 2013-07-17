using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_World_Is_3x3_Big_And_Only_BottomRight_Cell_Is_Active
    {
        [TestMethod]
        public void Then_Cell_In_Center_Has_1_Active_Neighbor()
        {
            World world = new World(3, 3);
            world.SetCellAlive(3, 3);

            Cell cell = world.GetCell(2, 2);
            Assert.AreEqual(1, cell.NumberOfLivingNeighbors);
        }

        [TestMethod]
        public void Then_Cell_In_BottomCenter_Has_1_Active_Neighbor()
        {
            World world = new World(3, 3);
            world.SetCellAlive(3, 3);

            Cell cell = world.GetCell(2, 3);
            Assert.AreEqual(1, cell.NumberOfLivingNeighbors);
        }
    }
}
