using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.geometry.planar.point.str_;
//using nilnul.geometry.planar.point.str_.started;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
namespace nilnul.geometry.planar.coil_.gon_.poly.be_
{
	/// <summary>
	/// no edges crossing each other; crossing means the intersected point is in the middle of some edge, that means, adjacency (share same endpoint), is not crossing.
	/// </summary>
	/// to be cloze:
	///		it must be 3 or more points.
	///			as 0point, it's not a <see cref="planar.IDrawable"/>
	///			as 1point, it's not a <see cref="planar.ICurve"/>
	///			as 2 point, it's not a <see cref="planar.coil_.ISimple"/> in that the two edges are incident.
	public class Cycle4dbl
		:nilnul.geometry.planar.coil_.gon_.poly.Be4dblI
	{
		
		public bool be(Poly4dbl obj)
		{
			return _Cycle4dblX._Be_assumePoly(obj.vertexes);
		}
	
	
		public  bool be(IEnumerable<Point4dblI> points)
		{
			return be(new Poly4dbl( points) );
		}

	}
}
