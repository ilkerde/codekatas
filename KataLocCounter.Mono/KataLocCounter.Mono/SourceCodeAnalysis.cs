using System;
using System.Linq;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	public class SourceCodeAnalysis
	{
		static bool _isInBlockComment = false;

		public static int CountLinesOfCode(string sourceCode)
		{
			var sourceCodeLines = sourceCode.SplitLinesToArray();
			return sourceCodeLines.Count(IsCodeLine);
		}

		private static bool IsCodeLine(string sourceCodeLine) {
			sourceCodeLine = sourceCodeLine.Trim();

			if (sourceCodeLine.StartsWith ("/*")) 
			{
				_isInBlockComment = true;

				if (sourceCodeLine.Contains ("*/"))
					return sourceCodeLine.IndexOf ("*/") < sourceCodeLine.Length - 2;

				return false;
			}

			if (sourceCodeLine.EndsWith ("*/")) {
				_isInBlockComment = false;
				return false;
			}

			if (_isInBlockComment)
				return false;

			return !String.IsNullOrEmpty(sourceCodeLine) 
				&& !sourceCodeLine.StartsWith("//");
		}
	}
}