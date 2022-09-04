using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.co
{
	/// <summary>
	/// standard outer product for 2d plane is: x ^ y, where x is the unit positve vect along x-axis, and y is the positive unit vect along y-axis.
	/// every other bivect can be converted into the std outer product. eg:
	///		a ^ b
	///		= (a[x]b[y] -a[y]b[x] ) * (j)
	///		=
	/// </summary>
	/// outer product is not a vect, nor a scalar. It's a new algebraic object. It's not the result of cross product. In fact it's a cross product with a new dimension(
	/// one of:
	///		x^y
	///		
	/// ).
	class OuterProduct
	{

	}
}
