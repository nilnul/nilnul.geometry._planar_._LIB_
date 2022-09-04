using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_.measured.speed_
{
	public class KmPerHour
		:linear_.measured.Speed4dbl
	{
		private measured.span.distance_.Kms4dbl _distance;

		public measured.span.distance_.Kms4dbl distance
		{
			get { return _distance; }
			set { _distance = value; }
		}

	

		public KmPerHour(measured.span.distance_.Kms4dbl x):base(x, time.seg._measure.unit_.Hour4dbl.Singleton)
		{
			_distance = x;
		}

		public KmPerHour(double x):this(new measured.span.distance_.Kms4dbl(x))
		{

		}

		static public KmPerHour Of (Speed4dbl x) {
			return x switch
			{
				KmPerHour k => k
				,
				_=> new KmPerHour(
					linear_.measured.span.distance_.Kms4dbl.Of(
						x.distance
					).amount.realee.ee
					/
					
					 nilnul.time.duration_.Hours4dbl.Of(
						new nilnul.time.Duration4dbl(
							1, 
						x.duration
						)
					).amount.realee
					
				)

			};
		}

		public override string ToString()
		{
			return $"{_distance}km/h";
		}


	}
}
