using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line_.originated_.byAlign.vsPoint
{
	static public class _Foot4perpendX
	{
		static public Point4dblI Foot4perpend(
			double  lineAlignmentUnnormalized
			,
			planar.Point4dblI point
		) {

			return (point - _Leg4perpendX.Foot2point(lineAlignmentUnnormalized,point) ).point;


		}

	

	}
}
