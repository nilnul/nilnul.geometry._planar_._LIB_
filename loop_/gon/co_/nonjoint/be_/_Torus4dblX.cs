using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.loop_.gon.co_.nonjoint.be_
{
	static public class _Torus4dblX
	{
		static public bool _Be_assumeNonjoint(
			cycle_.Polygon4dblI outer
			,
			cycle_.Polygon4dblI inner
		)
		{
			return torus_._Seige4dblX._Be_assumeNonjoint(
				outer
				,
				inner
			)
			||
			torus_._Seige4dblX._Be_assumeNonjoint(
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