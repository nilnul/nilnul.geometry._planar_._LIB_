using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.planar.grad.vsPoint_.colinear.categorize_
{
	
	static public class _Inside4dblX
	{
		
		 static public nilnul.geometry.linear.vect.co.categorize_._inside.Category _Categorize(
			 Point4dblI begin,
			 Point4dblI end,
			 Point4dblI _point_colinear
			)
		{

			var axis =  nilnul.geometry.planar.grad._DisplaceX.Vect( begin,end);

			var axisMapped = planar.vect.co.to_.real_._DotProductX.Square(
				axis

			);

			var apex = nilnul.geometry.planar.grad._DisplaceX.Vect(_point_colinear, end);

			var apexMapped =planar.vect.co.to_.real_._DotProductX.Dbl(
				axis
				,apex

			);



			return nilnul.geometry.linear.vect.co.categorize_._Inside4dblX.Inside(
				axisMapped
				,
				apexMapped
			);
			
		}

		 static public nilnul.geometry.linear.vect.co.categorize_._inside.Category _Categorize(Grad4dbl_byPointsI grad, Point4dblI _point_colinear)
		{

			

			return _Categorize(
				grad.basis,grad.finish, _point_colinear
			);
			
		}




	}


	
}
