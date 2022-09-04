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

namespace nilnul.geometry.linear_._measured.unit_
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
	public class EngAsInches4DblA
		:
		_eng_.Inches4dblI
		,
		Eng4dblI
		
	{
		private double _inches;

		public double inches
		{
			get { return _inches; }
			set { _inches = value; }
		}

		public PositiveDblI magnitude => new PositiveDbl(_inches*EngAsInch4Dbl.Meters_Per_This);

		public EngAsInches4DblA(nilnul.num.real_.PositiveDblI inches)
		{
			_inches = inches.dblen.ee;
		}

		public EngAsInches4DblA(nilnul.num.real_.PositiveDbl inches):this(
			(PositiveDblI)inches
		)
		{

		}
		

		public EngAsInches4DblA(double x) : this( new PositiveDbl(x) )
		{
		}

	
	}
}
