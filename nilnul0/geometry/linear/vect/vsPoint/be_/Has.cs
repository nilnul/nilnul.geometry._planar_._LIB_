using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect.vsPoint.be_
{
	static public class _HasX
	{
		static public bool Has(linear.VectI vector, linear.PointI point) {
			return linear.vect.re_._IncludeX.Be(
				vector, new linear.Vector(point)
			);
		}

		static public bool Has(linear.Vect4dblI vector, linear.PointDblI point) {
			return linear.vect.re_._IncludeX.Be(
				vector, new linear.VectorDbl(point)
			);
		}

		static public bool Has(nilnul.num.RealI vector, nilnul.num.RealI point) {
			return Has(new linear.Vector(vector), new linear.Point(point) );
		}

	}
}
