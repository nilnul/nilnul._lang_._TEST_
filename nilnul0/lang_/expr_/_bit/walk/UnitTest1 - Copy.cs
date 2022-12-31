using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using nilnul.lang.eg.logic;

namespace nilnul.lang._test.lex.eg.logic.duoChain
{
	[TestClass]
	public class Build_testClasss
	{
		[TestMethod]
		public void Build()
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

			test("((a))");

			test("a|a|a");

			test("a|a&c |b");

			test("a<=a ~c |b");
			test("a<=a <=b~c~d |b");

			test("< ");


			test(" < ");

			test(" <= ");
			test(" < = ");

			test(" < =");
			test("  =");


			test("a|b&!10()<=aaa");



			test("!!!a&!(a)|(!!b|c)&d|e&!f");




		}
		[TestMethod]

		public void Build_one()
		{

			test("(a<=b&a<=!b)<=!a");

		}


		

		public void test(string x)
		{

			//var naming = nilnul.var.set.NamingContext_ofVarI.Instance;

			var naming = nilnul.obj.var.set.NamingContext.Instance;
			//naming.clean();

			var lex = new nilnul.lang_.bitExpr.compiler_._binaryTree_.Lex();

			Debug.WriteLine("----------------------------------------------");
			Debug.WriteLine(x);


			lex.run(x);
			Debug.WriteLine(lex.parsedResult());

			nilnul.lang_.bitExpr.compiler_._binaryTree_._parse.Tokens2WellCombined.ParseResult walked = null;


			if (lex.errorMsg == "")
			{
				var duoChainParser = new nilnul.lang_.bitExpr.compiler_._binaryTree_._parse.Tokens2WellCombined();

				walked = duoChainParser.parse(lex.tokens);



				Debug.WriteLine(walked);


				if (walked.noError)
				{

					var build = new nilnul.lang_.bitExpr.compiler_._binaryTree_.Parse();

					var expr = build.parse(
						walked.getFormula()
					);

					Debug.WriteLine(expr);


				}


			}







		}

	}
}
