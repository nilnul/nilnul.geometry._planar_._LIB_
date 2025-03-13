using nilnul.set.operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.convex.set.theorem_
{
	/// <summary>
	///Let C be a finite family of convex sets  such that, for k ≤ 3, any k members of C have a nonempty intersection. Then the intersection of all members of C is nonempty.
	/// 
	/// </summary>
	/// <remarks>
	/// to generaize at n,
	///Let C be a finite family of convex sets in R^n such that, for k ≤ n + 1, any k members of C have a nonempty intersection. Then the intersection of all members of C is nonempty.
	///
	/// </remarks>
	/// cut-the-knot.org/pythagoras/ConvexSets/HellysTheorem.shtml
	internal class RadonHellyTheorem
	{


		/// proof by induction:
		///
		/// , base case:
		///		Four convex figures are given in the plane. If every three of them have a nonempty intersection, then the intersection of all four figure is also nonempty.
		///
		///  prrof of the base case:
		///  
		/// Denote the four sets F1, F2, F3, F4. For j = 1, 2, 3, 4, let aj be a common point of the three sets, with Fj removed. Thus, for example, a1 ∈ F2 ∩ F3 ∩ F4, etc. Two cases are possible:
		/// 1) One of the points a1, a2, a3, a4 lies in the interior or the border of the triangle formed by the other three. Assume, for example, that a1 ∈ Δa2a3a4. But each of the points a2, a3, a4 belongs to F1. By the convexity of the latter, the whole Δa2a3a4 ⊂ F1 and so a1 ∈ F1. Since, by our assumption, a1 ∈ F2 ∩ F3 ∩ F4, we also have a1 ∈ F1 ∩ F2 ∩ F3 ∩ F4.
		/// 2) Points a1, a2, a3, a4 form a convex quadrilateral, so that none of them lies in the triangle formed by the other three. The diagonal a1a3 wholly belongs to F2 ∩ F4 while the diagonal a2a4 wholly belongs to F1 ∩ F3. The intersection of the diagonals then belongs to (F2 ∩ F4) ∩ (F1 ∩ F3).


		/// now the extension for the induction:
		/// So let's assume that the theorem holds for some s ≥ 4 and consider s + 1 sets F1, ..., Fs, Fs+1 with the property that the intersection of any three of them is nonempty.
		/// Define Gk = Fk ∩ Fs+1, k = 1, ..., s.The intersection of any three G's is nonempty. For example,
		/// G1 ∩ G2 ∩ G3 = F1 ∩ F2 ∩ F3 ∩ Fs+1,which is nonempty by Lemma.This means that the intersection of all G's is nonempty. Moreover, the intersection of all G's is exactly the intersection of all F's.

	}
}
