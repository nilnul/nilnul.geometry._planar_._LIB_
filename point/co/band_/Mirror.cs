using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.band_
{
	static public class _MirrorX
	{
		static public Point4dbl Mirror(this Point4dbl pivot, Point4dbl src) {
			return 2*pivot   - src; // pivot + ( pivot-src  );
		}
		
	}
}
