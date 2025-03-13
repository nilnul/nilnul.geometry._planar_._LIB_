using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.points_.dwelt
{
	static public class _CentroidX
	{
		static public C _Centroid_0dwelt(IEnumerable<C> complexes) {
			return nilnul.num.complex.str._AccumulateX.Sum(complexes) / complexes.Count();
		}
	}
}
