using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect
{
	static public  class _ToX
	{
		static public Complex ToComplex(this Vect4dblI vect) {
			return ToComplex(vect.point);
		}
		static public Complex ToComplex(this Point4dblI vect) {
			return new Complex(vect.x, vect.y);
		}


	}
}
