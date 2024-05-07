using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.matrixed_.shear_.rotate_
{
	/// <summary>
	/// rotate a quarter
	/// </summary>
	class Quarter
	{
		/// <summary>
		/// the first new basis is (0,1), the half positive y of old basis.
		/// the second new basis is (-1,0), the negative half of the old x-axis.
		/// This matrix is in cols. (each new basis is in col). So this matrix multiplies coordinates from left.
		/// </summary>
		static public int[,] NewBasisInCols = new[,] {
			{0,-1 }
			,
			{ 1,0}
		};

		/// <summary>
		/// This matrix is in rows. (each new basis is in row). So this matrix multiplies coordinates from right (coordinates is at the left).
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>

		static public int[,] NewBasisInRows = new[,] {
			{0,1 }
			,
			{-1,0}
		};

	}
}
