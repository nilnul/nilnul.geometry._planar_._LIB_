using nilnul.geometry.linear_._measured;
using nilnul.geometry.linear_._measured.unit_;
using nilnul.geometry.linear_._measured.unit_.eng_;
using nilnul.geometry.linear_.measured.span.distance_.eng_;
using nilnul.geometry.linear_._measured;

namespace nilnul.geometry.linear_.measured.span.distance_
{
	public class Kms4dbl
		:
		Distance4dbl,

		IDistance
	{
		public Kms4dbl(double magnitude) : base(magnitude, _measured.unit_.Km4dbl.Singleton)
		{
		}

		public Kms4dbl(span.Distance4dblI distance4Dbl):this(
			distance4Dbl.amount.realee
			*
			

			distance4Dbl.unit.magnitude.dblen / _measured.unit_.Km4dbl.MetersPerKm
		)
		{

		}

		static public Kms4dbl Of(span.Distance4dblI distance4Dbl) {
			return distance4Dbl switch
			{
				Kms4dbl k => k
					,
				_ => new Kms4dbl(
					distance4Dbl.amount.realee
							*
					distance4Dbl.unit.magnitude.dblen.ee / _measured.unit_.Km4dbl.Singleton.magnitude.dblen.ee //.MetersPerKm
				)
			};
			
			
		 }

		
	}
}
