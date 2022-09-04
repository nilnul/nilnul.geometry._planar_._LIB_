using System;

namespace nilnul.geometry._length.unt.meter
{
	public class Cent:nilnul.geometry._linear._length.Unit
	{
		/// <summary>
		/// 公分 in Taiwan
		/// </summary>
		public const string InCn = "厘米";

		public const double Meters_per_Cent = .01;

		public double AsMeters
		{
			get
			{
				return Meters_per_Cent;
				throw new NotImplementedException();
			}
		}
		public override string ToString()
		{
			return "cm";
		}
	}
}
