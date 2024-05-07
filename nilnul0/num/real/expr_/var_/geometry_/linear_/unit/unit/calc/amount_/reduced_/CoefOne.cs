using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit.calc.amount_.reduced_
{
	internal class CoefOne
	{
			/// <summary>
			/// eg:
			///		cm^-2
			///			= ( cm * mm/cm / 0.1)^-2
			///			=  ( mm /0.1 )^-2
			///			=  mm^-2 / 0.1^-2
			///			= 1/0.1^-2 * mm^-2
			/// </summary>
			/// <param name="unit"></param>
			/// <returns></returns>
		static public Reduced4dbl ChangeUnit(
			unit.calc_.Indic4dbl indic4Dbl
			,

			Unit4dblI unit
		)
		{

			///deal with the unitCalc;
			///
			var radic = indic4Dbl.radic;

			var normalized = new ratio_.Normalized(unit, radic);


			var radicNormalized = _measured.unit.calc.amount.op_.binary_._MultiX._Multi_assumeLeftIsRightDenom(
				radic
				,
				normalized
			);

			var indiced = amount.op_.unary_._IndicX.Indic(
				radicNormalized
				,
				indic4Dbl.indic
			);

			return indiced;

		}
	}
}
