using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.planar.tend.vsPoint_.be_.has_
{
	static public class _ByBoundingX
	{
		// Given three colinear points p, q, r, the function checks if
		// point q lies on line segment 'pr'
		static public bool Has(PointI1 begin, PointI1 end, PointI1 _point_colinear)
		{

			if (
				_point_colinear.x.ToReal() <= nilnul.num.real.op_.binary_.Max.Op(begin.x, end.x).ToReal()

				&&

				_point_colinear.x.ToReal() >= nilnul.num.real.op_.binary_.Min.Eval(begin.x, end.x).ToReal()

				&&
				_point_colinear.y.ToReal() <= nilnul.num.real.op_.binary_.Max.Op(begin.y, end.y).ToReal()

				&&

				_point_colinear.y.ToReal() >= nilnul.num.real.op_.binary_.Min.Eval(begin.y, end.y).ToReal()
			)
				return true;

			return false;
		}


	}


	
}
