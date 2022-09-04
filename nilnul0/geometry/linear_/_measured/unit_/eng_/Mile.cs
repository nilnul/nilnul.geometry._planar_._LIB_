using System;

namespace nilnul.geometry.linear_._measured.unit_.eng_
{
	public  class MileDbl:IEng
	{
		public const double MetersPerMile = 1760*Yard.MetersPerYard;    //1760*3*12*2.54*.01 = 1609.344

		public const double KmPerMile = MetersPerMile / 1000;
		public const double KmsPerMile = MetersPerMile / 1000;

		public const double MilesPerKm = 1 / KmsPerMile;

		public double AsMeters
		{
			get
			{
				return MetersPerMile;
			}
		}

		static public double ToKm(double miles)
		{
			return miles * 1.605;
		}
		static public double Kms2Miles(double kms)
		{
			return kms * MilesPerKm;
		}

	}
}
