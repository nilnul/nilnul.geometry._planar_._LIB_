using nilnul.num;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_
{
	public class PositiveDbl :

		VectorDbl
		//,
		//nilnul.obj.Box_pub<nilnul.num.real_.Nonnil>
		,
		Vect4dblI

	{
		public PositiveDbl(num.dbl_.Positive val) : base(val.en)
		{
		}

	
		public PositiveDbl(PointDblI point1):this( new num.dbl_.Positive(point1.coord))
		{
		}

		public PositiveDbl(double x) : this( new num.dbl_.Positive(x))
		{
		}

		public PositiveDbl(PointDbl point) : base(point)
		{
		}




		//public PointI end => new linear.point_.Nonnil(this.boxed);
	}
}
