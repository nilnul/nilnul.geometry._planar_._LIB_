using nilnul.geometry.linear_._measured.unit.calc;
using nilnul.geometry.linear_._measured.unit.calc.amount_;
using nilnul.geometry.linear_._measured.unit.calc.amount_.ratio_;
using System;

namespace nilnul.geometry.linear_._measured.unit.calc.amount.op_.binary_
{
	static public  class _MultiX
	{
		static public Calc4dblI Multi2reduce(Unit4dblI a, Unit4dblI b) {
			return calc.op_.binary_._MultiX.Multi2reduce(a,b);
		
		}

		public static Amount4dbl _Multi2reduce(Unit4dblI radic, Normalized normalized)
		{
			return new Amount4dbl(
				normalized.quantity,

				calc.op_.binary_._MultiX.Multi2reduce(
				radic
				,
				normalized.ratio
			));

		}
		public static measured.span.Distance4dbl _Multi_assumeLeftIsRightDenom(Unit4dblI radic, Normalized normalized)
		{
			return new measured.span.Distance4dbl(
				normalized.quantity,

				calc.op_.binary_._MultiX._Multi2reduce_assumeLeftEqRightDenom(
				radic
				,
				normalized.ratio
			));

		}

		public static Reduced4dbl Multi2reduce(double quantity, Reduced4dbl indiced)
		{
			return new Reduced4dbl(
				quantity* indiced.quantity
				,
				indiced.calc
			);
		}

	}
}
