using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.co_.nonjoint.be_
{
	/// <summary>
	/// left is in right or right is in left
	/// </summary>
	/// alias:
	///		riple
	///
	[Obsolete(nameof(lop_.gon.co_.nonjoint.be_._Torus4dblX)+ " where the direction is not specified.")]

	static public class _Torus4dblX
	{
		/// <summary>
		/// left is in right or right is in left
		/// </summary>
		/// <param name="outer"></param>
		/// <param name="inner"></param>
		/// <returns></returns>
		static public bool _Be_assumeNonjoint(
			cycle_.Polygon4dblI outer
			,
			cycle_.Polygon4dblI inner
		)
		{
			return nest_._Seige4dblX._Be_assumeNonjoint(
				outer
				,
				inner
			)
			||
			nest_._Seige4dblX._Be_assumeNonjoint(
				inner
				,
				outer
			);
		}
		public static bool _Be_cyclesAssumeNonjoint(IEnumerable<Grad4dbl_byPointsI> vs, IEnumerable<Grad4dbl_byPointsI> vs1)
		{
			return _Be_assumeNonjoint(
				 cycle_.Polygon4dbl.Of(vs)
				,
				 cycle_.Polygon4dbl.Of(vs1)
			);
		}

		public static bool _Be_cyclesAssumeNonjoint(IEnumerable<Point4dblI> vs, IEnumerable<Point4dblI> vs1)
		{
			return _Be_assumeNonjoint(
				 new cycle_.Polygon4dbl(vs)
				,
				new cycle_.Polygon4dbl(vs1)
			);
		}


		public static bool _Be_assumeNonjoint(zone_.Polygon4dblI component, zone_.Polygon4dblI component1)
		{

			return _Be_assumeNonjoint(
				new cycle_.Polygon4dbl(component.vertexes)
				,
				new cycle_.Polygon4dbl(component1.vertexes)

			);
		}

	}
}