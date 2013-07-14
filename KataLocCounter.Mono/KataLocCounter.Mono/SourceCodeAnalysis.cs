using System;
using System.Linq;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	public class SourceCodeAnalysis
	{
		public static int CountLinesOfCode(string sourceCode)
		{
			var sourceCodeLines = sourceCode.SplitLinesToArray();
			return sourceCodeLines.Count(IsCodeLine);
		}

		private static bool IsCodeLine(string sourceCodeLine) {
			sourceCodeLine = sourceCodeLine.Trim();

			return !String.IsNullOrEmpty(sourceCodeLine) 
				&& !sourceCodeLine.StartsWith("//");
		}
	}
}