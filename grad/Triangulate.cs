using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad
{
	/// connect each ends to the origin and a triangle is formed, such that the direction of the grad is not changed in the triangle.
	/// <summary>
	/// for grad(a,b),where a,b are points, the triangle is (0,0), a, b;
	/// </summary>
	/// <remarks>
	/// The triangle might be
	///		a point, if the grad is trivia and at the orign
	///		a grad, if one end is at the origin
	///		a <see cref="coil_.gon_.ITri"/>
	///		
	///  eg: for grad: (2,1) -> ( 1,2)
	///  ,then we would get trigon (0,0), (2,1), (1,2), which is a sweep from
	///		(0,0),(2,1)
	///		to: (0,0) (1,2)
	/// in other words, the vect (2,1) is pulled by the grad to the vect (1,2)
	/// 
	///</remarks>
	/// <see cref="grad.IShade"/>, and <see cref="grad.shadow_."/>
	/// 
	/// 
	class Triangulate
	{
	}

	static public class _TriangulateX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns>
		///
		/// </returns>
		/// 
		static public (Complex a, Complex b, Complex c) Triangulate(Complex x,Complex y) {
			return ( Complex.Zero,x, y);	/// take origin as an implicit start point ; the order is also consistent when we extend the triangle to <see cref="trigonize.IParallelogram"/>
											/// should we put x first like <see cref="_ShadeX"/>
		}
	}
}
