using nilnul.geometry.linear_._measured;
using nilnul.geometry.linear_._measured.unit_;
using nilnul.geometry.linear_._measured.unit_.eng_;
using nilnul.geometry.linear_.measured.span.distance_.eng_;
using nilnul.geometry.linear_._measured;

namespace nilnul.geometry.linear_.measured.span.distance_0
{
	public class Centimeters4dbl
		:
		Distance4dbl,

		IDistance
	{
		public Centimeters4dbl(double magnitude) : base(magnitude, _measured.unit_.Centimeter4dbl.Singleton)
		{
		}

	

		static public Centimeters4dbl Of(span.Distance4dblI distance4Dbl) {
			return distance4Dbl switch
			{
				Centimeters4dbl k => k
					,
				_ => new Centimeters4dbl(
					distance4Dbl.amount.realee
							*
					distance4Dbl.unit.magnitude.dblen.ee
					/
					_measured.unit_.Centimeter4dbl.Singleton.magnitude.dblen.ee 
				)
			};
			
			
		 }

		static public Centimeters4dbl operator /(Centimeters4dbl distance, double x)
		{
			return new Centimeters4dbl(distance.amount.realee.ee / 2);
		}


	}
}
