using System;
using System.Linq;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	public class SourceCodeAnalysis
	{
		private class BlockCommentState
		{
			public bool IsActive { get; set; } 
			public bool IsNotActive { get { return !IsActive; } }
		}

		public static int CountLinesOfCode(string sourceCode)
		{
			var blockCommentState = new BlockCommentState();
			var sourceCodeLines = sourceCode.SplitLinesToArray();
			return sourceCodeLines.Count(x => IsCodeLine(x, blockCommentState));
		}

		private static bool IsCodeLine(string sourceCodeLine, BlockCommentState blockCommentState) {
			sourceCodeLine = sourceCodeLine.Trim();

			if (sourceCodeLine.StartsWith ("/*")) 
			{
				blockCommentState.IsActive = true;

				return HasBlockCommentTerminator(sourceCodeLine)
					&& IsBlockCommentTerminatedBeforeEOL(sourceCodeLine);
			}

			if (sourceCodeLine.EndsWith ("*/")) {
				blockCommentState.IsActive = false;
				return false;
			}

			return blockCommentState.IsNotActive 
				&& sourceCodeLine.ContainsText() 
				&& IsNotSingleLineComment(sourceCodeLine);
		}

		private static bool IsNotSingleLineComment(string sourceCodeLine)
		{
			return !sourceCodeLine.StartsWith("//");
		}

		private static bool IsBlockCommentTerminatedBeforeEOL(string sourceCodeLine)
		{
			return sourceCodeLine.IndexOf ("*/") < sourceCodeLine.Length - 2;
		}

		private static bool HasBlockCommentTerminator(string sourceCodeLine)
		{
			return sourceCodeLine.Contains("*/");
		}

	}
}