using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace nilnul.lang._sentence.clause.scule
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

			var r= textInfo.ToTitleCase("ab cd");

			Assert.IsTrue(
				r=="Ab Cd"
			);
		}
	}
}
