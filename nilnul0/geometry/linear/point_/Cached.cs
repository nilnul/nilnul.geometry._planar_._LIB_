using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.linear.point_
{
	public class Cached : nilnul.obj.Box<Point>
	{

		public nilnul.num.Real coord
		{
			get { return boxed.x.ToReal(); }
		}


		public Cached(Point val) : base(val)
		{
		}

	}
}
