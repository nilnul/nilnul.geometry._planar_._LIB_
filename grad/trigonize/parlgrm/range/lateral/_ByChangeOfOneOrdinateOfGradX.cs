using nilnul.geometry.planar.point;
using nilnul.geometry.planar.vect.co;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.trigonize.parlgrm.range.lateral
{
	/// <summary>
	/// twice of <see cref="_StokesX"/>
	/// </summary>
	/// alias:
	///		core
	///		partial
	static public class _ByChangeOfOneOrdinateOfGradX
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
				_RangeStokesMinusX.RangeStokesMinus(v1,v2)
			;
		}
		public static double StokesDoubled(Point4dblI point1, Point4dblI point2)
		{
			return (point1.x - point2.x) * (point1.y + point2.y);
			
		}


		public static double ByWai2biggerArithmetic(Point4dblI point1, Point4dblI point2)
		{
			return (point1.x + point2.x) * (  point2.y - point1.y);
			
		}

		public static double ByWai2biggerArithmetic(Vect4dblI v1, Vect4dblI v2)
		{
			return ByWai2biggerArithmetic(v1.point,v2.point);
		}

		public static double StokesDoubled(Vect4dbl v1, Vect4dbl v2)
		{
			return StokesDoubled(v1.point,v2.point);
		}


		public static double StokesDoubled(this CoD x)
		{
			return StokesDoubled(x.component,x.component1);
		}

		/// <summary>
		/// y bigger woudl mean the rotation is bigger.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		static public double ByChangeOfWaiBigger(Vect4dblI v1, Vect4dblI v2)
		{

			return vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram (v1,v2)
				-
				_RangeStokesMinusX.RangeStokesMinus(v1,v2)
			;
		}




	}
}
