using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;



using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.bit.expr_.plain_.txt.be_.contradictary.ov_.multi
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void compiledBeTauto()
				{

			var txts = new[] { " p <= (p|q|r) "
				,
				"(p<= !p) <= !p"
				,
				"!(q<=q)&p"
				,
				"!(q|!p)<=(p&!p)"
			};

		
			Debug.WriteLine(
				nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(
					txts.Select(x=> nilnul.bit._NameX.Exe( test(x)))
				)
			);

		}




		public bool test(string x)
		{

			//var naming = nilnul.var.set.NamingContext_ofVarI.Instance;

			var naming = nilnul.obj.var.set.NamingContext.Instance;
			//naming.clean();

			var lex = new nilnul.bit.expr_.plain.parse_._treeByParen._idiomize.Lex();

			Debug.WriteLine("----------------------------------------------");
			Debug.WriteLine(x);


			lex.run(x);
			Debug.WriteLine(lex.parsedResult());

			nilnul.bit.expr_.plain.parse_._treeByParen.Idiomize4PlainExpr.ParseResult walked = null;


			if (lex.errorMsg == "")
			{
				var duoChainParser = new nilnul.bit.expr_.plain.parse_._treeByParen.Idiomize4PlainExpr();

				walked = duoChainParser.parse(lex.tokens);



				Debug.WriteLine(walked);

				if (walked.noError)
				{
					var build = new nilnul.bit.expr_.plain.parse_.TreeByParen();

					var expr = build.parse(
						walked.getFormula()
					);

					Debug.WriteLine(expr);

					//nilnul.bit.expr.vow_.Tauto.Singleton.vow(expr);

					 return nilnul.bit.expr_.plain.be_.Contra.Singleton.be(
						expr
					);
				}
			}

			throw new UnexpectedReachException();




		}
	}
}
