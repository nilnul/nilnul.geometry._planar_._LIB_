using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line0point.vsPoint
{
	static public class _Foot4perpendX
	{
		static public planar.Point4dbl Foot4perpend(
			planar.Point4dblI point,
			planar.Tend4dblI line0point
		) {

			return nilnul.geometry.planar.vect.op_.binary_._MinusX.Point(
				point
				,
				_LegX.Foot2point(
					point,line0point
				)
			);



		}

		public static planar.Point4dbl Foot4perpend(Point4dblI point, Grad4dbl_byPointsI grad)
		{
			return Foot4perpend(point, new planar.Tend4dbl(grad.basis,grad.finish));
		}
	}
}
