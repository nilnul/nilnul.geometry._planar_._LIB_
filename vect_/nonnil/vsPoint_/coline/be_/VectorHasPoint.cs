using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil.vsPoint_.coline.be_
{
	static public class _VectorHasPointX
	{
		static public bool _ofColine(
			planar.vect_.NonnilI vector
			,
			planar.Point1 p_coline
		){

			return planar.vect.vsPoint_.coline.be_._VectorHasPointX._ofColine(vector, p_coline);
		}

		public static bool _Has_assumeNonnil_assumeColine(Vect4dbl vect4dbl, Point4dblI point_colinear)
		{
			return planar.vect.vsPoint_.coline.be_._VectorHasPointX._AssumeColine(
				vect4dbl, point_colinear
			);

		}

		static public bool _ofColine(
			planar.vect_.Nonnil4dblI vector
			,
			planar.Point4dblI p_coline
		){

			return planar.vect.vsPoint_.coline.be_._VectorHasPointX._AssumeColine(vector, p_coline);
		}


		public static bool _ofColine(Point1 vector, Point1 point)
		{
			return _ofColine(
				new planar.vect_.Nonnil(vector)
				,
				point
			);
		}
	}
}
