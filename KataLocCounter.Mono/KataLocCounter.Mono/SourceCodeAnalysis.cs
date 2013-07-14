using System;
using System.Linq;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	public class SourceCodeAnalysis
	{
		public static int CountLinesOfCode(string sourceCode)
		{
			var sourceCodeLines = sourceCode.Split(
				new [] { Environment.NewLine }, 
				StringSplitOptions.RemoveEmptyEntries);

			return sourceCodeLines.Count(IsCodeLine);
		}

		private static bool IsCodeLine(string sourceCodeLine) {
			if (String.IsNullOrEmpty(sourceCodeLine))
				return false;

			sourceCodeLine = sourceCodeLine.Trim();

			if (sourceCodeLine.StartsWith("//"))
				return false;

			return true;
		}
	}
}