using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_World_Of_1x1_Is_Initialized_With_Alive_Cell
    {
        [TestMethod]
        public void Then_Cell_Within_World_Is_Alive()
        {
            World world = new World(1, 1);
            world.SetCellAlive(1, 1);
            Assert.IsTrue(world.GetCell(1, 1).IsAlive);
        }
    }
}
