using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.op_.unary_
{
	/// <summary>
	/// move horizontally 
	/// </summary>
	static public class _ShiftX
	{
		static public PointF Shift(this PointF point, float shift) {
			return new PointF(point.X+shift, point.Y);
		}
		static public Point4dbl Shift(this Point4dbl point, double shift) {
			return new Point4dbl(point.x+shift, point.y);
		}

		static public Point4dbl Shift(this Point4dblI point, double shift) {
			return new Point4dbl(point.x+shift, point.y);
		}

	}
}
