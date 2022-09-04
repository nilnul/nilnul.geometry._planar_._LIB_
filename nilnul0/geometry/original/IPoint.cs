using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.original
{
	/// <summary>
	/// the origin is the point. this is the first point in all points. as in later, lower dimension geometry is included in higher dimension geometry
	/// </summary>
	public interface IPoint : nilnul.geometry.dimed.IPoint
		,
		original.ISub
		

	{ }
	
}
