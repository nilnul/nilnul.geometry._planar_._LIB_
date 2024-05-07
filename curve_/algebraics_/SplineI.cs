using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraics_
{
	/// <summary>
	/// thru many points.
	/// </summary>
	/// vs:
	///		<see cref="algebraic_.Bezier4dbl"/>
	///			we can have high ordered (eg: 12 ordered to pass thru 13 points) bezier, but in this case:
	///				1) each point's move affects the whole curve; in other words, it's not local;
	///				2) the curve doesnot pass thru specified points;
	public interface ISpline
		:
		curve_.algebraic.IPiecewise
		//,
		//curve_.IPiecewise
	{
	}
}
