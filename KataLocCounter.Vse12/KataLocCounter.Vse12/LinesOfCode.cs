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
            bool isWithinMultilineComment = false;

            return sourceCode.ToLines()
                .Select(line => {
                    if (line.StartsWith("/*"))
                        isWithinMultilineComment = true;

                    if (line.IndexOf("*/") > line.IndexOf("/*"))
                        isWithinMultilineComment = false;

                    if (!isWithinMultilineComment)
                        return !line.EndsWith("*/") ? line : null;

                    return null;
                })
                .Where(line => IsNotBlankLine(line))
                .Where(line => IsNotSingleCommentLine(line))
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
