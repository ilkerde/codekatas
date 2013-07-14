using System;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	[TestFixture]
	public class When_SourceCode_Contains_Two_Code_Lines_And_One_Comment_Line
	{
		[Test]
		public void Should_Return_Two_Lines()
		{
			string sourceCode = @"
using System;
// this is a comment
using System.Linq;";

			int linesOfCode = SourceCodeAnalysis.CountLinesOfCode(sourceCode);
			Assert.That(linesOfCode, Is.EqualTo(2));
		}
	}
}