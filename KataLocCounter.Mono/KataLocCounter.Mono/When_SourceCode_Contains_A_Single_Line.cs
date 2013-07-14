using System;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	[TestFixture]
	public class When_SourceCode_Contains_A_Single_Line
	{
		[Test]
		public void Should_Return_One_Line()
		{
			string sourceCode = "using System;";
			int linesOfCode = SourceCodeAnalysis.CountLinesOfCode(sourceCode);
			Assert.That(linesOfCode, Is.EqualTo(1));
		}
	}
}