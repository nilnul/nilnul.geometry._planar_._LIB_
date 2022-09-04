using System;
using nilnul.num;
using nilnul.num.real_;
using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;


namespace nilnul.geometry._linear._length.unit_
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete(nameof(_length.Unit))]
	public class Mm :
		_length.Unit,

		UnitI3

	{
		

		static public Mm Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Mm>.Instance;
			}
		}

	}
}
