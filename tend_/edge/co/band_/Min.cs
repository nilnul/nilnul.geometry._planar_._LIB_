using nilnul.geometry.planar.tend;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend_.edge.co.band_
{
	static public class _MinX
	{
		static public planar.tend_.EdgeI Min(planar.tend_.EdgeI x, planar.tend_.EdgeI y) {
			return x.Distance().ToReal() <= y.Distance().ToReal() ? x : y;
		}

		internal static tend_.EdgeD Min(planar.tend_.EdgeD x, planar.tend_.EdgeD y)
		{
			return x.Distance() <= y.Distance() ? x : y;

		}
	}
}
