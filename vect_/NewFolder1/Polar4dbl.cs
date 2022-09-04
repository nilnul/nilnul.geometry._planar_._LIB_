using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_
{
	/// <summary>
	/// rotation first, radius second.
	/// </summary>
	[Obsolete(nameof(Polar4dbl_radius1st))]
	public class Polar4dbl
		:
		planar.Vector4dblI
		,
		planar.Vect4dblI
	{
		private planar.point_.Polar4dbl _point;

		public Point4dbl point
		{
			get { return _point.toStraight(); }
		}
		public planar.point_.Polar4dbl polarPoint {
			get {
				return _point;
			}
		}

		Point4dblI Vect4dblI.point => _point;

		public Polar4dbl(
			planar.point_.Polar4dbl polar4Dbl
		)
		{
			_point = polar4Dbl;
		}

		public Polar4dbl(double rotation, double radius)
			:this(
				 new point_.Polar4dbl(
					 rotation,radius
				)
		)
		{
		}

		public Polar4dbl(double gradDirection, num.real_.PositiveDblI fromPointToTapeTip):this(gradDirection, fromPointToTapeTip.dblen)
		{
		}

		static public Polar4dbl Of(planar.Point4dbl vectorDbl) {
			return new Polar4dbl(
				planar.point_.Polar4dbl.Of(vectorDbl)
			);
		}

		static public Polar4dbl Of(planar.Point4dblI vectorDbl) {
			return new Polar4dbl(
				planar.point_.Polar4dbl.Of(vectorDbl)
			);
		}

		static public Polar4dbl Of(Vector4dblI vectorDbl) {
			return Of(
				vectorDbl.point
			);
		}

		static public Polar4dbl Of(VectorDbl vectorDbl) {
			return Of(
				vectorDbl.boxed
			);
		}

		public static Polar4dbl Of(NonnilDbl nonnil)
		{
			return Of((Vector4dblI)nonnil);
		}

		public static Polar4dbl Of(Vect4dblI vector)
		{
			return Of(vector.point);
		}
	}
}
