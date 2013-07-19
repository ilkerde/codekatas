using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_World_Is_2x1_Big
    {
        [TestMethod]
        public void Then_Has_Different_Cells_On_Both_Positions()
        {
            World world = new World(2, 1);
            Assert.AreNotEqual(world.GetCell(1, 1), world.GetCell(2, 1));
        }
    }
}
