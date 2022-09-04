using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.facade.vsPoint.sign_
{
	/// <summary>
	/// ray casting,
	/// but when the ray intersects at the endpoint,
	///		winding number is computed as:
	///			if the edge points upwards, winding number increase
	///			otherwise, winding number decreases.
	///		thus:
	///			when the two edges are all underneath, the winding number is 0
	///			when both are pointing upwards, the winding number is 1
	///			when both pointing downards, the winding number is -1
	/// </summary>
	static public class _PointInsidePolygon
	{

		public static bool? IsInPolygon(
			this Point4dblI testPoint
			,
			planar.cycle_.gon_.Facade4dbl polygon
		)
		{
			return zone_.gon.vsPoint.has_.byRay_._StokesIfIntersected.IsInPolygon(
				testPoint
				,
				polygon
			);


		}

		public static bool? IsInPolygon(
			this Point4dbl testPoint
			,
			planar.zone_.Polygon4dbl polygon
		)
		{
			return IsInPolygon(
				(Point4dblI) testPoint
				,
				gon_.facade.of_.OfCycleByReverseIfNecessary.Singleton.of(
					(Polygon4dblI)polygon
				)
			);
		}

		public static bool? IsInPolygon(Facade4dbl outer, Point4dblI point4dblI)
		{
			return IsInPolygon(
				point4dblI, new zone_.Polygon4dbl_onPositiveCycle(outer)
			);
			//throw new NotImplementedException();
		}
	}
}
