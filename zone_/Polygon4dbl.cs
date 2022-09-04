using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_
{
	/// <summary>
	/// the stokes area is positive.
	/// if it's negative, then the clozed surface is the outside, which is still a surface, but not a zone. As we are under the namespace of zone, hence this polygon here is always positive.
	/// </summary>
	///
	[Obsolete(nameof(zone_.Polygon4dbl_onPositiveCycle))]
	public class Polygon4dbl
		:
		
		coil_.gon_.poly.be_.cycle.vow.Ee4dbl
		,
		Polygon4dblI
	{
		static public IEnumerable<Point4dblI> _MakePositiveTurn(
			IEnumerable<Point4dblI> points
		)
		{
			var surrounded = nilnul.geometry.planar.coil_.gon._SurroundedX.Stokes(points);
			if (surrounded < 0)
			{
				return points.Reverse();
			}
			return points;

		}

		public Polygon4dbl(IEnumerable<Point4dblI> val) : base(_MakePositiveTurn(val))
		{ }


		public IEnumerable<Point4dblI> vertexes => this.ee.vertexes;

		public IEnumerable<Grad4dbl_byPointsI> grads {
			get {
				return cloze_.gon._Grads4dblX._Grads_ofStarted(vertexes);
			}
		}
	}
}
