using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.trail_.spanned_
{
	/// <summary>
	/// the start point is included
	/// </summary>
	public interface IOpen :
		IOpenAtStart
		,
		IOpenAtEnd
	{
	}
}
