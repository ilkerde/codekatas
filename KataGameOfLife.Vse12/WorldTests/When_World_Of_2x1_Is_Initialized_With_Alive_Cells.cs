using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_World_Of_2x1_Is_Initialized_With_Alive_Cells
    {
        [TestMethod]
        public void Then_Cell_At_Position_2x1_Is_Alive()
        {
            World world = new World(2, 1);
            world.SetCellAlive(2, 1);
            Assert.IsTrue(world.GetCell(2, 1).IsAlive);
        }
    }
}
