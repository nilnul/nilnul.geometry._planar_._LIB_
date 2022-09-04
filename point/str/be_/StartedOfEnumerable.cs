using nilnul.geometry._2d.point;
using nilnul.geometry.planar._point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.pointD.str.be_
{
	public  class StartedOfEnumerable
		:nilnul.BeI<IEnumerable<PointD>>
	{
		
		public bool be(IEnumerable<PointD> points)
			
		{
			
			return nilnul.collection.enumerable.be.Positive<PointD>.Be(points);


		}

		public class En:
			nilnul.be.Asserted_assertDefaultDiscarded<IEnumerable<PointD>,StartedOfEnumerable>
			
			
		{
			public En(IEnumerable<PointD> points)
				:base(points)
			{

			}

		}

	}
}
