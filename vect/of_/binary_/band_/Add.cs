using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.co.band_
{
	static public class _AddX
	{
		static public planar.Point1 Point(planar.PointI1 point, planar.IVector vector)
		{
			return new planar.Point1(
				point.x + vector.point.x
				,
				point.y + vector.point.y
			);
		}

		static public planar.Point4dbl PointDbl(planar.Point4dblI point, planar.Vector4dblI vector)
		{
			return new planar.Point4dbl(
				point.x + vector.point.x
				,
				point.y + vector.point.y
			);
		}

		static public planar.Point4dbl PointDbl(planar.Point4dbl point, planar.Vector4dblI vector)
		{
			return new planar.Point4dbl(
				point.x + vector.point.x
				,
				point.y + vector.point.y
			);
		}

	}
}
