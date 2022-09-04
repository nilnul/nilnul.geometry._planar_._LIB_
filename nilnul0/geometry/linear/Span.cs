using nilnul.geometry.linear.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear
{
	/// <summary>
	/// when applying equalityComparer, the order of the points are unimportant
	/// </summary>
	///
	//[Obsolete(nameof(linear.SpanDbl))]
	public class Span : point.Twin
	{
		public Span(Tuple<Point, Point> tuple) : base(tuple.Item1,tuple.Item2)
		{
		}

		public Span(Co ee):base(ee.component,ee.component1 )
		{
		}

		public Span(Twin ee):base(ee.component,ee.component1)
		{
		}

		public Span(Point item1, Point item2) : base(item1, item2)
		{
		}
	}
}
