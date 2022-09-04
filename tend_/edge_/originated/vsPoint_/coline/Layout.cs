using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.tend.vsPoint_.coline._layout;
using nilnul.num;

namespace nilnul.geometry.planar.tend_.edge_.originated.vsPoint_.coline
{
	static public class _ContainX
	{
		// Given three colinear points p, q, r, the function checks if
		// point q lies on line segment 'pr'
		 static public bool? _Contain(
			  PointI1 _end_nonnil, PointI1 _point_colinear
		)
		{

			return nilnul.geometry.linear.tend_.edge.vsPoint._LayoutX.Inside(
				new linear.tend_.edge_.Originated(planar.vect.co.to_.real_._DotProductX.RealI_Square(_end_nonnil))
				,
				new linear.Point(
					planar.vect.co.to_.real_._DotProductX.RealI(_point_colinear, _end_nonnil)
				)
			);

			
		}


	}


	
}
