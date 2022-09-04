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

namespace nilnul.geometry.linear_._measured.unit_._eng_
{
	/// <summary>
	/// as we use inch for resolution of screen, it's common. Also it's palphable, derived as the width of thumb. (rule of thumb?)
	/// </summary>
	/// <remarks>
	/// also we now in specification define 1inch in meters exactly as 2.54cm.
	/// </remarks>
	/// alias:
	///		inch
	///			sounds somewhat similar to english
	///			inch in
	public interface Inches4dblI
	{

		double inches { get; }
	
	}
}
