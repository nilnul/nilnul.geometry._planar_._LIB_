using System;
using System.Numerics;

namespace nilnul.geometry.planar.trac_.ellipse_
{
	static public class QuadratureX {
		static public tope_.BlocDbl Bounding8float(
			Complex center, double realRadius, double imaginaryRadius
		) {
			return new tope_.BlocDbl(
				center.Real -realRadius
				,
				center.Imaginary -imaginaryRadius
				,
				realRadius*2
				,
				imaginaryRadius*2
			);
		}

		public static tope_.BlocDbl Bounding8float(double centerX, double centerY, double radiusX, double radiusY)
		{
			return new tope_.BlocDbl(
				centerX -radiusX
				,
				centerY -radiusY
				,
				radiusX*2
				,
				radiusY*2
			);
		}
	}

}
