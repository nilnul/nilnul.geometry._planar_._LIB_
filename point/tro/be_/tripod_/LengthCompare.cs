using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.be_.tripod_
{
	static public class LengthCompare
	{
		static  public bool Be(
	Point4dbl a,
	Point4dbl b,
	Point4dbl c

)
		{
			var ab = nilnul.geometry.planar.tend._DistanceX.Distance(a, b);
			var ac = nilnul.geometry.planar.tend._DistanceX.Distance(a, c);
			var bc = nilnul.geometry.planar.tend._DistanceX.Distance(b, c);

			var set = new List<double>() { ab, ac, bc };


			var max = nilnul.num.real.set.op.Max.Index(set);

			set.RemoveAt(max);

			return nilnul.num.real.set.op.SumX.Sum(set) > max;


		}

	}
}
