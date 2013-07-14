using System;
using System.Linq;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	public class SourceCodeAnalysis
	{
		public static int CountLinesOfCode(string sourceCode)
		{
			if (String.IsNullOrEmpty(sourceCode))
				return 0;

			sourceCode = sourceCode.Trim();

			if (sourceCode.StartsWith("//"))
				return 0;

			return 1;
		}
	}
}