using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.co
{
	static public class _CrossProductX
	{
		static public nilnul.num.RealI CrossProduct(
			nilnul.geometry.planar.PointI1 a
			,
			nilnul.geometry.planar.PointI1 b
			,
			nilnul.geometry.planar.PointI1 c
			,
			nilnul.geometry.planar.PointI1 d

		) {

			return planar.vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram(
				new Point1(b)-a
				,
				new Point1(d)-c

			);

		}

		public static double CrossProduct(Point4dbl a, Point4dbl b, Point4dbl c, Point4dbl d)
		{
			return planar.vect.co.to_.real_._CrossProductX.SurroundedOfParallelogram(
				(b)-a
				,
				(d)-c

			);

		}
	}
}
