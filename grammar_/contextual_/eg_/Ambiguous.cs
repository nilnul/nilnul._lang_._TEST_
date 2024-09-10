using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.grammar_.contextual_.eg_
{
	/// <summary>
	/// eg:
	///		S::a
	///		S::SS
	///		aSa::b
	///	where SSS can be SS => (SS)S, or SS => S(SS), resulting ambiguity;
	/// </summary>
	/// <remarks>
	/// this is in fact a set of nonempty strings, each of which consisting of a or b. or the omega set on alphabet {a,b}, except the empty string.
	/// </remarks>
	internal class Ambiguous
	{
	}
}
