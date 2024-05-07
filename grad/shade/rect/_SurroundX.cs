using nilnul.geometry.planar.point;
using nilnul.geometry.planar.vect.co;
using nilnul.geometry.planar.vect.drag.co;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.shade.rect
{
	/// <summary>
	/// twice of <see cref="_StokesX"/>
	/// </summary>
	/// <see cref="grad.shade.rect._SurroundX"/>
	static public class _SurroundX
	{
		/// <summary>
		/// x smaller means the angle is bigger.
		/// twice of the <see cref="planar.grad._StokesX"/>
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		static public double ByChangeOfEksSmaller(Vect4dblI v1, Vect4dblI v2)
		{

			return planar.vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram(v1, v2)
				+
				_DeltaX.Minus(v1, v2)
			;
		}
		public static double Surround(double x, double y, double x2, double y2)
		{
			return (x - x2) * (y + y2);
		}

		public static double Surround((double x, double y) a, (double x2, double y2 ) b)
		{
			return Surround(a.x,a.y,b.x2,b.y2);
		}
		public static double Surround(((double x, double y) a, (double x2, double y2 ) b) w)
		{
			return Surround(w.a,w.b);
		}

		public static double Surround(Point4dblI point1, Point4dblI point2)
		{
			return Surround(
				point1.x,point1.y,point2.x,point2.y
			);
			//return (point1.x - point2.x) * (point1.y + point2.y);
		}


		public static double Surround(Complex start, Complex stop)
		{
			return Surround(start.Real, start.Imaginary, stop.Real, stop.Imaginary);
		}

		public static double Surround((Complex start, Complex stop) x)
		{
			return Surround(x.start, x.stop);
		}

		public static double Surround(Grad4dbl x)
		{
			return Surround(x.basis,x.end);
		}

		public static double Surround(Vect4dbl v1, Vect4dbl v2)
		{
			return Surround(v1.point, v2.point);
		}


		public static double StokesDoubled(this CoD x)
		{
			return Surround(x.component, x.component1);
		}

		public static double Surround(Grad4dbl_byPointsI x)
		{
			return Surround(x.basis,x.finish);

		}
	}
}
