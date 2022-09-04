using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.step_.nonhorizon.azimuth
{
	static public class _CtgX
	{
		static public double _Ctg_assumeNonhorizon(
			 planar.grad_.Skid4dblI _nonhorizon
		) {
			
			return  (_nonhorizon.finish.x - _nonhorizon.basis.x)/ (_nonhorizon.finish.y - _nonhorizon.basis.y)
				
				
			;


		}

		internal static double _Ctg_assumeNonhorizon(Grad4dbl_byPointsI _nonhorizon)
		{
			return  (_nonhorizon.finish.x - _nonhorizon.basis.x)/ (_nonhorizon.finish.y - _nonhorizon.basis.y)
				
				
			;

		}
	}
}
