
using R1 = nilnul.num.RealI;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;



namespace nilnul.geometry._linear._length_
{
	/// <summary>
	/// amount as this is nonneg
	/// </summary>
	/// <remarks>
	/// nomenclature:
	///		the norm of a vector
	///			but norm can be 2-norm, or 3norm, in 1d, or 2d/3d space
	/// alias:
	///		distance
	///		span
	///		stretch
	///		segment
	///		reach
	///		
	/// </remarks>
	public  interface QuantityI1
	{
		nilnul.num.real_.NonnegI quantity { get; }
	}
}
