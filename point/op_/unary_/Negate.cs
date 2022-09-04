using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.op_
{
	/// <summary>
	/// move horizontally 
	/// </summary>
	static public class _Negate
	{
		static public PointF Negate(this PointF point) {
			return new PointF(-point.X, -point.Y);
		}
		static public Point4dbl Negate(this Point4dbl point) {
			return new Point4dbl(-point.x, -point.y);
		}

		static public Point4dbl Negate(this Point4dblI point) {
			return new Point4dbl(-point.x, -point.y);
		}

	}
}
