using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point
{
	public class TwinDbl :
		nilnul.obj.Twin<linear.PointDblI>
	{
		public TwinDbl(Tuple<PointDblI, PointDblI> tuple) : base(tuple)
		{
		}

		public TwinDbl(PointDblI item1, PointDblI item2) : base(item1, item2)
		{
		}
	}
}
