using NUnit.Framework;
using System;

namespace KataStringCalculator.XS
{

	public static class ShouldExtensions 
	{
		public static void ShouldEqual<T> (this T t, T o)
		{
			Assert.AreEqual (o, t);
		}
	}
}
