using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend.co.band_
{
	static public class _MinX
	{
		static public planar.TendI Min(planar.TendI x, planar.TendI y) {
			return x.Distance().ToReal() < y.Distance() ? x : y;
		}

		internal static point.Co Min(point.Co x, point.Co y)
		{
			return x.Distance().ToReal() < y.Distance() ? x : y;

		}
	}
}
