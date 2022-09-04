using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.grad_.skid.vsPoint_.colinear.be_
{
	static public class _HasX
	{
		public static bool _Has_assumeSkid_assumeColinear(Grad4dbl_byPointsI x, Point4dblI y)
		{
			return  planar.vect_.nonnil.vsPoint_.coline.be_._VectorHasPointX._Has_assumeNonnil_assumeColine(
				planar.grad._DisplaceX.Vect(x)
				,
				y 
			);


		}
		static public bool _ofColinear(
			planar.grad_.Skid4dblI segment
			,
			planar.Point4dblI _point_colinear
		) {

			return  planar.vect_.nonnil.vsPoint_.coline.be_._VectorHasPointX._Has_assumeNonnil_assumeColine(
				planar.grad._DisplaceX.Vect(segment)
				,
				_point_colinear 
			);
		}


	}
}
