using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_
{
	///en.wikipedia.org/wiki/Rose_(mathematics)
	///<summary>
	///
	/// 
	/// </summary>
	/// alias:
	///		rose
    class IRhodonea
    {
		int k;
		double a;
		public C locus(double t) {
			return C.FromPolarCoordinates(
				a*Math.Cos(k*t)
				,
				t
			);
		}
    }
}
