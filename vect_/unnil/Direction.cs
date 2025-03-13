using nilnul.geometry.planar.rotation_;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil
{


	/// <summary>
	/// [0,Tau)
	/// </summary>
	static public class _DirectionX
	{
		static public float ToLtTau(PointF point)
		{

			var atan = Math.Atan2(point.Y, point.X);
			if (atan < 0)
			{
				atan += (2 * Math.PI);


			}
			return (float)atan;

		}

		static public planar.rotation_.Direction _ofAssumeNonnil(Point1 _nonnil)
		{

			if (_nonnil.x == 0)
			{   //now that the point is not origin, so y must be non nil.
				if (_nonnil.y < 0)
				{
					return new planar.rotation_.Direction(
						nilnul.num.real_.Tau.Singleton.ToReal() / 4 * 3
					);
				}
				return new planar.rotation_.Direction(
						nilnul.num.real_.Tau.Singleton.ToReal() / 4
					);
			}
			var r = nilnul.num.real.op_.unary_.arctg_.BySeries.Singleton.op(
				_nonnil.x / _nonnil.y
			);

			var r2real = r.ToReal();

			if (_nonnil.x > 0)
			{
				if (r2real < 0)
				{
					return new planar. rotation_.Direction(nilnul.num.real_.Tau.Singleton.ToReal() + r);
				}
				return new planar. rotation_.Direction(r);
			}

			//if (_nonnil.x <0)
			return new planar. rotation_.Direction(nilnul.num.real_.TauX.Half+r);

			//if (r2real < 0)
			//{
			//	return new rotation_.Dir(nilnul.num.real_.TauX.Half + r);
			//}
			//return new rotation_.Dir(nilnul.num.real_.TauX.Half+r);


			///the norm is computed with minimum rounding as M * sqrt(1 + m / M) 
			///
			///according to https://msdn.microsoft.com/en-us/library/vstudio/system.math.atan2(v=vs.100).aspx, the returned values of atan2 is in (-pi, pi]. Note the discrepancy there between the summary and detail.
			///



		}


		public  static Direction ToLtTau(NonnilI vector)
		{
			return _ofAssumeNonnil(vector.point);
		}

		public static double NonnegLtTau(NonnilDblI x)
		{
			return _Ge0LtTau_ofAssumeNonnil(x.vectoree.ee);
		}


		static public double _GtNegPiLePi__ofAssumeNonnil(Point4dblI p)
		{

			

			///the norm is computed with minimum rounding as M * sqrt(1 + m / M) 
			///
			///according to https://msdn.microsoft.com/en-us/library/vstudio/system.math.atan2(v=vs.100).aspx, the returned values of atan2 is in (-pi, pi]. Note the discrepancy there between the summary and detail.
			///
			return Math.Atan2(p.y, p.x);


		}
		static public double _GtNegPiLePi__ofAssumeNonnil(Point4dbl p)
		{

			

			///the norm is computed with minimum rounding as M * sqrt(1 + m / M) 
			///
			///according to https://msdn.microsoft.com/en-us/library/vstudio/system.math.atan2(v=vs.100).aspx, the returned values of atan2 is in (-pi, pi]. Note the discrepancy there between the summary and detail.
			///
			return Math.Atan2(p.y, p.x);


		}


		public static double _GtNegPiLePi__ofAssumeNonnil(Vect4dbl vect4dbl)
		{
			return _GtNegPiLePi__ofAssumeNonnil(vect4dbl.point);
		}


		static public double Direction_ge0LtTau(double x, double y)
		{
			if (x == 0 && y == 0)
			{
				throw new Exception();

			}

			///the norm is computed with minimum rounding as M * sqrt(1 + m / M) 
			///
			///according to https://msdn.microsoft.com/en-us/library/vstudio/system.math.atan2(v=vs.100).aspx, the returned values of atan2 is in (-pi, pi]. Note the discrepancy there between the summary and detail.
			///
			var atan2 = Math.Atan2(y, x);


			return atan2 >= 0 ? atan2 : (-atan2 + 2*Math.PI);



		}

		
		static public double _Ge0LtTau_ofAssumeNonnil(Point4dbl p)
		{

			if (p.x == 0 && p.y == 0)
			{
				throw new Exception();

			}

			///the norm is computed with minimum rounding as M * sqrt(1 + m / M) 
			///
			///according to https://msdn.microsoft.com/en-us/library/vstudio/system.math.atan2(v=vs.100).aspx, the returned values of atan2 is in (-pi, pi]. Note the discrepancy there between the summary and detail.
			///
			var atan2 = Math.Atan2(p.y, p.x);

			/*  An angle, θ, measured in radians, such that -π≤θ≤π, and tan(θ) = y / x, where
		//     (x, y) is a point in the Cartesian plane. Observe the following:
				For (x, y) in     quadrant 1, 0 < θ < π/2.
				For (x, y) in quadrant 2, π/2 < θ≤π.

			For (x, y) in quadrant    3, -π < θ < -π/2.

			For (x, y) in quadrant 4, -π/2 < θ < 0.


			For points on the boundaries
		//     of the quadrants, the return value is the following:
				If y is 0 and x is not negative,
		//     θ = 0.
				If y is 0 and x is negative, θ = π.
				If y is positive and x is 0, θ = π/2.
				If     y is negative and x is 0, θ = -π/2.


				If y is 0 and x is 0, θ = 0. If x or y is
		//     System.Double.NaN, or if x and y are either System.Double.PositiveInfinity or
		//     System.Double.NegativeInfinity, the method returns System.Double.NaN.*/

			return atan2 >= 0 ? atan2 : atan2 + 2*Math.PI;

		}

		static public double _Ge0LtTau_ofAssumeNonnil(Vector4dblI p)
		{
			return _Ge0LtTau_ofAssumeNonnil(p.point);
		}
		static public double _Ge0LtTau_ofAssumeNonnil(VectorDbl p)
		{
			return _Ge0LtTau_ofAssumeNonnil((Vector4dblI)p);
		}
	}
}
