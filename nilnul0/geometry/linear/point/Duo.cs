using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point
{
	public class Duo : nilnul.obj.Duo<Point>
	{
		public Duo(Tuple<Point, Point> tuple) : base(tuple)
		{
		}

		public Duo(Point item1, Point item2) : base(item1, item2)
		{
		}
	}
}
