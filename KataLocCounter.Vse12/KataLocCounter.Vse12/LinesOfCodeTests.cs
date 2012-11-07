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

        [TestMethod]
        public void Single_Line_Does_Count()
        {
            string sourceCode = "using System;";
            int loc = LinesOfCode.Count(sourceCode);
            Assert.AreEqual(1, loc);
        }

        [TestMethod]
        public void Multiple_Lines_Count()
        {
            string sourceCode = @"using System;
using System.Text;
using System.IO;";

            int loc = LinesOfCode.Count(sourceCode);
            Assert.AreEqual(3, loc);
        }
    }
}
