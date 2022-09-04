using nilnul.geometry.linear.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear
{
	public class GradDbl : point.CoDbl
	{
		public GradDbl(Tuple<PointDblI, PointDblI> tuple) : base(tuple)
		{
		}

		public GradDbl((PointDblI, PointDblI) p):base(p)
		{
		}

		public GradDbl(PointDblI item1, PointDblI item2) : base(item1, item2)
		{
		}

		public GradDbl(double tgtStart, double tgtEnd):this(
			new PointDbl(tgtStart) ,new PointDbl(tgtEnd)
		)
		{
		}

		public  num.real.bound_.ClosedDbl toSpanAsBound() {
			return linear.SpanDbl.ToBound(
				this.component.coord,this.component1.coord
			);
		}

		public double distance { get {
				return Math.Abs(this.component.coord - this.component1.coord);
			}
		}

		public bool has(double point) {
			return this.toSpanAsBound().has(point);
		}
	}
}
