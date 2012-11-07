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
    public class Line_Insclusion_Scenarios
    {
        [TestMethod]
        public void Empty_String_Does_Not_Count()
        {
            LinesOfCode.Count(string.Empty)
                .ShouldBe(0);
        }

        [TestMethod]
        public void Single_Line_Does_Count()
        {
            LinesOfCode.Count("using System;")
                .ShouldBe(1);
        }

        [TestMethod]
        public void Multiple_Lines_Count()
        {
            LinesOfCode.Count(@"using System;
using System.Text;
using System.IO;")
                 .ShouldBe(3);
        }
    }
}
