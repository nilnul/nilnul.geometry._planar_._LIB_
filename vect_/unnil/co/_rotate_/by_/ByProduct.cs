using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil.co._rotate_.by_
{
	static public class _ByProductX
	{
		/// <summary>
		/// <see cref="planar. rotation_.ISwing"/>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public double Veer_01nonnil(
			Complex a
			,
			Complex b
		) {
			var crossProd = nilnul.geometry.planar.vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram(
				a,b
				);

			var sign = nilnul.num.real._SignDblX.Sign(crossProd);

			return sign * Math.Acos(
				vect.co.to_.real_._DotProductX.Dbl(a,b)
				/
				(a.Magnitude*b.Magnitude)
			);
		}
	}
}
