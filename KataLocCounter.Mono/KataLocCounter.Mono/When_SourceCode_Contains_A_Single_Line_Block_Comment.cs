using System;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	[TestFixture]
	public class When_SourceCode_Contains_A_Single_Line_Block_Comment
	{
		[Test]
		public void Should_Return_Zero_Lines()
		{
			string sourceCode = "/* using System; */";
			int linesOfCode = SourceCodeAnalysis.CountLinesOfCode(sourceCode);
			Assert.That(linesOfCode, Is.EqualTo(0));
		}
	}
}