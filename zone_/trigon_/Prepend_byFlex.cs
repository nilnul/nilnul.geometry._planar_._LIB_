using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon_
{

	public class Perpend_byFlexQuarterDbl
		:
		cycle_.trigon_.Perpend_byFlexQuarterDbl
	{
		public Perpend_byFlexQuarterDbl(TrioD val) : base(val)
		{

		}

		public Perpend_byFlexQuarterDbl(IEnumerable<Point4dbl> points):this(new TrioD(points))
		{
		}
		public Perpend_byFlexQuarterDbl(IEnumerable<Point4dblI> points):this(new TrioD(points))
		{
		}

	}
}
