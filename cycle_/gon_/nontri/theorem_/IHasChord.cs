namespace nilnul.geometry.planar.cycle_.gon_.nontri.theorem_
{
	///
	///proofwiki.org/wiki/Polygon_not_Equal_to_Triangle_has_Chord
	/// <summary>
	/// Every simple polygon has a diagonal, that is, a segment joining two non-consecutive vertices that lies totally inside the polygon.
	/// </summary>
	/// <see cref="nontri.theorem_.IHasChord"/>
	/// <see cref="zone_.gon_.nontri._ChordX"/>
	interface IHasChord {

		///<see cref="ITwoEared"/>
		///, one choid of the ear would be that diagonal.
		///

		///<see cref="gon.theorem_.IEarCorneredOffSide"/>
		///, where
		///
		/*Since every polygon has at least three convex angles, there's at least one such vertex Pk,	with a convex angle.

	   If P[k-1] P[k+1] is a diagonal, we're done;


			   otherwise, there is at least one point within the interior of the triangle ΔPk−1 Pk Pk+1, or inner of (P[k-1], P[k+1]) .


		Choose one such point Pj such that the line from Pk to Pj is fully within the polygon. (
	   just choose the point Pj in the interior of the triangle which is furthest to Pk−1Pk+1 ( closest to Pk ) along the axis orthogonal to Pk−1Pk+1.

			   If an edge of the polygon were to cross over the line segment PkPj
	   
		and interrupt our path, then one endpoint of that edge would have to be even futher to Pk−1Pk+1 (closer to Pk), which is a contradiction.
		),
		Then Pk,Pj is a diagonal.
		*/
	}
}
