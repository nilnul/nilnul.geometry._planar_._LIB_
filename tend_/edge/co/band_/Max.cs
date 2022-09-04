using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point;
using nilnul.geometry.planar.tend;
using nilnul.num;

namespace nilnul.geometry.planar.tend_.edge.co.band_
{
	static public class _MaxX
	{
		static public planar.tend_.EdgeI Max(planar.tend_.EdgeI x, planar.tend_.EdgeI y) {
			return
				x.Distance().ToReal() > y.Distance() ? x : y;
		}

		
		public static EdgeD Max(tend_.EdgeD x, tend_.EdgeD y)
		{
			return
				x.Distance() > y.Distance() ? x : y;

		}
	

	}
}
