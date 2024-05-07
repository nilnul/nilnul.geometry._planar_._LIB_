using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point
{
	static public class _ExtensionsX
	{
		static public linear.PointDbl ToImpl(this PointDblI point) {
			return point switch
			{
				PointDbl x => x
				,
				_ => new PointDbl(point.coord)
			};
		}
	}
}
