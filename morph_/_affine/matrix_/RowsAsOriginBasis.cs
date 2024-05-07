using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_._affine.matrix_
{
	/// <summary>
	/// first row is the newOrigin; second row is the newHorizonBasis; third row is the newVerticalBasis.
	/// thus, the matrix, when multiplied, is right associative.
	/// </summary>
	/// <remarks>
	///  In GDI+, composite transformations are built from left to right. If S, R, and T are scale, rotation, and translation matrices respectively, then the product SRT (in that order) is the matrix of the composite transformation that first scales, then rotates, then translates.
	/// </remarks>
	static public class _RowsAsOriginBasisX
	{

		/// <summary>
		/// </summary>
		/// <param name="linearMultiplier_2x2"></param>
		/// <param name="shift_2x1"></param>
		/// <returns>
		/// </returns>
		/// <remarks>
		/// how we get this augmented matrix?
		///		[e,f] + [x,y] * rows[ [a,b],[c,d] ] 
		///		=  [e,f] + x* [a,b] + y * [c,d] 
		///		= [1, x,y] * rows[[e,f],[a,b],[c,d] ]
		///		= [x', y']   //this is the result.
		///	 to align the resulted [x',y'], and the initial [x,y] , with the interim [1, x,y], we can augment the matrix:
		///	 to solve the equation:
		///	  [1,x,y] * rows[[e,f,w], [ a,b, u  ], [c,d,v]]
		///   ==
		///   [1, x',y']
		///   
		///   we get:
		///		w+x*u + y *v  =1.
		///		when u,v,w is preset, for any {x,y}, to make the above hold, we need w=1, u=0,v=0.
		///	 so the augmented matrix is:
		///		rows[[e,f,1], [ a,b,0],[c,d,0] ]
		///		where [e,f] is the new origin,[a,b] and [c,d] are the basis for the new vector space
		///
		/// Why augment?
		///		by linear trans, we cannot move the origin in 2d space.
		///		So how to move the orgin by linear trans?
		///		In 3d, we can shift the origin in one plane to another plane by a vector pointing from the first plane to the second plane. [e,f,1] is such a vector, where [e,f] shifts the projected origin to a new origin, the "1" elevated all the points to the projected plane. the projection is by skewed beams of sunshine such that the origin is shifted.
		///		
		/// </remarks>
		static public System.Drawing.Drawing2D.Matrix _Matrix_ofOriginBasises(
			float originX, float originY
			,
			float  newHorizonX, float newHorizonY

			,
			float newVerticalX, float newVerticalY

		)
		{
			return new System.Drawing.Drawing2D.Matrix(
				newHorizonX, newHorizonY
				,
				newVerticalX, newVerticalY
				,
				originX,originY
			);
		}

		static public System.Drawing.Drawing2D.Matrix _Matrix_ofOriginBasises(
			float[] _newOrigin
			,
			float[] newHorizon

			,
			float[] newVertical

		)
		{
			return _Matrix_ofOriginBasises(
				_newOrigin[0], _newOrigin[1]
				,
				newHorizon[0], newHorizon[ 1]
				,
				newVertical[0], newVertical[1]
			);
		}


		static public System.Drawing.Drawing2D.Matrix _Matrix_ofOrigin_ofBasisesInCols(
			float[] newOrigin
			,
			float[,] rowAsBasis


		)
		{
			return _Matrix_ofOriginBasises(
				newOrigin[0], newOrigin[1]
				,
				rowAsBasis[0, 0], rowAsBasis[0, 1]
				,
				rowAsBasis[1, 0], rowAsBasis[1, 1]
			);
		}

	}
}
