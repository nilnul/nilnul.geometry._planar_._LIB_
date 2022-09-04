using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.planar.grad.point_.colinear.categorize_
{
	
	static public class _InsideX
	{
		
		 static public nilnul.geometry.linear.vect.co.categorize_._inside.Category _Categorize(Point1 begin, Point1 end, Point1 _point_colinear)
		{

			var axis = new nilnul.geometry.planar.vect.as_.Base(end - begin);

			return nilnul.geometry.linear.vect.co.categorize_._InsideX.Inside(
				axis.opOfSelf()
				,
				axis.op(_point_colinear - begin)
			);
			
		}

		 static public nilnul.geometry.linear.vect.co.categorize_._inside.Category _Categorize(Grad grad, Point1 _point_colinear)
		{

			

			return nilnul.geometry.planar.vect.duo_.linear.categorize_._InsideX._Categorize(
				grad.begin ,grad.end, _point_colinear
			);
			
		}




	}


	
}
