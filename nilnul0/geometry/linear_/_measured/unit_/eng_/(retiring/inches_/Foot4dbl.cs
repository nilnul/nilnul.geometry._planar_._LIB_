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

namespace nilnul.geometry.linear_._measured.unit_.eng_.inches_
{
	/// <summary>
	/// </summary>
	///
	[Obsolete(nameof(eng_.Foot4dbl1))]
	public class Foot4dbl:
		_measured.unit_.eng_.InInches4Dbl
		
	{

		public Foot4dbl() : base(12)
		{
		}

		static public Foot4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Foot4dbl>.Instance;
			}
		}


	}
}
