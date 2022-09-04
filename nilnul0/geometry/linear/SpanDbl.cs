using nilnul.geometry.linear.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Drawying;

namespace nilnul.geometry.linear
{
	[Obsolete(nameof(Tend4dbl))]
	public class SpanDbl
		:
		point.TwinDbl
		//,
		//IBar
	{
		public SpanDbl(Tuple<PointDbl, PointDbl> tuple) : base(tuple.Item1,tuple.Item2)
		{
		}

		public SpanDbl(CoDbl ee):base(ee.component,ee.component1 )
		{
		}

		public SpanDbl(TwinDbl ee):base(ee.component,ee.component1)
		{
		}

		public SpanDbl(PointDblI item1, PointDblI item2) : base(item1, item2)
		{
		}

		public num.real.bound_.ClosedDbl toBound()
		{

			if (this.component.coord<=this.component1.coord)
			{
				return new num.real.bound_.ClosedDbl(this.component.coord, this.component1.coord);

			}

				return new num.real.bound_.ClosedDbl(this.component1.coord, this.component.coord);

		}

		static public num.real.bound_.ClosedDbl ToBound(double x, double y)
		{

			if (x<=y)
			{
				return new num.real.bound_.ClosedDbl(x,y);

			}

				return new num.real.bound_.ClosedDbl(y,x);

		}


		


	}

	[Obsolete(nameof(Tend4dblX))]
	static public class SpanDblX
	{
		static public (PointDblI, PointDblI) Order(this SpanDbl span) {
			return span.component.ToClass() <= span.component1 ? (span.component, span.component1) : (span.component1,span.component);
		}

	}
}
