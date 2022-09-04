using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.geometry.planar.coil_.gon_.poly.be_;
using nilnul.geometry.planar.point.str_;
//using nilnul.geometry.planar.point.str_.started;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
namespace nilnul.geometry.planar.coil_.gon.be_.poly_
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
		:
		coil_.gon.Be4dblI
	{
		
	
	

		public bool be(Gon4dblI obj)
		{
			var vertexes = obj.vertexes;
			if (vertexes.Count() <=2)
			{
				return false;
			}
			return _Cycle4dblX._Be_assumePoly(
				 vertexes
			);


		}


		static public Cycle4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cycle4dbl>.Instance;
			}
		}

		public bool be(IEnumerable<planar.Point4dblI> c)
		{
			return be(
				new coil_.Gon4dbl(c)
			);
			//throw new NotImplementedException();
		}
	}
}
