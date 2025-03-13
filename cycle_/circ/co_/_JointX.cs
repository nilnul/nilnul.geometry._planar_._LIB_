using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.circ.co_
{
	/// <summary>
	/// the two discs intersect as an asymmetric len;
	/// </summary>
	static public class _JointX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="r1">
		/// radius of second circle
		/// </param>
		/// <param name="d">
		/// the x of the center of the 2nd circle;
		/// d is le r+r1
		/// 
		/// </param>
		/// <returns></returns>
		static public C _Intersected_0originatedRadius_1radius2nd_2distance4joint(
			double r
			,
			double r1
			,
			double d
		) {

			double dSq = d * d;
			double rSq = r * r;
			double r1Sq = r1 * r1;

			var x = (dSq - r1Sq + rSq) / (2 * d);

			var ySq = rSq - x * x;

			var y = Math.Sqrt(ySq);

			return new System.Numerics.Complex(x, y);

		}
	}
}
