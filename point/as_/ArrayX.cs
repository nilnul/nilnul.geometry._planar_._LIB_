using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.as_
{
	static public class _ArrayX
	{
		static public double[] AsArray(this Point4dblI point) {
			return new[] { point.x,point.y};
		}
	}
}
