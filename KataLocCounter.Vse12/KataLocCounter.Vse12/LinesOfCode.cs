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
                    bool wasWithinMultilineComment = isWithinMultilineComment;
                    isWithinMultilineComment = IsMultilineCommentActive(wasWithinMultilineComment, line);

                    if (!isWithinMultilineComment && (
                        (!wasWithinMultilineComment && IsNotStartingWithMultilineCommentToken(line)) ||
                        IsNotEndingWithMutlilineCommentEndToken(line)))
                        return line;

                    return null;
                })
                .Where(line => IsNotBlankLine(line))
                .Where(line => IsNotSingleCommentLine(line))
                .Count();
        }

        private static bool IsNotStartingWithMultilineCommentToken(string line)
        {
            return !line.StartsWith("/*");
        }

        private static bool IsNotEndingWithMutlilineCommentEndToken(string line)
        {
            return !line.EndsWith("*/");
        }

        private static bool IsMultilineCommentActive(bool wasWithinMultilineComment, string line)
        {
            bool isWithinMultilineComment = wasWithinMultilineComment;

            if (line.IndexOf("*/") < line.IndexOf("/*"))
                isWithinMultilineComment = true;

            if (line.IndexOf("*/") > line.IndexOf("/*"))
                isWithinMultilineComment = false;

            return isWithinMultilineComment;
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
