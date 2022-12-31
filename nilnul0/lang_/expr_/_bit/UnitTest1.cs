using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using nilnul.lang.eg.logic;

namespace nilnul.lang._test.lex.eg.logic
{
	[TestClass]
	public class UnitTest1
	{
		Lex1	lex = new nilnul.lang.eg.logic.Lex1();

		[TestMethod]
		public void Lex_logic()
		{
			var lex = new nilnul.lang.eg.logic.Lex1();

			var input = "a|b&!1";
			lex.run(input);
			Debug.WriteLine(lex.input);
			Debug.WriteLine(lex.result());

			Debug.WriteLine("");

			//var lex = new nilnul.lang.eg.logic.Lex();

			lex.input = "a|b&!10()<=aaa";
			lex.run();
			Debug.WriteLine(lex.input);
			Debug.WriteLine(lex.result());
			Debug.WriteLine("");

			lex.input = "";
			lex.run();
			Debug.WriteLine(lex.input);
			Debug.WriteLine(lex.result());
			Debug.WriteLine("");

			lex.input = "    ";
			lex.run();
			Debug.WriteLine(lex.input);
			Debug.WriteLine(lex.result());
			Debug.WriteLine("");

			lex.input = "    ";
			lex.run();
			output(lex);


			lex.input = "  1  ";
			lex.run();
			output(lex);


			lex.input = "  111  ";
			lex.run();
			output(lex);


			lex.input = "  1311  ";
			lex.run();
			output(lex);

			lex.input = "  1(xy1<1  ";
			lex.run();
			output(lex);

			lex.input = "  1(xy11 < ";
			lex.run();
			output(lex);

			lex.input = "<";
			lex.run();
			output(lex);
			lex.input = " <";
			lex.run();
			output(lex);
			lex.input = "< ";
			lex.run();
			output(lex);

			test(" < ");

			test(" <= ");
			test(" < = ");

			test(" < =");
			test("  =");

		}

		public void test(string x) {

			lex.input = x;
			lex.run();
			output(lex);

		}

		public void output(Lex lex) {
			Debug.WriteLine("----------------------------------------------");

			Debug.WriteLine(lex.input);
			Debug.WriteLine(lex.result());
			Debug.WriteLine("");

		}
	}
}
