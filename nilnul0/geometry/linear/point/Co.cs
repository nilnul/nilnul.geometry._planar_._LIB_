using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point
{
	public class Co : nilnul.obj.Co<linear.PointI>
	{
		public Co(Tuple<PointI, PointI> tuple) : base(tuple)
		{
		}

		public Co(PointI item1, PointI item2) : base(item1, item2)
		{
		}
	}
}
