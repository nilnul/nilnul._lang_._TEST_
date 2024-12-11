using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.lang.method_.closure
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			///x.com/mjovanovictech/status/1866494093464871323
			static Func<int,int> GetIncrementFunc() {
				var incrementBy = 0;
				Func<int, int> increment = delegate (int inputVariable) {
					incrementBy = incrementBy + 1;
					return inputVariable + incrementBy;
				};
				return increment;

			}

			var increment = GetIncrementFunc();
			var t = increment(1);
			Debug.WriteLine(t);
			Assert.AreEqual(
				t, 2

			);

			t = increment(2);
			Debug.WriteLine(t);
			Assert.AreEqual(
				t, 4
			);


			t = increment(3);
			Debug.WriteLine(t);
			Assert.AreEqual(
				t, 6
			);

			t = increment(1);
			Debug.WriteLine(t);
			Assert.AreEqual(
				t, 5
			);


		}
	}
}
