using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLocCounter.Vse12
{
    public class LinesOfCode
    {
        public static int Count(string sourceCode)
        {
            return sourceCode.ToLines()
                .Where(line => IsNotSingleCommentLine(line))
                .Where(line => IsNotBlankLine(line))
                .Count();
        }

        private static bool IsNotBlankLine(string line)
        {
            return !String.IsNullOrWhiteSpace(line);
        }

        private static bool IsNotSingleCommentLine(string line)
        {
            return !line.StartsWith("//");
        }
    }
}
