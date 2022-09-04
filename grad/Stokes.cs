using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point;

namespace nilnul.geometry.planar.grad
{
	/*
	 dxdy (go postiveward along row, then go upward along col)和dydx (go upward along col, then go postiveward along row)是两个相反的方向，做出来的积分会差一个负号。直观理解你可以做一个叉积，如果dx×dy朝外就叫做外面，朝里就叫做里面。
	 */

	/// <summary>
	///		for a coordinates with x-axis towards right and y-axis towards up, taking anti-clockwise as the positive direction (that is moving the positive ray of x-axis towards the positive direction of y-axis), we compute the area of the enclosed surface by:
	///				1) positive ray of x-axis
	///				2) the two perpendiculars from endpoint of the grad.
	///				3) the grad
	///		thus if the grad is in the opposite direction of x-axis, this is the correct direction, as we move along the positive direction of x-axis, then up the right endpoint of the grad, then we can move along the same (not opposite) direction of the "move/grad"
	///
	///		if the grad is in the same direction of x-axis, the result will be negative
	/// </summary>
	/// <remarks>
	///		with reference to Stokes Theorem,
	///		
	/// </remarks>
	static public class _StokesX
		
	{
		

		/// <summary>
		/// signed area, which is an integral
		/// </summary>
		/// <param name="co"></param>
		/// <returns></returns>
		static public nilnul.num.RealI Stokes(this nilnul.geometry.planar.point.Co co)
		{
			//trapoid
			return nilnul.num.real.co_.divisible._DivX.Bind(
				nilnul.num.real.op_.binary_.Multi.Singleton.op(

					nilnul.num.real.op_.binary_.Minus.Singleton.op(co.begin.x,co. end.x)
					,
					nilnul.num.real.op_.binary_.Add.Singleton.op(co.end.y, co.begin.y)
				)
				,
				2
			);
			//throw new NotImplementedException();
		}
		public static nilnul.num.RealI Stokes(this GradI co)
		{

			//trapoid
			return nilnul.num.real.op_.unary_._ScaleX.Halve(
				nilnul.num.real.op_.binary_.Multi.Singleton.op(

					nilnul.num.real.op_.binary_.Minus.Singleton.op(co.points.component.x,co. points.component1.x)
					,
					nilnul.num.real.op_.binary_.Add.Singleton.op(co.points.component.y, co.points.component1.y)
				)
				
			);

		}
		public static nilnul.num.RealI Stokes(this Grad x)
		{
			return Stokes((GradI)x);
		}
		private static double Stokes(Point4dblI basis, Point4dblI end)
		{
			return (basis.x- end.x) * (basis.y+end.y) /2;
			
		}


		public static double Stokes(this CoD x)
		{
			return grad.trigonize.parlgrm.range.lateral._ByChangeOfOneOrdinateOfGradX.StokesDoubled(x)/2;
		}


		public static double Stokes(this grad_.Step4dblI x)
		{
			return Stokes(x.basis,x.end);
		}

		public static double Stokes(this grad_.Step4dbl x)
		{
			return Stokes(x.basis,x.end);
		}

		public static double Stokes(this Grad4dblI x)
		{
			return Stokes(
				new grad_.Step4dbl(x)
			);
		}

		public static double Stokes(this Grad4dbl x)
		{
			return Stokes((Grad4dblI)x);
		}




	}
}
/// the area of  From duo.bgin to duo.end, then down to duo.end's projection, then to duo.bigin's projection, then up to duo.bgin
///  Note the area is signed; it can be negaive or postive or zero.
///  Note: the area's sign is positive, if the circle's direction is position.  The cloze's direction is positive if the rotation is positve. See rotation.
