using nilnul.geometry.linear.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Drawying;

namespace nilnul.geometry.linear
{
	public class Tend4dbl
		:
		point.TwinDbl
		//,
		//IBar
		,
		ITend
	{
		public Tend4dbl(Tuple<PointDbl, PointDbl> tuple) : base(tuple.Item1,tuple.Item2)
		{
		}

		public Tend4dbl(CoDbl ee):base(ee.component,ee.component1 )
		{
		}

		public Tend4dbl(TwinDbl ee):base(ee.component,ee.component1)
		{
		}

		public Tend4dbl(PointDblI item1, PointDblI item2) : base(item1, item2)
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
}
