using nilnul.geometry.linear.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear
{
	[Obsolete()]
	public class Grad : point.Duo
	{
		public Grad(Tuple<Point, Point> tuple) : base(tuple)
		{
		}

		

		public Grad(Point item1, Point item2) : base(item1, item2)
		{
		}
	}
}
