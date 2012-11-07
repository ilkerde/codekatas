using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLocCounter.Vse12
{
    public static class StringSplittingExtensions
    {
        public static string[] ToLines(this string text)
        {
            return text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        }
    }
}
