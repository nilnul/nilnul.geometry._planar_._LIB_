using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// 
	/// the subset of the whole plane/space.
	/// it can be:
	///		1) a point
	///		2) a track/trail/curve, which is a function of point over a parameer t, where t is usually time, changing along the real axis.
	///			note: that a trail can be contained in a 1d line. or it can be a 2d curve.
	///		3) a facet, there is area.
	/// </summary>
	/// <remarks>
	/// alias:
	///		minifould
	/// </remarks>
	public interface ISub:point.ISet
	{
	}
}
