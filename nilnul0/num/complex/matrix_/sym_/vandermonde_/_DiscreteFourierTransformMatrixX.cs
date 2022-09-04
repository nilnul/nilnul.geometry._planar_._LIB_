using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.complex.matrix_.sym_.vandermonde_
{
	/// <summary>
	/// <see cref="num.real.expr_.polynomial.op_.binary_.multi_.FastFourierTransform"/>
	/// </summary>
	static public class _DiscreteFourierTransformMatrixX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_positive">has to be positive, as this is one plus the order of polynomial, the minimal of which is nil.</param>
		/// <returns></returns>
		static public nilnul.num.complex_.polar_.Unital4dbl[,] _Of4dbl_assumePositive(int _positive)
		{

			var r = new nilnul.num.complex_.polar_.Unital4dbl[
				_positive
				,
				_positive
			];

			var oneAngle = Math.PI * 2 / _positive;

			var rotationIncr = 0d;

			for (int row00 = 0; row00 < _positive; row00++)
			{

				var initial = 0d;

				for (int col = 0; col < _positive; col++)
				{

					r[row00, col] = new nilnul.num.complex_.polar_.Unital4dbl(
						initial
					);
					initial += rotationIncr;

				}
				 rotationIncr += oneAngle;

			}

			return r;
		}
		static public nilnul.num.complex_.polar_.Unital4dbl[,] _ConjugateOf4dbl_assumePositive(int _positive)
		{

			var r = new nilnul.num.complex_.polar_.Unital4dbl[
				_positive
				,
				_positive
			];

			var oneAngle = -Math.PI * 2 / _positive;

			var rotationIncr = 0d;

			for (int row00 = 0; row00 < _positive; row00++)
			{

				var initial = 0d;

				for (int col = 0; col < _positive; col++)
				{
					r[row00, col] = new complex_.polar_.Unital4dbl(
						
						initial
					) ;
					initial += rotationIncr;
				}
				 rotationIncr += oneAngle;
			}
			return r;
		}
		static public nilnul.num.complex_.Polar4dbl_radiusAllowNeg[,] _InverseByConjugateOf4dbl_assumePositive(int _positive)
		{
			var t = _ConjugateOf4dbl_assumePositive(_positive);

			complex_.Polar4dbl_radiusAllowNeg[,] r = new complex_.Polar4dbl_radiusAllowNeg[_positive,_positive];

			for (int row00 = 0; row00 < _positive; row00++)
			{
				for (int col = 0; col < _positive; col++)
				{
					r[row00, col] = t[row00,col] / _positive;
				}
			}
			return r;
		}

		static public nilnul.num.complex_.Polar4dbl_radiusAllowNeg[,] _InverseOf4dbl_assumePositive(int _positive)
		{

			var r = new nilnul.num.complex_.Polar4dbl_radiusAllowNeg[
				_positive
				,
				_positive
			];

			var oneAngle = -Math.PI * 2 / _positive;

			var rotationIncr = 0d;

			for (int row00 = 0; row00 < _positive; row00++)
			{

				var initial = 0d;

				for (int col = 0; col < _positive; col++)
				{
					r[row00, col] = new complex_.Polar4dbl_radiusAllowNeg(
						1d/_positive
						,
						initial
					) ;
					initial += rotationIncr;
				}
				 rotationIncr += oneAngle;
			}
			return r;
		}

		static public nilnul.num.complex_.polar_.Unital[,] _Of_assumePositive(int _positive)
		{

			var r = new nilnul.num.complex_.polar_.Unital[
				_positive
				,
				_positive
			];

			var oneAngle = nilnul.num.real_.Tau.Singleton.ToReal() / _positive;

			var rotationIncr = nilnul.num.real_.Quotient.Nil.ToReal();

			for (int row00 = 0; row00 < _positive; row00++)
			{

				var initial = nilnul.num.real_.Quotient.Nil.ToReal();

				for (int col = 0; col < _positive; col++)
				{

					r[row00, col] = new nilnul.num.complex_.polar_.Unital(
						initial
					);
					initial += rotationIncr;

				}
				rotationIncr += oneAngle;

			}

			return r;
		}
	}
}
