using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_
{
	public class Polar4dbl_radius1st
		:
		
		planar.Vect4dblI
	{
		private planar.point_.Polar4dbl_radius1st _point;

		public Point4dblI point
		{
			get { return _point; }
		}
		public planar.point_.Polar4dbl_radius1st polarPoint {
			get {
				return _point;
			}
		}


		public Polar4dbl_radius1st(
			planar.point_.Polar4dbl_radius1st polar4Dbl
		)
		{
			_point = polar4Dbl;
		}

		public Polar4dbl_radius1st( double radius, double rotation)
			:this(
				 new point_.Polar4dbl_radius1st(
					 radius
					 ,
					 rotation
				)
		)
		{
		}

		public Polar4dbl_radius1st(
			num.real_.PositiveDblI fromPointToTapeTip
			,
			double gradDirection
		):this(
			fromPointToTapeTip.dblen
			,
			gradDirection
		)
		{
		}

		static public Polar4dbl_radius1st Of(planar.Point4dbl vectorDbl) {
			return new Polar4dbl_radius1st(
				planar.point_.Polar4dbl_radius1st.Of(vectorDbl)
			);
		}

		static public Polar4dbl_radius1st Of(planar.Point4dblI vectorDbl) {
			return new Polar4dbl_radius1st(
				planar.point_.Polar4dbl_radius1st.Of(vectorDbl)
			);
		}

		static public Polar4dbl_radius1st Of(Vector4dblI vectorDbl) {
			return Of(
				vectorDbl.point
			);
		}

		static public Polar4dbl_radius1st Of(VectorDbl vectorDbl) {
			return Of(
				vectorDbl.boxed
			);
		}

		public static Polar4dbl_radius1st Of(NonnilDbl nonnil)
		{
			return Of((Vector4dblI)nonnil);
		}

		public static Polar4dbl_radius1st Of(Vect4dblI vector)
		{
			return Of(vector.point);
		}

		static public Vect4dbl operator -(Vect4dblI v, Polar4dbl_radius1st b) {
			return vect.op_.binary_._MinusX.Op(v, b);
		}
		static public Vect4dbl operator -(Point4dblI v, Polar4dbl_radius1st b) {
			return vect.op_.binary_._MinusX.Op(v, b);
		}

	}
}
