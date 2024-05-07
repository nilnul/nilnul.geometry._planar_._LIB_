//using nilnul.geometry.planar._bloc;
using nilnul.geometry.planar.tope_._bloc.size_;
using nilnul.geometry.planar.vect_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.op_.binary_
{
	static public class _AddX
	{
		public static VectorDbl Op(Vector4dblI origin, Vector4dblI vector)
		{
			return new VectorDbl(
				origin.point.x + vector.point.x
				,
				origin.point.y + vector.point.y
			);


		}

		public static Vect4dbl Op(Vect4dblI origin, Vect4dblI vector)
		{
			return new Vect4dbl(
				origin.point.x + vector.point.x
				,
				origin.point.y + vector.point.y
			);

		}

		public static Point4dbl Op(Point4dbl origin, Vector4dblI vector)
		{
			return new Point4dbl(
				origin.x + vector.point.x
				,
				origin.y + vector.point.y
			);

		}

		public static Point4dbl Point(Point4dblI origin, Vect4dblI vector)
		{
			return new Point4dbl(
				origin.x + vector.point.x
				,
				origin.y + vector.point.y
			);

		}

		public static Point4dbl Point(Point4dblI origin, Vector4dblI vector)
		{
			return new Point4dbl(
				origin.x + vector.point.x
				,
				origin.y + vector.point.y
			);

		}

		public static Point4dbl Point(Point4dblI origin, Point4dblI vector)
		{
			return new Point4dbl(
				origin.x + vector.x
				,
				origin.y + vector.y
			);

		}

		static public Point4dbl Op(Point4dbl origin, VectorDbl vector)
		{
			return new Point4dbl(
				origin.x + vector.boxed.x
				,
				origin.y + vector.boxed.y
			);
		}

		public static Point4dbl Op(Point4dbl point, planar.tope_._bloc. SpreadDbl size1)
		{
			return Op(point, size1.toVector());
		}

		public static Point4dbl Op(Point4dbl point, NonnegDbl nonnegDbl)
		{
			return Op(point, nonnegDbl.ee);
		}

		public static Point4dbl Point(Point4dblI point, double ee1, double ee2)
		{
			return new Point4dbl(point.x +ee1, point.y+ee2);
		}

		public static PointF Point(PointF point, float ee1, float ee2)
		{
			return new  PointF(point.X +ee1, point.Y+ee2);

			//throw new NotImplementedException();
		}

		public static Point4dbl Op(Point4dbl point, Spanned4dbl size)
		{
			return new Point4dbl(
				point.x + size.width.dblen
				,
				point.y+size.height.dblen
			);
		}
	}
}
