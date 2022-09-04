using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line_.originated_.byAlign.vsPoint
{
	static public class _Leg4perpendX
	{
		static public vect_.Polar4dbl_radius1st Foot2point(
			double  lineAlignmentUnnormalized
			,
			planar.Point4dblI point
		) {

			return planar.vect.to_.co_.decompose._RejectionX.Rejection(
				point
				,
				lineAlignmentUnnormalized

			);


		}

		

	}
}
