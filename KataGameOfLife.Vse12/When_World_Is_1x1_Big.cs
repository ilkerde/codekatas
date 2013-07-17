using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_World_Is_1x1_Big
    {
        [TestMethod]
        public void Then_Cell_Is_On_Position_X1_Y1()
        {
            World world = new World(1, 1);
            Assert.IsNotNull(world.GetCell(1, 1));
        }
    }
}
