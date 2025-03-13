using nilnul.num.complex;
using nilnul.num.complex.of_.binary_;
using nilnul.num.complex.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.ellipse_.central._boundary_.by_
{
	static public class _TimeX
	{
		static public (double boundaryRadiusX, double boundaryRadiusY) Boundary(
			Centered8origin ellipse
		)
		{



			/// https://math.stackexchange.com/questions/1889450/extrema-of-ellipse-from-parametric-form
			///

			double cosTilt = Math.Cos(ellipse.rotated);
			double sinTilt = Math.Sin(ellipse.rotated);
			/// the C(t) <see cref="ellipse_.Centered8origin.locus(double)"/>
			///
			/// the C`(t) :
			///  , the x`(t):
			///   -rX Cos(a) sin(t) - rY sin(a) * cos(t)
			///			,where a is the tilt angle of the ellipse
			///	let x`(t) =0,
			///		,we get tg(t) = -rY sin(a) / rX cos(a)
			///
			var t = Math.Atan2(-ellipse.radiusY * sinTilt, ellipse. radiusX * cosTilt);

			var xExtremum = Math.Abs(
				ellipse.locus(t).Real
			);

			///
			/// 
			/// ps:
			///		hence x(t) =
			///			cos(t) ( rx cos(a) - ry sin(a) tg(t) )
			///			= cos(t) / rx cos(a)    *  (rx^2 cos(a) ^2 + ry ^2 sin(a)^2      )
			///
			///  where cos(t) ^2 = 1 / (1+tg(t) ^2)
			///
			///   square the equation:
			///		 1 / (1+tg(t) ^2) / rx^2 cos(a)^2 *  (rx^2 cos(a) ^2 + ry ^2 sin(a)^2      )^2
			///		 = 
			///		 1/rx^2 cos(a)^2 / (1+tg(t) ^2)   *  (rx^2 cos(a) ^2 + ry ^2 sin(a)^2      )^2
			///		 = 
			///		1/ rx^2 cos(a)^2 / (1+ (rY sin(a) / rX cos(a) )^2  )   *  (rx^2 cos(a) ^2 + ry ^2 sin(a)^2      )^2
			///		 
			///		 = 
			///		1/ ( rx^2 cos(a)^2 + (rY sin(a)  )^2  )   *  (rx^2 cos(a) ^2 + ry ^2 sin(a)^2      )^2
			///		=  ( rx^2 cos(a)^2 + (rY sin(a)  )^2  )
			///		, hence x(t) =Sqrt ( rx^2 cos(a)^2 + (rY sin(a)  )^2  )
			///		 ,corroborate with <see cref="central._BoundaryX.Boundary(double, double, double)"/>
			/// 

			///
			/// 
			///	,similarly
			///	for y`(t)=0
			///		,
			///   -rX sin(a) sin(t) + rY cos(a) * cos(t)=0
			///   , 
			///   rX sin(a) sin(t) = rY cos(a) * cos(t)
			///   ,
			///    sin(t) / cos(t)= rY cos(a) /rX sin(a)
			///    ,
			///    tg(t) =rY cos(a) /rX sin(a)
			var t4y = Math.Atan2(-ellipse.radiusY * cosTilt, ellipse.radiusX * sinTilt);

			var yExtremum = Math.Abs(
				ellipse.locus(t4y).Imaginary
			);
			return (xExtremum, yExtremum);
			///
			/// ps:
			///		hence y(t) =
			///			cos(t) ( rx sin(a) + ry cos(a) tg(t) )
			///			= cos(t) / rx sin(a)    *  (rx^2 sin(a) ^2 + ry ^2 cos(a)^2      )
			///
			///  where cos(t) ^2 = 1 / (1+tg(t) ^2)
			///
			///   square the equation:
			///		 1 / (1+tg(t) ^2) / rx^2 sin(a)^2 *  (rx^2 sin(a) ^2 + ry ^2 cos(a)^2      )^2
			///		 = 
			///		 1/rx^2 sin(a)^2 / (1+tg(t) ^2)   *  (rx^2 sin(a) ^2 + ry ^2 cos(a)^2      )^2
			///		 = 
			///		1/ rx^2 sin(a)^2 / (1+ (rY cos(a) / rX sin(a) )^2  )   *  (rx^2 sin(a) ^2 + ry ^2 cos(a)^2      )^2
			///		 
			///		 = 
			///		1/ ( rx^2 sin(a)^2 + (rY cos(a)  )^2  )   *  (rx^2 sin(a) ^2 + ry ^2 cos(a)^2      )^2
			///		=  ( rx^2 sin(a)^2 + (rY cos(a)  )^2  )
			///		, hence x(t) =Sqrt ( rx^2 sin(a)^2 + (rY cos(a)  )^2  )
			///		 ,corroborate with <see cref="central._BoundaryX.Boundary(double, double, double)"/>




		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ellipse"></param>
		/// <returns>
		/// time starts at the ellipse radiusX postive point;
		/// </returns>

		static public (double time4x, double time4y) Extrema(
			Centered8origin ellipse
		)
		{



			/// https://math.stackexchange.com/questions/1889450/extrema-of-ellipse-from-parametric-form
			///

			double cosTilt = Math.Cos(ellipse.rotated);
			double sinTilt = Math.Sin(ellipse.rotated);
		
			var t4x = Math.Atan2(-ellipse.radiusY * sinTilt, ellipse. radiusX * cosTilt);

		


			var t4y = Math.Atan2(-ellipse.radiusY * cosTilt, ellipse.radiusX * sinTilt);

			
			return (t4x,t4y);




		}


	}
}
