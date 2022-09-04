using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.surface_
{


	/// <summary>
	/// the inner or outer area of the polygon.
	/// for inner only, see <see cref="zone_.IPolygon"/>
	/// </summary>

	public class Polygon4dbl
		:

		planar.coil_.gon_.poly.be_.cycle.vow.Ee4dbl
		,
		sub_.directed_.connected_._polygon_.Vertexes4dblI, IPolygon
	{
		public Polygon4dbl(IEnumerable<Point4dblI> val) : base(val)
		{
		}

		public IEnumerable<Point4dblI> vertexes => this.ee.vertexes;
	}
}
