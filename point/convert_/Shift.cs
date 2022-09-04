using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.convert_
{
	static public class _ShiftX
	{
		static public planar.Point4dblI Shift(this planar.Point4dbl x, planar.Vector4dblI vector) {
			return point.co.band_.AddDbl.Singleton.combine(x, vector.point);
		}

		static public planar.PointI1 Shift(this planar.PointI1 x, planar.IVector vector) {
			return point.co.band_.Add.Singleton.combine(x, vector.point);
		}
	}
}
