using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line_.horizon.vsGrad_.slid_.cross
{
	static public class _IntersectedX
	{
		static public double _Eks_gradAssumeStep1cross(
			double heightOfLine
			,
			planar.Grad4dbl_byPointsI _cross_notAlign
		) {
			

			return _cross_notAlign.basis.x
				+
				(heightOfLine - _cross_notAlign.basis.y)
				*
				grad_.step_.nonhorizon.azimuth._CtgX._Ctg_assumeNonhorizon(_cross_notAlign);
				
			;

		}

		static public double _Eks_gradAssumeCross(
			double heightOfLine
			,
			planar.grad_.Skid4dblI _cross_notAlign
		) {
			

			return _cross_notAlign.basis.x
				+
				(heightOfLine - _cross_notAlign.basis.y)
				*
				grad_.step_.nonhorizon.azimuth._CtgX._Ctg_assumeNonhorizon(_cross_notAlign);
				
			;

		}


	}
}
