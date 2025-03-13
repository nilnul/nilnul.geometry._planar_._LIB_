using nilnul.num.complex;
using nilnul.num.complex.of_.binary_;
using nilnul.num.complex.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.ellipse_.central
{
	internal class _BoundaryX
	{
		static public (double boundaryRadiusX, double boundaryRadiusY) Boundary(
			double radiusX, double radiusY, double rotation
		)
		{

			/// math.stackexchange.com/questions/91132/how-to-get-the-limits-of-rotated-ellipse
			///

			/// 
			/// rotate by -<see cref="rotation"/>
			///
			///  
			//Func<C, bool> t = (x) => x.Rotate(-rotation).Scale(1 / radiusX, 1 / radiusY).Variance() == 1;




			/// then skew the ellipse vertically;
			///, thus for the new zone, the x wouldnot change, the y would be: y + ux:
			///
			//Func<C, double, bool> t1 = (x, u) => x.Rotate(-rotation).Scale(1 / radiusX, 1 / radiusY).SkewImaginary(u).Variance() == 1;
			/// 

			/// the transformed is still an ellipse(?
			///	if we have problem with this, we can use <see cref="_boundary_.by_._TimeX"/>
			/// )
			/// , with c,d as the radiusX, and radiusY. and pi*cd = pi ab, as this skew is area-preserving. C would be the minX before skewing.
			///
			/// to find the vertical radius, d: , 

			double cos = Math.Cos(rotation);
			double sin = Math.Sin(rotation);
			/// ,let x :=0,
			///
			///  
			///  ( (y+ux) sin(t) )^2 / a^2 + ( (y+ux) cos(t) )^2/ b^2 =1
			///  
			///  ( y sin(t) )^2 / a^2 + ( y cos(t) )^2/ b^2 =1
			///  
			///  , where y is vertical coord of intersected point at x =0
			///	, that is:
			///		 ( d sin(t) )^2 /a ^2 + ( d cos(t) )^2 /b ^2 =1
			/// 
			/// , therefore:
			///		d^2 / (a^2 * b^2) * ( ( b sin(t) )^2 + a cos(t) ^2 ) =1
			/// , recall:
			///		d/ab =1/c
			///	,so,
			///		1/c^2 * ( ( b sin(t) )^2 + a cos(t) ^2 ) =1
			///	,so,
			///
			return (
				nilnul.num.real.str.to_.scalar_.Norm.Singleton.op(
					radiusX * cos
					,
					radiusY * sin
				)
					,
				nilnul.num.real.str.to_.scalar_.Norm.Singleton.op(
					radiusX * sin
					,
					radiusY * cos
				)
			); // where the sq sum of the  two is radiusX^2+radiusY^2

		}

		/// alternatively, we can also express: dy/dt, and dx/dt, and let them be 0;
	}
}
