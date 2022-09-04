namespace nilnul.physics.length
{
	public class Inch
	{
		public const decimal Inch2Meter=.00254m;
		public const double Inch2MeterAsDouble = .00254;
		public const double MeterPerInch = .00254;

		static public double ToMeter(double inches=1)
		{
			return MeterPerInch * inches;
		}



	}
}
