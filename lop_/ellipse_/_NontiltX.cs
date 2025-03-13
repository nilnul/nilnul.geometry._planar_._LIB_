using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lop_.ellipse_
{
	class _NontiltX
	{
		/// <summary>
		/// a x^2 +  c y^2 +d x + e y + f =0
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
		/// <see cref="_ellipse_.by_._AlgebraX"/>

		static public (double radiusXSq, double radiusYSq, C center) Algebra(
			double a
			,
			double c
			,
			double d
			,
			double e
			,
			double f

		)
		{
			///math.stackexchange.com/questions/280937/finding-the-angle-of-rotation-of-an-ellipse-from-its-general-equation-and-the-ot

			if (4 * a * c <= 0)
			{
				throw new ArgumentOutOfRangeException($"4ac >b*b must hold for it to be a nontrivia ellipse.");

			}


			var x0 = -d / (2 * a);
			var y0 = -e / (2 * c);

			var ac = a * c;

			double numer = (-4 * f * ac + c * d * d + a * e * e);
			double fourA1C1 = 4 * ac;
			var radiusXSq = numer / (fourA1C1 * a);
			var radiusYSq = numer / (fourA1C1 * c);

			return (
				radiusXSq,radiusYSq
				,
				new System.Numerics.Complex(
				x0,
				y0)
			);





		}
	}
}
