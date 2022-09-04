using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.geometry.planar.vect
{
	/// <summary>
	/// alias:
	///		Length
	/// </summary>
	static public class _MagnitudeX
	{
		static public nilnul.num.real_.Nonneg Magnitude(nilnul.num.Real x, nilnul.num.Real y )
		{
			return new nilnul.num.real_.Nonneg( nilnul.num.real.op_.unary_.Sqrt.Singleton.op(
				nilnul.num.real.op_.unary_.Square.Singleton.op(x).ToReal()
				+
				nilnul.num.real.op_.unary_.Square.Singleton.op(y).ToReal()

			));
		}

		static public double Magnitude(double x, double y )
		{
			return nilnul.num.real.co.band_._NormX.Dbl(x,y);
		}



		static public float Magnitude(float x, float y )
		{
			return (float)Math.Sqrt(
				nilnul.num.reals.aggregate_.SqSum.Singleton.aggregate(x,y)
			);
		}

		public static nilnul.num.real_.Nonneg Magnitude(IVector obj)
		{
			return Magnitude(obj.point);
		}

		public static Nonneg Magnitude(Point1 point)
		{
			return Magnitude(point.x, point.y);
		}

		public static double Magnitude(Point4dblI point)
		{
			return Magnitude(point.x, point.y);
		}

		public static float Magnitude(PointF pointF)
		{
			return Magnitude(pointF.X, pointF.Y);
		}

		public static double Magnitude(Point4dbl point)
		{
			return Magnitude(point.x, point.y);
		}

		public static double Magnitude(VectorDbl vectorDbl)
		{
			return Magnitude(vectorDbl.point);
		}

		public static double Magnitude(Vector4dblI vectorDbl)
		{

			return Magnitude(vectorDbl.point);
		}

		public static double Magnitude(Vect4dblI vect)
		{
			return Magnitude(vect.point);

		}
	}
}
