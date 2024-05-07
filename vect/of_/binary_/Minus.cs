//using nilnul.geometry.planar._bloc;
using nilnul.geometry.planar.vect_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.op_.binary_
{
	static public class _MinusX
	{
		public static VectorDbl Op(Vector4dblI origin, Vector4dblI vector)
		{
			return new VectorDbl(
				origin.point.x - vector.point.x
				,
				origin.point.y -vector.point.y
			);


		}


		public static Point4dbl Point(Point4dblI origin, Point4dblI vector)
		{
			return new Point4dbl(
				origin.x - vector.x
				,
				origin.y- vector.y
			);

		}
		public static Point4dbl Point(Point4dblI point, Vect4dblI vect4dblI)
		{
			return Point(point, vect4dblI.point);
		}

		public static Point4dbl Point(Point4dblI point, Polar4dbl_radius1st polar4dbl_radius1st)
		{
			return Point(
				point,
				polar4dbl_radius1st.point
			);
		}

		public static Vect4dbl Op(Vect4dblI v, Vect4dblI b)
		{
			return new Vect4dbl(
				Point(v.point,b.point)
			);

			return new Vect4dbl(
				v.point.x-b.point.x
				,
				v.point.y-b.point.y
			);
		}

		public static Vect4dbl Op(Point4dblI point, Point4dblI begin)
		{

			return new Vect4dbl(point.x -begin.x, point.y-begin.y);
		}
		public static Vect4dbl Op(Point4dblI v, Polar4dbl_radius1st b)
		{
			return Op(
				v,b.point

			);

		}

		public static Vect4dbl Op(Vect4dblI v, Polar4dbl_radius1st b)
		{
			return Op(v.point, b);

		}

	}
}
