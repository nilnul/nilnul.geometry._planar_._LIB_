using nilnul.num.real_;
using System;

namespace nilnul.geometry.linear_._measured.unit_.eng_
{
	public  class Mile4dbl
		:
		unit_.EngAsInches4DblA
		,
		IEng
	{
		//public const double MetersPerMile = 1760*Yard.MetersPerYard;    //1760*3*12*2.54*.01 = 1609.344


		public const int YARDS_PER_THIS = 1760;


		public Mile4dbl() : base(YARDS_PER_THIS*Yard4dbl.Singleton.inches)
		{
		}


		static public Mile4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Mile4dbl>.Instance;
			}
		}


		public double magnitudeInKmAsDbl {
			get {
				return magnitude.dblen.ee / 1000;
			}
		}

		static public double ToKm(double miles)
		{
			return miles * Singleton.magnitudeInKmAsDbl;
		}
	

		public static double MilesPerKm = 1 / Singleton.magnitudeInKmAsDbl;
		static public double Kms2Miles(double kms)
		{
			return kms * MilesPerKm;
		}

	}
}
