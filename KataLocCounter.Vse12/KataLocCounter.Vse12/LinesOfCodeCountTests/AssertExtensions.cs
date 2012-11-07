using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataLocCounter.Vse12
    .LinesOfCodeCountTests
{
    public static class AssertExtensions
    {
        public static void ShouldBe<T>(this T actual, T expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}
