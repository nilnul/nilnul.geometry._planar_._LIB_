using System;
using nilnul.num;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using Rx = nilnul.num.RealIX;


namespace nilnul.geometry._length.unit_
{
	/// <summary>
	/// 
	/// </summary>
	public class Mm : UnitI2
	{
		public R asMeters
		{
			get
			{
				return nilnul.num.real_.Quotient.CreateUnitFrac(1000);
				//throw new NotImplementedException();
			}
		}


		static public readonly Mm Singleton = SingletonByDefault<Mm>.Instance;

	}
}
