namespace nilnul.physics.length
{
	public partial class Mile:UnitI
	{
		public const double MetersPerMile = 1605;
		public const double KmPerMile = MetersPerMile / 1000;
		public const double KmsPerMile = MetersPerMile / 1000;

		public const double MilesPerKm = 1/KmsPerMile;



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
