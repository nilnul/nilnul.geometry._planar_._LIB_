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
	/// point. used in font;
	/// </summary>
	/// alias:
	///		pt
	///			,to avoid ambiguity of Point
	public class Pt4dbl:
		_measured.unit_.eng_.InInches4Dbl
		
	{
		public const int Pts_Per_Inch = 72;

		static public double _Inches_0points(double points) {
			return points / Pts_Per_Inch;
		}
		static public double _Points_0inchs(double inches) {
			return inches * Pts_Per_Inch;
		}


		public Pt4dbl() : base(1d/Pts_Per_Inch)
		{
		}

		static public Pt4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Pt4dbl>.Instance;
			}
		}


	}
}
