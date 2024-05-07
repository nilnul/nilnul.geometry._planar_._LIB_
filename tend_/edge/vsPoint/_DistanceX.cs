using nilnul.num.complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend_.edge.vsPoint
{
	/// <summary>
	///  we select the smallest;
	/// </summary>
	internal class _DistanceX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <returns></returns>
		static public double _Departure_01dif(
			(Complex start
			,
			Complex end
			) edge
			,
			Complex point
		) {


			// take b-a as the basis for a new 1d geometry

			var base1d = edge.end - edge.start;


			/// get the foot.

			Complex froStart = point - edge.start;

			var innerProd = nilnul.geometry.planar.vect.co.scala_._DotProductX.Dbl(base1d, froStart);


			var basisVariance = nilnul.geometry.planar.point._VarianceX.Variance( 
				base1d
			);

			var ratio = innerProd/ basisVariance; // the projection 's proportional to the basis.

			if (ratio<=0)
			{
				return nilnul.geometry.planar.point._VarianceX.Variance(
					 froStart
				);
			}

			if (ratio>=1)
			{
				return nilnul.geometry.planar.point._VarianceX.Variance(
					point -edge.end
				);

			}

			/// use Pythagorean theorem:
			/// 
			var leg = Math.Sqrt(
				froStart.Variance()
				-
				basisVariance*(ratio*ratio)   // let t= ( base1d / base1d.departure ) * (innerProduct / base1d.departure) =  base1d * innerProduct / base1d.Variance = base1d*ratio
							/// then t.Variance = base1d.Variance * ratio^2
				
			) ;

			return leg;

		}
	

	}
}
