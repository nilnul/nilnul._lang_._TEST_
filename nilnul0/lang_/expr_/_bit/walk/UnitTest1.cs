using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using nilnul.lang.eg.logic;

namespace nilnul.lang._test.lex.eg.logic.duoChain
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Walk_test()
		{


			test("");
			test("    ");
			test("	   ");

			test("a|b&!1");

			test("  1  ");


			test("  111  ");
			test(

			 "  1311  ");

			test("  1(xy1<1  ");

			test("  1(xy11 < ");


			test("<");
			test(" <");


			test("< ");


			test(" < ");

			test(" <= ");
			test(" < = ");

			test(" < =");
			test("  =");


			test("a|b&!10()<=aaa");



			test("!!!a&!(a)|(!!b|c)&d|e&!f");




		}


		public void test(string x)
		{

			var lex = new nilnul.lang.eg.logic.Lex1();

			Debug.WriteLine("----------------------------------------------");
			Debug.WriteLine(x);


			lex.run(x);
			Debug.WriteLine(lex.parsedResult());

			Walk.ParseResult walked=null;
			if (lex.errorMsg == "")
			{
				var duoChainParser = new nilnul.lang.eg.logic.Walk();

				 walked = duoChainParser.parse(lex.tokens);



				Debug.WriteLine(walked);


			}

			if (walked.noError)
			{
				var build = new nilnul.lang.eg.logic.OpPriorityConsidered();
				build.parse(walked.getFormula());


			}






		}

	}
}
