//using nilnul.geometry.planar._bloc;
using nilnul.geometry.planar.vect_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.op_.binary_
{
	/// <summary>
	/// using complex number multiply.
	/// </summary>
	static public class _MultiX
	{
		public static VectorDbl Op(Vector4dblI origin, Vector4dblI vector)
		{
			return new VectorDbl(
				origin.point.x * vector.point.x
				-
				origin.point.y*vector.point.y
				,
				origin.point.x *vector.point.y
				+
				origin.point.y *vector.point.x
			);


		}

		public static Vect4dbl Op(Vect4dblI origin, Vect4dblI vector)
		{
			return new Vect4dbl(
				origin.point.x * vector.point.x
				-
				origin.point.y*vector.point.y
				,
				origin.point.x *vector.point.y
				+
				origin.point.y *vector.point.x
			);


		}

		public static Vect4dbl Op(Vect4dbl origin, Vect4dbl vector)
		{
			return Op(
				(Vect4dblI)origin
				,
				(Vect4dblI)vector
			);


		}
	

	

		public static Point4dblI Point(Point4dblI origin, Point4dblI vector)
		{
			return _MultiX.Op(
				new Vect4dbl(origin)
				,
				new Vect4dbl(vector)
				
			).point;

		}

	

	}
}
