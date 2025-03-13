using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.co.band_
{
	static public class _MinusX
	{
		static public planar.Point1 Point(IVector point, planar.IVector vector)
		{
			return point.point - vector.point;
			//return new planar.Point1(
			//	point.point.x - vector.point.x
			//	,
			//	point.point.y - vector.point.y
			//);
		}
		static public planar.Vector1 Vector(IVector point, planar.IVector vector)
		{
			return new Vector1(Point(point,vector));
			//return new planar.Point1(
			//	point.point.x - vector.point.x
			//	,
			//	point.point.y - vector.point.y
			//);
		}


	}
}
