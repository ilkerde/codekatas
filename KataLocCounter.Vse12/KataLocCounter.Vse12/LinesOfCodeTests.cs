using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataLocCounter.Vse12
{
    [TestClass]
    public class LinesOfCodeTests
    {
        [TestMethod]
        public void Empty_String_Does_Not_Count()
        {
            string sourceCode = String.Empty;
            int loc = LinesOfCode.Count(sourceCode);
            Assert.AreEqual(0, loc);
        }
    }
}
