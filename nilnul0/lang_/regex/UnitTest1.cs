using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace nilnul._lang_._TEST_.nilnul0.lang_.regex
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var txt = "nilnul.0_globe_0.git";

			//var regex = @"(\A|\W|\z){2}";
			var regex = @"\A\W|\W\W|\W\z";

			var matches = Regex.Matches(txt, regex);

			matches = Regex.Matches(txt, @"(\A){2}");
			matches = Regex.Matches(txt, @"(\W){2}");
			matches = Regex.Matches(txt, @"(\z){2}");



		}


	}
}
