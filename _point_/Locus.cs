using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._point_
{
	/// <summary>
	/// imagine a (2d space +1d time) universe, and visualize it in a 3d space with z as the time,
	/// , then a point is a line parallel with z, and intersect with xy plane at the given point.
	/// , So a point is still continuous in that the line is continuous, and for x, it's a constant function on (t->x) plane, and for y, it's a constant, hence continous function on (t->y) plane.
	/// </summary>
	/// <remarks>
	/// of course, other t-> C|(x,y) function plot can also intersect with (x,y) at a point such as:
	///		for t le 0, it's C, otherwise C+b. In this case, the line isnot continouse.
	///	,So it depends on our willingness to find one that is continouse;
	/// </remarks>
	public class Locus : _troll_.Fn4dblI
	{
		private C _point;

		public C point
		{
			get { return _point; }
			set { _point = value; }
		}

		public C locus(double time)
		{
			return _point;
		}
	}
}
