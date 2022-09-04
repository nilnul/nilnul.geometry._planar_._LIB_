using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid
{
	static public class _VectorX
	{
		public static planar.Vector1 Vector(planar.Point1 a, planar.Point1 b)
		{
			return new planar.Vector1(
				b - a
			);
		}
		public static Point1 Vector(IArrow stop)
		{
			return Vector(
				stop.points.ee.begin
				,
				stop.points.ee.end
			);

		}

		public static planar.Vector1 Vector(Arrow stop)
		{
			return Vector(
				stop.start
				,
				stop.stop
			);
		}
		static public planar.vect_.Nonnil NonnilVector(planar.Point1 a, planar.Point1 b)
		{
			return new vect_.Nonnil(Vector(a, b));
		}

		static public planar.vect_.Nonnil NonnilVector(Arrow stop)
		{
			return new vect_.Nonnil(Vector(stop));
		}


		public static planar.VectorDbl Vector(planar.Point4dbl a, planar.Point4dbl b)
		{
			return new planar.VectorDbl(
				b - a
			);
		}



		public static planar.VectorDbl Vector(this grad_.skid_.ByPoints4Dbl stop)
		{
			return grad_._StepX.Vect(
				stop.begin
				,
				stop.end
			);

		}

	}
}
