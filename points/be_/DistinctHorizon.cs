using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.points.be_
{
	public  class DistinctHorizonDbl
		:

		BeI
	{
		
		public bool be(IEnumerable<Point4dbl> points)
			
		{

			return nilnul.obj.str_.enumerable.be_.Distinct_eqDefault<Point4dbl, point.eq_.ByHorizonDbl>.Singleton.be(points);

			

				


		}


		static public DistinctHorizonDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<DistinctHorizonDbl>.Instance;
			}
		}



	}
}
