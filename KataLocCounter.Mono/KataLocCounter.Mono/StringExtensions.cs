using System;
using System.Linq;
using NUnit.Framework;

namespace KataLocCounter.Mono
{
	public static class StringExtensions 
	{
		public static string[] SplitLinesToArray(this string source)
		{
			return source.Split(
				new [] { Environment.NewLine }, 
				StringSplitOptions.RemoveEmptyEntries);
		}

		public static bool ContainsText(this string source)
		{
			return !String.IsNullOrEmpty (source);
		}
	}
}