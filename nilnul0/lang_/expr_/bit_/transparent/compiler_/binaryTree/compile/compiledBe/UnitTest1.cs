using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;



namespace nilnul.lang._test.lang_.bitExpr.compiler_.binaryTree.compile.compiledBe
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void compiledBeNotTauto()
				{

			test("(a<=b&a<=!b)<=!a");
			test("(a<=b)&!b <= b");
			test("(a <= b) & (a <= !b) <= !a ");

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

					nilnul.bit.expr.vow_.NotTauto.Singleton.vow(expr);


				}


			}







		}
	}
}
