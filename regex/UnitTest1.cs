using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace nilnul.lang._test.regex
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void AtVar()
		{



			string strRT =	@"ReplaceableTextures\PassiveButtons\PASBTNStatUp.blp";
			var atVarStr = @strRT;

			//Regex rgxTar = new Regex(@strRT); //这里就报错了，@怎		么加，我觉得还是另行处理？
			//Regex rgxTar = new Regex(atVarStr); //这里就报错了，@怎		么加，我觉得还是另行处理？

			//你这句相当于
			//Regex rgxTar1 = new Regex(@"ReplaceableTextures\PassiveButtons\PASBTNStatUp.blp");

			//正则表达式没有这么写的，没有\p的。

			//可能你需要写成 

			Regex rgxTar3 = new Regex(strRT.Replace("\\", "\\\\"));







		}
	}
}
