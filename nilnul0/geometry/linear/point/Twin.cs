using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point
{
	public class Twin :
		nilnul.obj.Twin<linear.PointI>
	{
		public Twin(Tuple<PointI, PointI> tuple) : base(tuple)
		{
		}

		public Twin(PointI item1, PointI item2) : base(item1, item2)
		{
		}
	}
}
