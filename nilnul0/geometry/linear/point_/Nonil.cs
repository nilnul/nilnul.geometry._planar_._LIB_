using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.geometry.linear.point_
{
	public class Nonnil :
		nilnul.obj.Box<nilnul.num.real_.NonnilI>
		,
		linear.PointI

	{
		public Nonnil(NonnilI val) : base(val)
		{
		}

		public RealI x => boxed;
	}
}
