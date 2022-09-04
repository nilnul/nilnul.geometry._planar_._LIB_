using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lead.vsPoint
{
	static public class _Foot4perpendX
	{
		static public Point4dblI Foot4perpend(
			planar.Point4dblI point
			,
			planar.Lead4dbl lead
		) {

			return  (point - _LegX.Foot2point(point,lead) ).point;


		}

	

	}
}
