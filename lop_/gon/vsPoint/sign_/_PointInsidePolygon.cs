using nilnul.geometry.planar.cycle_;
using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lop_.gon.vsPoint.sign_
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
	/// <see cref="cycle_.gon.vsPoint.sign_._PointInsidePolygonX"/>
	static public class _PointInsidePolygonX
	{

		public static bool? IsInsidePolygon(
			this Point4dblI testPoint
			,
			planar.cycle_.Polygon4dblI polygon
		)
		{
			return cycle_.gon_.facade.vsPoint.sign_._PointInsidePolygon.IsInPolygon(
				testPoint
				,
				cycle_.gon_.facade.of_.OfCycleByReverseIfNecessary.Singleton.of(polygon)
			);

		}

		public static bool? IsInsidePolygon(
			this Point4dbl testPoint
			,
			planar.zone_.Polygon4dbl polygon
		)
		{
			return IsInsidePolygon(
				(Point4dblI) testPoint
				,
				(Polygon4dblI)polygon
			);
		}

		public static bool? IsInsidePolygon(Facade4dbl outer, Point4dblI point4dblI)
		{
			return IsInsidePolygon(
				point4dblI, new zone_.Polygon4dbl_onPositiveCycle(outer)
			);
			//throw new NotImplementedException();
		}
	}
}
