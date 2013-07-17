using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_World_Is_3x3_Big_And_Moves_To_Next_Generation
    {
        [TestMethod]
        public void Then_A_Previously_Free_Cell_With_3_Alive_Members_Becomes_Alive()
        {
            World world = new World(3, 3);
            world.SetCellAlive(1, 1);
            world.SetCellAlive(1, 2);
            world.SetCellAlive(1, 3);

            world.NextGeneration();

            Cell cell = world.GetCell(2, 2);
            Assert.IsTrue(cell.IsAlive);
        }
    }
}
