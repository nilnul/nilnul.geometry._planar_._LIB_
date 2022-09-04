using nilnul.geometry.linear.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.tend_
{
	public class Edge : Span
	{
		public Edge(linear.point.twin.be_.dif.vow.Ee ee) : base(ee.ee)
		{
		}
		public Edge(linear.point.Twin ee) : this(new point.twin.be_.dif.vow.Ee(ee))
		{
		}


		public Edge(Co ee) : this(new linear.point.Twin(ee))
		{
		}

		public Edge(Point item1, Point item2) : this(new point.Twin( item1, item2))
		{
		}
	}
}
