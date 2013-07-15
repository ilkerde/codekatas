using System;
using System.Linq;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	public class SourceCodeAnalysis
	{
		public static int CountLinesOfCode(string sourceCode)
		{
			var isInBlockComment = false;
			var sourceCodeLines = sourceCode.SplitLinesToArray();
			return sourceCodeLines.Count(x => IsCodeLine(x, ref isInBlockComment));
		}

		private static bool IsCodeLine(string sourceCodeLine, ref bool isInBlockComment) {
			sourceCodeLine = sourceCodeLine.Trim();

			if (sourceCodeLine.StartsWith ("/*")) 
			{
				isInBlockComment = true;

				if (sourceCodeLine.Contains ("*/"))
					return sourceCodeLine.IndexOf ("*/") < sourceCodeLine.Length - 2;

				return false;
			}

			if (sourceCodeLine.EndsWith ("*/")) {
				isInBlockComment = false;
				return false;
			}

			if (isInBlockComment)
				return false;

			return !String.IsNullOrEmpty(sourceCodeLine) 
				&& !sourceCodeLine.StartsWith("//");
		}
	}
}