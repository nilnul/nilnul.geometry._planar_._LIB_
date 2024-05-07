using nilnul.geometry.linear_._measured.unit.calc_;
using nilnul.geometry.linear_._measured.unit.calc_.binary_;
using System;
using System.Numerics;

namespace nilnul.geometry.linear_._measured.unit.calc.op_.unary_
{
	static public  class _IndicX
	{
		

		public  static calc_.Indic4dbl Indic( calc_.Indic4dbl ratio, BigInteger indic)
		{
			return new calc_.Indic4dbl(
				ratio.radic
				,
				ratio.indic*indic
			);
		}

		public static Indic4dbl Indic(Unit4dblI unit, BigInteger indic)
		{
			return new calc_.Indic4dbl(
				unit
				,
				indic
			);

		}
	}
}
