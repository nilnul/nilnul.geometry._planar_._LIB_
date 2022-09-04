using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_._affine.matrix_
{
	/// <summary>
	/// put the new origin in the last vector, we can keep the original 2d vector space unchanged, and add the extra dimension to get the new 3d vector space.
	/// the matrix, when multiplied, is right associative.
	/// </summary>
	/// <remarks>
	///  In GDI+, composite transformations are built from left to right. If S, R, and T are scale, rotation, and translation matrices respectively, then the product SRT (in that order) is the matrix of the composite transformation that first scales, then rotates, then translates.
	/// </remarks>
	static public class _RowsAsBasisOriginX
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
		///		= [ x,y,1] * rows[[a,b],[c,d],[e,f] ]
		///		= [x', y']   //this is the result.
		///	 to align the resulted [x',y'], and the initial [x,y] , with the interim [ x,y,1], we can augment the matrix:
		///	 to solve the equation:
		///	  [x,y,1] * rows[[ a,b, u  ], [c,d,v], [e,f,w] ]
		///   ==
		///   [ x',y',1]
		///   
		///   we get:
		///		x*u + y *v+ w  =1.
		///		when u,v,w is preset, for any {x,y}, to make the above hold, we need w=1, u=0,v=0.
		///	 so the augmented matrix is:
		///		rows[ [ a,b,0],[c,d,0] , [e,f,1]]
		///		where [e,f] is the new origin,[a,b] and [c,d] are the basis for the new vector space
		///
		/// Why augment?
		///		by linear trans, we cannot move the origin in 2d space.
		///		So how to move the orgin by linear trans?
		///		In 3d, we can shift the origin in one plane to another plane by a vector pointing from the first plane to the second plane. [e,f,1] is such a vector, where [e,f] shifts the projected origin to a new origin, the "1" elevated all the points to the projected plane. the projection is by skewed beams of sunshine such that the origin is shifted.
		///		
		/// </remarks>
		static public System.Drawing.Drawing2D.Matrix _Matrix_ofOriginBasises(
			float  newHorizonX, float newHorizonY

			,
			float newVerticalX, float newVerticalY
			,
			float originX, float originY

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
			float[] newHorizon

			,
			float[] newVertical
			,
			float[] _newOrigin

		)
		{
			return _Matrix_ofOriginBasises(
				newHorizon[0], newHorizon[ 1]
				,
				newVertical[0], newVertical[1]
				,

				_newOrigin[0], _newOrigin[1]
			);
		}


		static public System.Drawing.Drawing2D.Matrix _Matrix_ofOrigin_ofBasisesInCols(
			float[,] rowAsBasis
			,

			float[] newOrigin

		)
		{
			return _Matrix_ofOriginBasises(
				rowAsBasis[0, 0], rowAsBasis[0, 1]
				,
				rowAsBasis[1, 0], rowAsBasis[1, 1]
				,
				newOrigin[0], newOrigin[1]
			);
		}

	}
}
