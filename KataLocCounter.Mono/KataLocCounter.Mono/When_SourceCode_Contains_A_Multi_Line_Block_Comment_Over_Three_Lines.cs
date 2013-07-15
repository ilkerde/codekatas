using System;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	[TestFixture]
	public class When_SourceCode_Contains_A_Multi_Line_Block_Comment_Over_Three_Lines
	{
		[Test]
		public void Should_Return_Zero_Lines()
		{
			string sourceCode = @"
/* using System;
It's the system.
This is a trivial using */";
			int linesOfCode = SourceCodeAnalysis.CountLinesOfCode(sourceCode);
			Assert.That(linesOfCode, Is.EqualTo(0));
		}
	}
}