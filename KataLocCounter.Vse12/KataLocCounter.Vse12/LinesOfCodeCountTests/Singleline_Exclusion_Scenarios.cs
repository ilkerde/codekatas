using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataLocCounter.Vse12
    .LinesOfCodeCountTests
{
    [TestClass]
    public class Singleline_Exclusion_Scenarioss
    {
        [TestMethod]
        public void Comment_Line_Does_Not_Count()
        {
            LinesOfCode.Count("// test")
                .ShouldBe(0);
        }

        [TestMethod]
        public void Blank_Line_Does_Not_Count()
        {
            LinesOfCode.Count(@"// test
using System;

using System.Text;")
                .ShouldBe(2);
        }
    }
}
