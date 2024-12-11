using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading;

namespace nilnul.lang.share
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var lockObject = new object();
			lock (lockObject) {
				Debug.WriteLine("acquired");
			}
		}

		public void TestMethod11()
		{

			var lockObject = new object();
			bool lockTaken = false;

			try
			{
				Monitor.Enter(lockObject, ref lockTaken);
				Debug.WriteLine("acquired");

			}
			finally	{
				if (lockTaken)
				{
					Monitor.Exit(lockObject);
				}
			}
		}

	}
}
