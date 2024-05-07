using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using P = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.trav_.polyseg_
{
	static public class _OrthogonalX
	{
		static public IEnumerable<Complex> Points(
			IEnumerable<double> steps
		) {

			return _orthic_.by_._Direction4currentX.Points(steps);
		}


	}
}
