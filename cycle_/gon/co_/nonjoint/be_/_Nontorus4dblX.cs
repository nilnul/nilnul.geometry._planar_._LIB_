using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.co_.nonjoint.be_
{
	[Obsolete(nameof(lop_.gon.co_.nonjoint.be_))]
	static public class _Nontorus4dblX
	{
		static public bool _Be_assumeNonjoint(
			cycle_.Polygon4dblI outer
			,
			cycle_.Polygon4dblI inner
		)
		{
			return cycle_.gon.vsPoint.sign_._PointInsidePolygonX.IsInsidePolygon(
					inner.vertexes.First()
					,
					outer
				) == false

				&&
				cycle_.gon.vsPoint.sign_._PointInsidePolygonX.IsInsidePolygon(
					outer.vertexes.First()
					,
					inner
				) == false
			;
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