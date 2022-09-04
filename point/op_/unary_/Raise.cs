using nilnul.num.real_;
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
	static public class _RaiseX
	{
		static public PointF Raise(this PointF point, float shift) {
			return new PointF(point.X, point.Y+shift);
		}

		static public Point4dbl Raise(this Point4dblI point, double shift) {
			return new Point4dbl(point.x, point.y+shift);
		}

		public static Point4dbl Raise(Point4dblI point, NonnegOfDoubleI edge)
		{
			return Raise(point, edge.realee);
			//throw new NotImplementedException();
		}

		public static PointF Raise(PointF point, Nonneg4floatI edge)
		{
			return Raise(point, edge.realee);
		}
	}
}
