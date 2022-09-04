using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.points.be_
{
	public  class StartedDbl
		:
		BeI
	{
		public bool be(IEnumerable<Point4dbl> points)
			
		{
			
			return points.Any();


		}

		static public StartedDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<StartedDbl>.Instance;
			}
		}



	}
}
