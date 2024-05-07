using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.theorem_._earCornerOffSide.proof_
{
	/// <summary>
	/// 
	/// </summary>
	internal class Triangulation
	{
		///<see cref="gon.theorem_.Triangulation"/>
		///Suppose △i has 0 or 1 sides in common with P
		///In this case, △i cannot be an ear of P
		///other wise, two or more side in common with P, the trigon would be an ear.
		/// As we exclude trigon, so the trigon cannot have 3 sides in common wih P.
		/// 
		///	suppose that at most one triangles is an ear.
		///	each of other (n-3) would have 0 or 1 sides.
		///
		/// the count of sides are at most:
		///  2 + (n-3) *1 = n-1
		///  but we need n edges.
		///  
		///  As the two ears are part of a triangulation, they do not overlap.

		/*
		 
		 */
	}
}
