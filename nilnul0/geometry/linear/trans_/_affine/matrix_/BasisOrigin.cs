using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.trans_._affine.matrix_
{
	/// <summary>
	/// [x']
	/// = [x] * [b]+ [a] 
	/// =[x,1] * rows[ [b],[a]  ]
	/// if we align the result [x'] and the initial [x], with the interim [x,1], the initial would be [x,1], and the result would be [x',1]
	/// to solve the following: 
	/// [x',1]
	/// =
	/// [x,1] * [[ b,u], [a,v] ]
	/// ,
	/// we need x*u+v =1 for any x. so u=0, v=1
	/// thus the augmented matrix is [ [b,0], [a,1] ]
	///
	/// [x',1'] = [x,1] * [  [b,0], [a,1]]
	/// where [a,1] is the 1d newOrigin, [a],  projected to the 2d line : y=1, into [a,1]
	/// 
	/// </summary>
	static public class _BasisOriginX
	{
		/// <summary>
		/// [x,1] is the vector mapped to the 2d line: y=1.
		/// </summary>
		/// <param name="newBasis">
		/// [newBasis,0], or [scale,0]
		///
		/// </param>
		/// <param name="shift">
		/// [shift,1] is the projection beaming from y=0, to y=1, skewed from old origin, to newOrigin: [shift]
		/// </param>
		/// <returns>
		/// right associated when multiplied
		/// </returns>
		static public double[,] Rows( double newBasis, double shift) {
			return new double[,] {
				{ newBasis,0}
				,
				{ shift,1}
			} ;
		}
	}
}
