using System;

namespace nilnul.geometry.planar.curve_.algebraic_.cubic_
{
	class TrisectrixOfMaclaurin
	{

		static public double RhoOfTheta(double a, double theta) {
			return 2 * a * Math.Cos(theta / 3);
		}
	}
}
