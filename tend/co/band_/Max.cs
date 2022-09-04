using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point;
using nilnul.geometry.planar.tend;
using nilnul.num;

namespace nilnul.geometry.planar.tend.co.band_
{
	static public class _MaxX
	{
		static public planar.TendI Max(planar.TendI x, planar.TendI y) {
			return
				x.Distance().ToReal() > y.Distance() ? x : y;
		}

		public static CoD Max(CoD x, CoD y)
		{
			return
				x.Distance() > y.Distance() ? x : y;


		}
		public static Tend4dblI Max(Tend4dblI x, Tend4dblI y)
		{
			return
				x.Distance() > y.Distance() ? x : y;

		}
		public static Tend4dbl Max(Tend4dbl x, Tend4dbl y)
		{
			return
				x.Distance() > y.Distance() ? x : y;


		}

	}
}
