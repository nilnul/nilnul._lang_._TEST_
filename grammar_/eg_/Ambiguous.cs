using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.grammar_.unrestricted_.eg_
{
	/// <summary>
	/// eg:
	///		S::aBSc
	///		S::abc
	///		Ba::aB
	///		Bb::bb
	///	; this is contextual lang;
	/// </summary>
	/// <remarks>
	/// this defines: {a^n b^n c^n, where n>=1};
	/// </remarks>
	internal class Ambiguous
	{
	}
}
