using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.horizon
{
	static public class TranslateX
	{
		static public PointF Shift(float x, PointF point) {
			return new PointF(
				point.X+x
				,
				point.Y
			);
		}
		static public Point4dbl Shift(double x, Point4dbl point) {
			return new Point4dbl(
				point.x+x
				,
				point.y
			);
		}


	}
}
