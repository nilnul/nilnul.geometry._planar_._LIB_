using nilnul.geometry.planar.point;
using nilnul.geometry.planar.vect.co;
using nilnul.geometry.planar.vect.drag.co;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.trigonize.parlgrm.diag_.originated.drag.belt_
{
	/// <summary>
	/// twice of <see cref="_StokesX"/>, but sign might vary
	/// </summary>
	/// alias:
	///		core
	///		partial
	static public class _MiddleX
	{
	

		public static double ByWai2biggerArithmetic(Point4dblI point1, Point4dblI point2)
		{
			return (point1.x + point2.x) * (  point2.y - point1.y);
			
		}

		public static double ByWai2biggerArithmetic(Vect4dblI v1, Vect4dblI v2)
		{
			return ByWai2biggerArithmetic(v1.point,v2.point);
		}



		/// <summary>
		/// y bigger would mean the rotation is bigger.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		/// <remarks>
		///  the result of <see cref="bunch_._CentralX.ByChangeOfEksSmaller(Vect4dblI, Vect4dblI)"/> - the result of this  = 2 <see cref="_DeltaX.Minus(Vect4dblI, Vect4dblI)"/> (v1,v2)
		/// </remarks>
		static public double ByChangeOfWaiBigger(Vect4dblI v1, Vect4dblI v2)
		{

			return vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram (v1,v2)
				-
				_DeltaX.Minus(v1,v2)
			;
		}

	}
}
