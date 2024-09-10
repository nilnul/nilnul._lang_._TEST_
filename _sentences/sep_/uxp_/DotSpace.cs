using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._sentences.sep_.uxp_
{
	/// <summary>
	/// ". " as the separator, where the ' ' is necessary to differ from '.' in 123.456, where '.' is not a sentences separator, but a decimal point.
	/// But when printed, the space in ". " is invisiable; hence if it's not larger enough than letter spacing, one might mistake it as "."
	/// </summary>
	internal class DotSpace
	{
	}
}
