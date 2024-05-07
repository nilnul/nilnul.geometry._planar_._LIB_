using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.trans_._affine.matrix_
{
	/// <summary>
	/// [x']
	/// =[a] + [x] * [b]
	/// =[1,x] * rows[ [a],[b]  ]
	/// if we align the result [x'] and the initial [x], with the interim [1,x], the initial would be [1,x], and the result would be [1,x']
	/// to solve the following: 
	/// [1,x']
	/// =
	/// [1,x] * [[ u,a], [v,b] ]
	/// ,
	/// we need u+x*v =1 for any x. so u=1, v=0
	/// thus the augmented matrix is [ [1,a], [0,b] ]
	///
	/// [1,x'] = [1, x] * [  [1,a], [0,b]]
	/// where [1,a] is the 1d newOrigin, [a],  projected to the 2d line : x=1, into [1,a]. b is the newbasis
	/// 
	/// </summary>
	static public class _OriginBasisX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="shift">
		/// [1,shift] is the projection beaming from x=0, to x=1, skewed from old origin, to newOrigin:[shift]
		/// .Note, the second axis in 2d space corresponds to the old 1d axis
		/// </param>
		/// <param name="newBasis">
		/// [0,newBasis], or [0, scale]
		///
		/// </param>
		/// <returns>
		/// right associated when multiplied
		/// </returns>
		static public double[,] Rows(double shift, double newBasis) {
			return new double[,] {
				{ 1,shift},
				{ 0,newBasis}
			} ;
		}
	}
}
