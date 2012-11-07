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
            if (string.IsNullOrEmpty(sourceCode))
                return 0;

            var lines = sourceCode.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            return lines
                .Where(line => !line.StartsWith("//"))
                .Where(line => !String.IsNullOrWhiteSpace(line))
                .Count();
        }
    }
}
