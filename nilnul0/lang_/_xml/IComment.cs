using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_._xml
{
	/// <summary>
	/// 
	/// </summary>
	class IComment
	{
		/*
		the grammar:
			'<!--' ((Char - '-') | ('-' (Char - '-')))* '-->'
		*/
		/*

		the instance:
			<!---a-->
			is valid
		the instance1:
			<!--a--->
			is not.
		Why? it's puzzelling at the first sight. but 
			cuz in grammar, we either use a char that's not '-', or use a pair "-"a or sth alike.
				so repeating that will not end with '-'

		 */
	}
}
