using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynomial_.ordPonTwo
{
	/// <summary>
	/// let m denotes the ord 2^n
	/// find the complex roots of x^m=1, which is evenly distributed on the circle, start at 1.
	/// let each of this root be x in the polynomial,
	/// compute the value of the whole expression.
	///
	/// Each complex number represents a point. We get the points. But the points are not directly the points at the polynomial; they are somehow transformed.
	/// 
	/// </summary>
	public class FourierFastTransform
	{
		/// <summary>
		/// </summary>
		/// <param name="_coefs_countAssumeTwoPon"> coefs of the polynomial</param>
		/// <returns>
		/// let the variable takes the value interpolated at the unital complex circle.
		/// returns the value of the whole expr.
		/// </returns>
		/// <remarks>
		/// to restore coefs from complex results, use iFft?
		/// <see cref="complex.matrix_.sym_.vandermonde_._DiscreteFourierTransformMatrixX"/> as M
		///		M * CoefsAsColwise= Fft		//the result
		///	hence:
		///		CoefsAsColwise = M^-1 *Fft
		///		for the inverse <see cref="complex.matrix_.sym_.vandermonde_._DiscreteFourierTransformMatrixX"/>
		///  
		/// </remarks>
		public nilnul.num.Complex4dbl[] _OfCoefs_countAssumeTwoPon(double[] _coefs_countAssumeTwoPon) {
			var width = _coefs_countAssumeTwoPon.Length;
			if (width ==1)
			{
				return _coefs_countAssumeTwoPon.Select( c=>(Complex4dbl)c ).ToArray();
			}


			var halfWidth = width / 2;

			var pEven =new double[halfWidth];
			for (int i = 0, j=0; i < halfWidth; i++,j+=2)
			{
				pEven[i] = _coefs_countAssumeTwoPon[j];
			}
			var pOdd =new double[halfWidth];
			for (int i = 0, j=1; i < halfWidth; i++,j+=2)
			{
				pOdd[i] = _coefs_countAssumeTwoPon[j];
			}

			var fft4even = _OfCoefs_countAssumeTwoPon(pEven);
			var fft4odd= _OfCoefs_countAssumeTwoPon(pOdd);

			var r = new nilnul.num.Complex4dbl[
				width
			];

			var azimuthIncrement = Math.PI * 2 /width;

			var currentAzimuth = 0d;
			for (int i = 0; i < halfWidth; i++)
			{
				var complexMultiplier = new nilnul.num.complex_.polar_.Unital4dbl(
					currentAzimuth
				);
				r[i] = fft4even[i] + complexMultiplier * fft4odd[i];
				r[i+halfWidth] = fft4even[i] - complexMultiplier * fft4odd[i];

				currentAzimuth += azimuthIncrement;
			}

			return r;



		}
	}
}
