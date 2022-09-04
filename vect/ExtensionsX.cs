using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect
{
	static public class _ExtensionsX
	{
		static public double InnerProduct(this planar.Vect4dblI a, planar.Vect4dblI b) {
			return vect.co.to_.real_._DotProductX.Dbl(a, b);
		}
		static public double InnerProduct(this planar.Point4dblI a) {
			return a.x*a.y;
		}

		static public double InnerProduct(this planar.Vect4dblI a) {
			return InnerProduct(a.point);
		}

		static public double Dot(this planar.Vect4dblI a, planar.Vect4dblI b) {
			return vect.co.to_.real_._DotProductX.Dbl(a, b);
		}

		static public Vect4dbl Minus(this planar.Vect4dblI a, planar.Vect4dblI b) {
			return vect.op_.binary_._MinusX.Op(a, b);
		}

		static public double Distance(this planar.Vect4dblI a) {
			return vect._MagnitudeX.Magnitude(a);

		}

		static public double Variance(this planar.Vect4dblI a) {
			return vect.co.to_.real_._DotProductX.Square(a);

		}

	}
}
