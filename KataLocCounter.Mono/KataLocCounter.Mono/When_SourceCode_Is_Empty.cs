using System;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	[TestFixture]
	public class When_SourceCode_Is_Empty
	{
		[Test]
		public void Should_Return_Zero_Lines()
		{
			string sourceCode = String.Empty;
			int linesOfCode = SourceCodeAnalysis.CountLinesOfCode(sourceCode);
			Assert.That(linesOfCode, Is.EqualTo(0));
		}
	}
}