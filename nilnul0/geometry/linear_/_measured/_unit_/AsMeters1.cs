using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RI = nilnul.num.RealI;

using R1 = nilnul.num.RealI;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using Rx = nilnul.num.RealIX;



namespace nilnul.geometry._linear._length._unit_
{
	public interface AsMetersI3
		:nilnul.obj._metric._unit_.MagnitudeI
	{
		/// <summary>
		/// it's the unit, not length. unit must be positive in length.
		/// </summary>
		//nilnul.num.real_.PositiveI asMeters { get; }
	}
}
