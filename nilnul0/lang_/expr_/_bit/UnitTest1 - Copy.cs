using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using nilnul.lang.eg.logic;

namespace nilnul.lang._test.lex.eg.logic
{
	[TestClass]
	public class UnitTest11
	{
		Lex1	lex = new nilnul.lang.eg.logic.Lex1();

		[TestMethod]
		public void Lex_logic1()
		{
			test("");
			test( "    ");
			test("	   ");

			test("a|b&!1");

		

			test( "a|b&!10()<=aaa");

		



			test("  1  ");


			test( "  111  ");
			test(

			 "  1311  ");

			test( "  1(xy1<1  ");

			test( "  1(xy11 < ");
			

			test( "<");
			test( " <");


			test( "< ");
		

			test(" < ");

			test(" <= ");
			test(" < = ");

			test(" < =");
			test("  =");

		}

		public void test(string x) {
			Debug.WriteLine("----------------------------------------------");
			Debug.WriteLine(x);
			lex.run(x);
			Debug.WriteLine(lex.parsedResult());

		}

		
	}
}
