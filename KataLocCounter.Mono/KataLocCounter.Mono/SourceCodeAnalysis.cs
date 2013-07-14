using System;
using System.Linq;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	public class SourceCodeAnalysis
	{
		public static int CountLinesOfCode(string sourceCode)
		{
			var lines = 0;
			var sourceCodeLines = sourceCode.Split(
				new [] { Environment.NewLine }, 
				StringSplitOptions.RemoveEmptyEntries);

			foreach (var sourceCodeLine in sourceCodeLines) {
				lines += CountCodeLine (sourceCodeLine);
			}

			return lines;
		}

		private static int CountCodeLine(string sourceCodeLine) {
			if (String.IsNullOrEmpty(sourceCodeLine))
				return 0;

			sourceCodeLine = sourceCodeLine.Trim();

			if (sourceCodeLine.StartsWith("//"))
				return 0;

			return 1;
		}
	}
}