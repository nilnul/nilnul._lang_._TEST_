using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.grammar_.contextual_.contextless_.eg_
{
	/// <summary>
	/// eg:
	///		S::aS
	///		S::bS
	///		S::a
	///		S::b
	/// </summary>
	/// <remarks>
	/// this generates same set as <see cref="contextual_.eg_.Ambiguous"/>. But this one is not ambiguous.
	/// this grammar is also regular
	/// </remarks>
	internal class NonAmbiguous
	{
	}
}
