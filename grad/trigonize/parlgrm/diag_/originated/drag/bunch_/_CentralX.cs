using nilnul.geometry.planar.point;
using nilnul.geometry.planar.vect.co;
using nilnul.geometry.planar.vect.drag.co;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.trigonize.parlgrm.diag_.originated.drag.bunch_
{
	/// <summary>
	/// twice of <see cref="_StokesX"/>
	/// </summary>
	/// <see cref="grad.shade.rect.ISurround"/>
	/// alias:
	///		core
	///		partial
	static public class _CentralX
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

			return planar.vect.co. to_.real_._CrossProductX.SurroundedOfParallelogram (v1,v2)
				+
				_DeltaX.Minus(v1,v2)
			;
		}

		public static double StokesDoubled(Point4dblI point1, Point4dblI point2)
		{
			return (point1.x - point2.x) * (point1.y + point2.y);
		}
		public static double StokesDoubled(double x, double y, double x2,double y2)
		{
			return (x - x2) * (y + y2);
		}

		public  static double StokesDoubled(Complex start, Complex stop)
		{
			return StokesDoubled(start.Real,start.Imaginary,stop.Real,stop.Imaginary);
		}

		

		public static double StokesDoubled(Vect4dbl v1, Vect4dbl v2)
		{
			return StokesDoubled(v1.point,v2.point);
		}


		public static double StokesDoubled(this CoD x)
		{
			return StokesDoubled(x.component,x.component1);
		}


	}
}
