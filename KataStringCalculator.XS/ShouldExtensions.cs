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

		public static void ShouldThrow<T> (this Action a) where T : Exception 
		{
			Assert.Throws<T> (new TestDelegate (a));
		}
	}
}
