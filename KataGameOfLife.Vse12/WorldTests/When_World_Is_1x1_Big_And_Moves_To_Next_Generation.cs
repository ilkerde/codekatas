using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_World_Is_1x1_Big_And_Moves_To_Next_Generation
    {
        [TestMethod]
        public void Then_New_Cell_On_Same_Position_Differs_From_Old_Cell()
        {
            World world = new World(1, 1);
            Cell oldCell = world.GetCell(1, 1);
            
            world.NextGeneration();
            Cell newCell = world.GetCell(1, 1);

            Assert.AreNotEqual(oldCell, newCell);
        }
    }
}
