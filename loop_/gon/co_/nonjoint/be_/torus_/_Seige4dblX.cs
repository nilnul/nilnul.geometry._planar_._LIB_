using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.loop_.gon.co_.nonjoint.be_.torus_
{
	/// <summary>
	/// the left seiges the right
	/// </summary>
	static public class _Seige4dblX
	{
		static public bool _Be_assumeNonjoint(
			cycle_.Polygon4dblI outer
			,
			cycle_.Polygon4dblI inner
		)
		{
			return cycle_.gon.vsPoint.sign_._PointInsidePolygon.IsInsidePolygon(
					inner.vertexes.First()
					,
					outer
				) == true

			;
		}
		public static bool _Be_assumeNonjoint(IEnumerable<Grad4dbl_byPointsI> vs, IEnumerable<Grad4dbl_byPointsI> vs1)
		{
			return _Be_assumeNonjoint(
				 cycle_.Polygon4dbl.Of(vs)
				,
				 cycle_.Polygon4dbl.Of(vs1)
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