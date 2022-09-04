using System;
using nilnul.num;
using Quotient = nilnul.num.real_.Quotient;
using nilnul.num.real.op_.binary_;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using RI = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;
using R = nilnul.num.Real;
using nilnul.num.real_;

namespace nilnul.geometry.linear_._measured.unit_.eng_
{
	/// <summary>
	/// <see cref="_measured.unit_.EngAsInch4Dbl"/>
	/// </summary>
	///
	[Obsolete(nameof(unit_.EngAsInches4DblA))]
	public class InInches4Dbl
		:
		_measured.Unit4dblA,
		Eng4dblI
	{
		public InInches4Dbl(nilnul.num.real_.PositiveDblI inches):base(
			inches.dblen.ee * eng_.Inch4dbl.Inch2MeterAsDouble
		)
		{
		}

		public InInches4Dbl(nilnul.num.real_.PositiveDbl inches):this(
			(PositiveDblI)inches
		)
		{


		}
		

		public InInches4Dbl(double x) : this( new PositiveDbl(x) )
		{
		}

	
	}
}
