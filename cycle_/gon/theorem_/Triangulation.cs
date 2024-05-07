using nilnul.geometry.planar._area.unit_;

namespace nilnul.geometry.planar.cycle_.gon.theorem_
{
	///proofwiki.org/wiki/Polygon_Triangulation_Theorem
	/// <summary>
	/// there exists a triangulation of P,
	/// that fulfills this condition:
	///		If AB is a side of a triangle in the triangulation of P   , then AB is either a side of P   , or a chord of P	that lies completely in the interior of P.
	///
	///    All triangulations of P	that fulfill this condition consist of exactly n−2	triangles.
	/// </summary>
	class Triangulation
	{
		/*
		Basis for the Induction
Let n=3


Induction Hypothesis
For each i
 such that 3≤i≤n
, a polygon P
 with i
 sides has a triangulation that fulfills the above condition, and consists of i−2
 triangles.

Then we need to show:

A polygon P
 with n+1
 sides has a triangulation that fulfills the above condition, and consists of n−1
 triangles.



Induction Step

P is not a triangle.

		 
		 */
		///<see cref="gon_.nontri.theorem_.ITwoEared"/>
		///Let AB be such an arbitrary chord of P.
		/// it partition the gon into two gons, each of which has le n edges.
		/// And each of them would conforms the triangulation theorem.The triangles of these two triangulation combine to form a triangulation of P.
		///It follows that the combined number of sides of P1		and P2 are equal to:
		///n1+n2=   (n+1)+2=n+3, as it's from (n+1) gon
		///
		/// n1-2 + n2-2 = (n+3)-4 = n-1 = (n+1) -2
		/// These triangles cannot be dissected without creating a side that is not a chord of P.
		/// It follows that the triangulation consists of exactly n−2 triangles.



	}
}
