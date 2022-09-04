using nilnul.num;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_
{
	public class Nonnil :

		Vector
		//,
		//nilnul.obj.Box_pub<nilnul.num.real_.Nonnil>
		,
		VectI

	{
		public Nonnil(num.real_.Nonnil val) : base(val)
		{
		}

		public Nonnil(Point point1):this( new num.real_.Nonnil(point1.coord))
		{
		}

		public Nonnil(RealI x) : this( new num.real_.Nonnil(x))
		{
		}




		//public PointI end => new linear.point_.Nonnil(this.boxed);
	}
}
