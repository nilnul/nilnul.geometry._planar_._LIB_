using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.grad_.skid.vsPoint_.colinear
{
	static public class _LayoutX
	{
		static public linear.vect_.positive.vsPoint._layout.Category _ofColinear(planar.grad_.IArrow segment, planar.Point1 _point_colinear) {
			return  planar.vect_.nonnil.vsPoint_.coline._LayoutX._ofColine(

				segment.points.ee.end-segment.points.ee.begin
				,
				_point_colinear - segment.points.ee.begin
			);
		}

		public static linear.vect_.positive.vsPoint._layout.Category _ofColinear(
			Arrow arrow, Point1 intersectedPoint)
		{
			return _ofColinear(
				(grad_.IArrow)arrow
				,
				intersectedPoint
			);
		}

		static public linear.vect_.positive.vsPoint._layout.Category _ofColinear(planar.grad_.skid_.ByPoints4Dbl segment, planar.Point4dbl _point_colinear) {
			return  planar.vect_.nonnil.vsPoint_.coline._LayoutX._ofColine(
				vect.op_.binary_._MinusX.Point(

				segment.ee.component1,segment.ee.component
				)
				,
				vect.op_.binary_._MinusX.Point(

				_point_colinear , segment.ee.component
				)
			);
		}

	}
}
