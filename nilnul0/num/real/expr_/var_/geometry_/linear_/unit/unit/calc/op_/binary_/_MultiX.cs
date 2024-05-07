using nilnul.geometry.linear_._measured.unit.calc_.binary_;
using System;

namespace nilnul.geometry.linear_._measured.unit.calc.op_.binary_
{
	static public  class _MultiX
	{
		static public Calc4dblI Multi2reduce(Unit4dblI a, Unit4dblI b) {
			if (a==b)
			{
				return new calc_.Indic4dbl(a, 2);
			}
			return new calc_.binary_.Multi4dbl(a, b);
		}

		internal static Calc4dblI Multi2reduce(Unit4dblI radic, Ratio4dbl ratio)
		{
			if (radic == ratio.denominator)
			{
				return new calc_.Unit4dbl( ratio.numerator );
			}
			return calc.op_.binary_._DivideX.Divide(
				calc.op_.binary_._MultiX.Multi2reduce(radic, ratio.numerator)
				,
				ratio.denominator
			);
		}

		internal static Unit4dblI _Multi2reduce_assumeLeftEqRightDenom(Unit4dblI radic, Ratio4dbl ratio)
		{
			return ratio.numerator;

		}
	}
}
