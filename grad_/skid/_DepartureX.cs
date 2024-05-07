using nilnul.num.complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid
{
	/// <summary>
	/// for each point, there is a departure. we select the smallest;
	/// </summary>
	internal class _DepartureX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <returns></returns>
		static public double _Departure_01dif(
			Complex start
			,
			Complex end
		) {


			// take b-a as the basis for a new 1d geometry

			var base1d = end - start;


			/// get the foot.

			var innerProd = nilnul.geometry.planar.vect.co.scala_._DotProductX.Dbl(base1d, -start);


			var basisVariance = nilnul.geometry.planar.point._VarianceX.Variance( 
				base1d
			);

			var ratio = innerProd/ basisVariance; // the projection 's proportional to the basis.

			if (ratio<=0)
			{
				return nilnul.geometry.planar.point._VarianceX.Variance(
					start
				);
			}

			if (ratio>=1)
			{
				return nilnul.geometry.planar.point._VarianceX.Variance(
					end
				);

			}

			/// use Pythagorean theorem:
			/// 
			var leg = Math.Sqrt(
				start.Variance()
				-
				basisVariance*(ratio*ratio)   // let t= ( base1d / base1d.departure ) * (innerProduct / base1d.departure) =  base1d * innerProduct / base1d.Variance = base1d*ratio
							/// then t.Variance = base1d.Variance * ratio^2
				
			) ;

			return leg;

		}
	

	}
}
