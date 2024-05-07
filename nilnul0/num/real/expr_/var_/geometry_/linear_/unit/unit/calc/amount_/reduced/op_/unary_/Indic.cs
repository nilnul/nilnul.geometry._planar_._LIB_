using nilnul.geometry.linear_.measured.span;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit.calc.amount.op_.unary_
{
	static public class _IndicX
	{
		/// <summary>
		/// ( 3* cm^-2 )^5
		/// = 
		/// </summary>
		/// <param name="reduced"></param>
		/// <param name="indic"></param>
		/// <returns></returns>
		static public amount_.Reduced4dbl Indic(amount_.Reduced4dbl reduced
			,
			BigInteger indic
		) {
			return				new amount_.Reduced4dbl(
				//nilnul.num.real.op_.unary_.pow_._IndexX.
				Math.Pow(reduced.quantity, (double)indic)
				,
				 calc.op_.unary_._IndicX.Indic(reduced.calc, indic)
			);
		}

		internal static amount_.Reduced4dbl Indic(Distance4dbl radicNormalized, BigInteger indic)
		{
			return				new amount_.Reduced4dbl(
				//nilnul.num.real.op_.unary_.pow_._IndexX.
				Math.Pow(radicNormalized.amount.realee.ee, (double)indic)
				,
				 calc.op_.unary_._IndicX.Indic(radicNormalized.unit, indic)
			);

		}
	}
}
