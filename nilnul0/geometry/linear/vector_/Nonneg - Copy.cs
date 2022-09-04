using nilnul.num;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_
{
	public class NonnegDbl :

		VectorDbl
		//,
		//nilnul.obj.Box_pub<nilnul.num.real_.Nonnil>
		,
		Vect4dblI

	{
		public NonnegDbl(num.real_.NonnegOfDoubleI val) : base(val.realee)
		{
		}

		public NonnegDbl(num.real_.NonnegOfDouble val) : base(val.realee)
		{
		}

		public NonnegDbl(PointDblI point1):this( new num.real_.NonnegOfDouble(point1.coord))
		{
		}

		public NonnegDbl(double x) : this( new num.real_.NonnegOfDouble(x))
		{
		}




		//public PointI end => new linear.point_.Nonnil(this.boxed);
	}
}
