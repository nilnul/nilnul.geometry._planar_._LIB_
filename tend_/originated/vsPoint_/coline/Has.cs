using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend_.originated.vsPoint_.coline
{
	static public class _ContainX
	{
		static public bool? Contain(
			 PointI1 end, PointI1 _point_colinear
	   )
		{
			return nilnul.geometry.linear.span.vsPoint._LayoutX.Inside(
				new linear.tend_.edge_.Originated(
					planar.vect.co.to_.real_._DotProductX.RealI_Square(end)
				)
				,
				new linear.Point(
					planar.vect.co.to_.real_._DotProductX.RealI(_point_colinear, end)
				)
			);
		}
	}
}
