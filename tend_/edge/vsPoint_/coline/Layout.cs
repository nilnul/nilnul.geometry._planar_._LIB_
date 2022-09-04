﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.tend.vsPoint_.coline._layout;
using nilnul.num;

namespace nilnul.geometry.planar.tend_.edge.vsPoint_.coline
{
	static public class _LayoutX
	{
		// Given three colinear points p, q, r, the function checks if
		// point q lies on line segment 'pr'
		 static public bool? _Categorize(
			 PointI1 begin, PointI1 end, PointI1 _point_colinear
		)
		{

			return planar.tend_.edge_.originated.vsPoint_.coline._ContainX._Contain(
				planar.point.co.band_.Minus.Singleton.combine(end, begin)
				,
				planar.point.co.band_.Minus.Singleton.combine(_point_colinear, begin)

			);

	
		}


	}


	
}