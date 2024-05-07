using nilnul.geometry.linear_._measured.unit.calc;
using nilnul.geometry.linear_._measured.unit.calc.amount_;
using nilnul.geometry.linear_._measured.unit.calc.amount_.ratio_;
using System;

namespace nilnul.geometry.linear_._measured.unit.calc.amount_.reduced.op_.binary_
{
	static public class _MultiX
	{

		public static Reduced4dbl Multi_assumeSameUnit(Reduced4dbl quantity, Reduced4dbl indiced)
		{
			return new Reduced4dbl(
				quantity.quantity * indiced.quantity
				,
				indiced.calc
			);
		}

		public static Reduced4dbl Multi2reduce(Reduced4dbl quantity, Reduced4dbl indiced)
		{
			return Multi_assumeSameUnit(
				quantity
				,
indiced.changeUnit(quantity.calc.radic)
			);
		}



	}
}
