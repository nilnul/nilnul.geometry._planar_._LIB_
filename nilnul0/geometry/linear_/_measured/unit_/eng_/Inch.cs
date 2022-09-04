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
	public class Inch:
		EngI
		
	{

		public const double Meters_per_Inch = 2.54/100;
		public const decimal Inch2Meter = .0254m;
		public const double Inch2MeterAsDouble = (double)Inch2Meter;
		public const double MeterPerInch = (double)Inch2Meter;

		public const double InchesPerFoot = 12;

		static public double InchPerMeter = 1d / MeterPerInch;

		static public double InchPerCm = InchPerMeter / 100;
		static public  double InchesPerMm = InchPerMeter / 1000;

		static public double CmPerInch = 1d / InchPerCm;

		public static readonly R  Feet_perThis = Quotient.CreateUnitFrac(12);

		public double AsMeters
		{
			get
			{
				return MeterPerInch;
				throw new NotImplementedException();
			}
		}

		public R asMeters
		{
			get
			{
				return Feet_perThis * (Foot.Singleton.asMeters);
				//throw new NotImplementedException();
			}
		}

		public num.real_.PositiveI magnitude =>
			new num.real_.Positive(
			asMeters
			)
			;

		public override string ToString()
		{
			return "in";
		}

		public const string InChinese = "吋";

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



		static public Inch Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Inch>.Instance;
			}
		}


	}
}
