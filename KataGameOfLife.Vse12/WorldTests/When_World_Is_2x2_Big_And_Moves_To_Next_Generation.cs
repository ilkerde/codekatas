using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataGameOfLife.Vse12
{
    [TestClass]
    public class When_World_Is_2x2_Big_And_Moves_To_Next_Generation
    {
        [TestMethod]
        public void Then_Cell_On_2x1_Is_Different_From_Old_On_Same_Position()
        {
            World world = new World(2, 2);
            Cell oldCell = world.GetCell(2, 1);
            
            world.NextGeneration();
            Cell newCell = world.GetCell(2, 1);

            Assert.AreNotEqual(oldCell, newCell);
        }
    }
}
