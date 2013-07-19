using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_World_Of_1x2_Is_Initialized_With_Alive_Cells
    {
        [TestMethod]
        public void Then_Cell_At_Position_1x2_Is_Alive()
        {
            World world = new World(1, 2);
            world.SetCellAlive(1, 2);
            Assert.IsTrue(world.GetCell(1, 2).IsAlive);
        }
    }
}
