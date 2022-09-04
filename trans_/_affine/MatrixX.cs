using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_._affine
{
	/// <summary>
	/// .net framework provided matrix. adapt this to nilnul.
	/// </summary>
	/// <remarks>
	///the third column of a matrix that represents an affine transformation is always (0, 0, 1).
	/// and the point to be transformed is augmented as (x,y,1)
	/// so the resulting column is x*c + y*c1+ 
	/// </remarks>
	static public class _MatrixX
	{

		/// <summary>
		/// note the matrix is right multipler
		/// </summary>
		/// <param name="linearMultiplier_2x2"></param>
		/// <param name="shift_2x1"></param>
		/// <returns>
		///		the 3rd col is (0,0,1).
		///		in applying the matrix, the point is augumented as (x,y,1),  the result is a col (x',y',1).
		/// </returns>
		/// <remarks>
		///  In GDI+, composite transformations are built from left to right. If S, R, and T are scale, rotation, and translation matrices respectively, then the product SRT (in that order) is the matrix of the composite transformation that first scales, then rotates, then translates.
		///
		/// how we get this augmented matrix?
		///		 [x,y] * [ [a,b],[c,d] ]  + [e,f]
		///		=  x* [a,c] + y * [b,d] + [e,f]
		///		= [x,y,1] * [[a,b,e],[c,d,e] ]
		///		= [x', y']   //this is the result.
		///	 to align the resulted [x',y'], and the initial [x,y] , with the interim [x,y,1], we can augment the matrix:
		///	 for the equation to solve:
		///	  [x,y,1] * cols[ [a,c, u  ], [b,d,v], [e,f,w] ]
		///   ==
		///   [x',y',1]
		///   we get:
		///		x*u + y *v + w =1.
		///		when u,v,w is preset, for any {x,y}, to make the above hold, we need u=0,v=0, w=1.
		///	 so the augmented matrix is:
		///		cols[[ a,c,0],[b,d,0],[e,f,1] ]
		///		where [a,c] and [b,d] are the basis for the new vector space, and [e,f] is the new origin
		/// </remarks>
		static public System.Drawing.Drawing2D.Matrix Matrix_ofLinear_ofTranslate(

			float[,] linearMultiplier_2x2
			,
			float[] shift_2x1
		)
		{
			return new System.Drawing.Drawing2D.Matrix(
				linearMultiplier_2x2[0, 0], linearMultiplier_2x2[0, 1]
				,
				linearMultiplier_2x2[1, 0], linearMultiplier_2x2[1, 1]
				,
				shift_2x1[0], shift_2x1[1]
			);
		}
		

	}
}
