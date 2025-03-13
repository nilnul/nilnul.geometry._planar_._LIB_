using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lop_._ellipse_.by_
{
	class _AlgebraX
	{
		/// <summary>
		/// a x^2 + b xy + c y^2 +d x + e y + f =0
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <param name="e"></param>
		/// <param name="f"></param>
		/// <returns>
		/// a x^2 + c y^2 +d x + e y + f =0
		/// , and a tilt angle;
		///
		/// </returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>

		static public (double a1, double c1, double d1, double e1, double f1, double tilt) Algebra(
			double a
			, double b
			, double c
			,
			double d
			,
			double e
			,
			double f

		)
		{
			///math.stackexchange.com/questions/280937/finding-the-angle-of-rotation-of-an-ellipse-from-its-general-equation-and-the-ot

			if (4 * a * c <= b * b)
			{
				throw new ArgumentOutOfRangeException($"4ac >b*b must hold for it to be a nontrivia ellipse.");

			}

			if (b != 0) // it's rotated
			{
				var tilt = Math.Atan2(b, a - c) / 2;

				var cos = Math.Cos(tilt);
				var sin = Math.Sin(tilt);

				double cosSq = nilnul.num.real.op_.Square.Singleton.op(cos);
				double sinSq = nilnul.num.real.op_.Square.Singleton.op(sin);

				double cosSin = cos * sin;
				double bCosSin = b * cosSin;
				var a1 = a * cosSq + bCosSin + c * sinSq;
				var b1 = 0;
				var c1 = a * sinSq - bCosSin + c * cosSq;
				var d1 = d * cos + e * sin;
				var e1 = -d * sin + e * cos;
				var f1 = f;

				var x0 = -d1 / (2 * a1);
				var y0 = -e1 / (2 * c1);

				var a1c1 = a1 * c1;

				double numer = (-4 * f1 * a1c1 + c1 * d1 * d1 + a1 * e1 * e1);
				double fourA1C1 = 4 * a1c1;
				var radiusXSq = numer / (fourA1C1 * a1);
				var radiusYSq = numer / (fourA1C1 * c1);


				return (a1, c1, d1, e1, f1, tilt);

			}

			return (a, c, d, e, f, 0);

			/// The coordinates of the centerpoint are found by rotating back about angle θ from the center at <see cref="ellipse_._NontiltX"/>
			///  (x0,y0).Rotate( tilt)




		}
	}
}
