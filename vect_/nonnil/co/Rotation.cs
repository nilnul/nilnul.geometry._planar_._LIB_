using nilnul.geometry.planar.grad_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.vect_.nonnil.co
{
	/// <summary>
	/// can be both positive or negative, or nil
	///		if we take the first vector as a lead, and the second vector as a point based on the sum of the two vector.
	/// </summary>
	static public  class _RotationX
	{
		static public Rotation1 Rotation(planar.vect_.Nonnil x, planar.vect_.Nonnil y) {
			return  planar.vect_.nonnil._DirectionX.ToLtTau(x) - planar.vect_.nonnil._DirectionX.ToLtTau(y);
			
		}

		static public planar.rotation_.Direction Direction(planar.vect_.Nonnil x, planar.vect_.Nonnil y) {
			return planar.rotation_.Direction.Create_byCannonize (Rotation(x,y) );
			
		}

		static public double Rotation(planar.vect_.NonnilDblI x, planar.vect_.NonnilDblI y) {
			return
				planar.vect_.nonnil._DirectionX.NonnegLtTau(y)
				- planar.vect_.nonnil._DirectionX.NonnegLtTau(x);
		}
		static public double Rotation(planar.vect_.NonnilDbl x, planar.vect_.NonnilDbl y) {
			return
				planar.vect_.nonnil._DirectionX.NonnegLtTau(y)
				- planar.vect_.nonnil._DirectionX.NonnegLtTau(x);
		}

		public static double _Rotation_assumeNonnils(point_.Polar4dbl point, point_.Polar4dbl point1)
		{
			return
				point1.azimuth - point.azimuth;

			;
		}

		public static double Rotation(VectorDbl vectorDbl1, VectorDbl vectorDbl2)
		{
			return Rotation(
					new planar.vect_.NonnilDbl(vectorDbl1)
					,
					new planar.vect_.NonnilDbl(vectorDbl2)

			);
		}

		static public double Direction(planar.vect_.NonnilDblI x, planar.vect_.NonnilDblI y) {
			return planar.rotation_.Direction.Create_byCannonize(
				Rotation(x,y)
			);
		}

		public static double Direction(vect_.NonnilDblI start, VectorDbl stop)
		{
			return  planar.vect_.nonnil._DirectionX._Ge0LtTau_ofAssumeNonnil(stop) - planar.vect_.nonnil._DirectionX._Ge0LtTau_ofAssumeNonnil(start);

		}


		public static double Direction(Vector4dblI vectorD1, Vector4dblI vectorD2)
		{
			return Direction( new vect_.NonnilDbl(vectorD1), new vect_.NonnilDbl(vectorD2));
		}

		static public float Rotation(PointF start, PointF end)
		{
			return  planar.vect_.nonnil._DirectionX.ToLtTau(end) - planar.vect_.nonnil._DirectionX.ToLtTau(start);
		}


	}
}
