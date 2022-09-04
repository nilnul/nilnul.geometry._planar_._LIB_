using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_
{

	
	/// <summary>
	/// the map is newVector= Ax+b
	///		so linear is special affine where b=0.
	///An affine function is the composition of a linear function with a translation
	///		A linear function fixes the origin, whereas an affine function need not do so.
	/// 
	/// </summary>
	/// <remarks>
	/// preserves parallelism as:
	///		kernel matrix is shear and scale
	///		translate
	///
	/// 
	/// the matrix given by dotnet Drawing2d is affine
	/// 
	/// augmented the point (x,y) into a 3-d point (x,y,1). that is at the plane (z=1).
	/// then transfrom_.matrix in 3d
	/// then discard z. (that is map back into the 2-d plane)
	/// This is how you carry/process/tweek/flip a board in real 3d world, and then put it back onto the floor.
	///
	/// 	///
	/// An affine function is the composition of a linear function with a translation, so while the linear part fixes the origin, the translation can map it somewhere else. Linear functions between vector spaces preserve the vector space structure (so in particular they must fix the origin).
	///
	/// when you pan on a map, you zoom/shift/shear
	/// </remarks>
	public interface IAffine
	{


		//or we can use augmented matrix, which is 3*3.
		//the the point (x,y) will be converted to and from (x,y,1)
	}

	/// <summary>
	/// multiply by a same dimension matrix, and then add another.
	/// </summary>
	static public class _AffineX
	{
		static public (double, double) Trans_byAdd(
			(double, double) coord2trans
			,
			double[,] multiplier_2x2
			,
			double[] shift_2x1
		) {
			return	trans_._ShiftX.Trans(
					trans_._MatrixX.Trans(coord2trans, multiplier_2x2)
					,
					shift_2x1
				)
			;
		}



		
	}



}
