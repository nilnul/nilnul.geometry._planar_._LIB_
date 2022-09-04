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


namespace nilnul.geometry.linear_._measured.unit_.eng_
{
	[Obsolete(nameof(unit_.EngAsInch4Dbl))]
	public class Inch4dbl:
		_measured.Unit4dblA
		,
		Eng4dblI
	{

		public const double Meters_per_Inch = 2.54/100;

		public const decimal Inch2meterAsDecimal = .0254m;
		public const double Inch2MeterAsDouble = (double)Inch2meterAsDecimal;
		public const double MeterPerInch = (double)Inch2meterAsDecimal;

		public const double InchesPerFoot = 12;

		static public double InchPerMeter = 1d / MeterPerInch;

		static public double InchPerCm = InchPerMeter / 100;
		static public  double InchesPerMm = InchPerMeter / 1000;

		static public double CmPerInch = 1d / InchPerCm;



		

		public Inch4dbl() : base( MeterPerInch)
		{
		}

		static public double ToMeter(double inches = 1)
		{
			return MeterPerInch * inches;
		}
		static public double ToCm(double inches = 1)
		{
			return CmPerInch * inches;
		}

		static public double ToInch(double meter = 1)
		{
			return meter * InchPerMeter;
		}

		static public double FootToInces(double feet) {
			return feet * InchesPerFoot;
		}



		static public Inch4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Inch4dbl>.Instance;
			}
		}


	}
}
