using nilnul.geometry.linear.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear
{
	/// <summary>
	/// vector anchored to a parameterized point.
	/// </summary>
	public class Grad1 : point.Co
	{
		public Grad1(Tuple<Point, Point> tuple) : base(tuple.Item1,tuple.Item2)
		{
		}

		public Grad1(Co ee):base(ee.component,ee.component1 )
		{
		}

		public Grad1(Point item1, Point item2) : base(item1, item2)
		{
		}
	}
}
