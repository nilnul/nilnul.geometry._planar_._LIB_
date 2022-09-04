using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend
{
	static public class _MidX
	{
		static public Point4dbl Mid(planar.Point4dbl a, planar.Point4dbl b) {
			return (a + b) / 2;
		}
		static public Point4dbl Mid(this planar.Tend4dbl span) {
			return (
				vect.op_.binary_._AddX.Point(
				span.component , span.component1
				)
			) / 2;
		}

		static public Point4dbl Mid(this planar.Grad4dblI span) {
			return span.Mid() ;
		}

		public static Point Mid(Point p1, Point p2)
		{
			return new Point( (p1.X+p2.X )/2
				,
				(p1.Y+p2.Y)/2
				);
			//throw new NotImplementedException();
		}
	}
}
