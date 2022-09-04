using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lead.vsPoint_.nonincident.be_
{
	static public class _LeewayX
	{

	
		#region dbl

		static public bool LeewayTrue(planar.ILeadDbl lead,  Point4dbl x)
		{
			var angle =  geometry.planar.angle_.Points4dbl.OfPivotIniEnd(lead.arrow.begin, lead.arrow.end, x).angle;
			
			if (angle < Math.PI)
			{
				return true;

			}
			return false;
		}

		public static bool LeewayTrue(Point4dbl a, Point4dbl b, Point4dbl c)
		{
			return LeewayTrue(
				new planar.Lead4dbl(
					a,b
				)
				,
				c
			);
			
		}

		public static bool LeewayTrue(IRayDbl dirShoot, Point4dbl begin)
		{
			return LeewayTrue(
				new planar.lead_.OvRayDbl(dirShoot),begin
			);
		}

		#endregion
	}
}
