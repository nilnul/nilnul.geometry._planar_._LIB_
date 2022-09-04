using nilnul.num;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_
{
	public class Nonneg :

		Vector
		//,
		//nilnul.obj.Box_pub<nilnul.num.real_.Nonnil>
		,
		VectI

	{
		public Nonneg(num.real_.NonnegI val) : base(val)
		{
		}

		public Nonneg(Point point1):this( new num.real_.Nonneg(point1.coord))
		{
		}

		public Nonneg(RealI x) : this( new num.real_.Nonneg(x))
		{
		}




		//public PointI end => new linear.point_.Nonnil(this.boxed);
	}
}
