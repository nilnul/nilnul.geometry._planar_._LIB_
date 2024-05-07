using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.theorem_
{
	/// <summary>
	/// For every simple polygon P, and every side AB of that polygon, P has an ear whose central vertex (the corner of gon, opposite to the chord) is neither A nor B.
	/// </summary>
	static public class _EarOffSideX
	{


		///<summary>
		/// a representation of the proof that every gon has an ear whose tip is not on the given edge.
		/// </summary>
		/// <remarks>
		/// the correctness of the proof is determined by a higher order method, such as human review.
		/// </remarks>
		/// <see cref="nilnul.bit.ProofI"/>
		/// <param name="edgeEnd">
		/// the edgeBegin can be inferred as (<paramref name="edgeEnd"/> -1 +count)%count
		/// </param>
		///
		[Obsolete(nameof(_earOffSide_.by_._RevolvingVerticesX) + " is more simpler.")]
		static public int _EarTip_0zone_1edgeEnd(
			IEnumerable<Complex> gon
			,
			int edgeEnd = 0
		//,
		//(Complex begin, Complex end) edge
		)
		{
			int count = gon.Count();
			var edgeBegin = (edgeEnd - 1 + count) % count;

			/// this is an induction or recursion proof.
			/// first the base case:
			///
			if (count == 3)
			{
				return ((int[])[0, 1, 2]).Except(
					[edgeBegin, edgeEnd]
				).Single();
				///  for trigon, given AB, we can have an ear, BCA, whose central vertex is C, not A nor B.
			}

			///
			/// 
			/// now let's suppose that this theorem holds for gon of n-1 edges
			/// that is, suppos it holds for n-1 gon that given AB, we have an ear at the corner other than AB.
			///
			/// , then deal(by reducing or induction) with n edges
			///


			/// we now know n is greater than 3.

			/*

				for n-gon of vertexes P[i], where i= 0,+n
				,let's take A=P[0], B=P1

		Since every polygon has at least three convex angles, */
			/// <see cref="cycle_.gon.theorem_."/>
			/// <see cref="cycle_.gon.corners.theorem_.Ge3Convex"/>
			/// <see cref="zone_.gon.corner."/>
			/*there's at least one other vertex P[k], (where k=2,3,... n-1)
	 with a convex angle.

			*/

			var convexCornerOffEdge = zone_.gon.corners.theorem_._ConvexOffEdgeX._Index_0zone_1elbowStart(
				gon,
				edgeEnd
			);





			/// <see cref="cycle_.gon_.nontri.theorem_.IHasChord"/>
			/// <see cref="zone_.gon_.nontri._ChordX"/>
			///

			var chord = zone_.gon_.nontri.corner_.convex._ChordX._Indexes_0nontriZone_1convex(gon, convexCornerOffEdge);



			///	If it is the vertex of an ear, we're done;
			///
			if (chord.end == (convexCornerOffEdge + 1) % count)
			{
				return convexCornerOffEdge;
			}





			///otherwise, there is at least one point within the interior of the triangle ΔP[k−1] P[k] P[k+1],  or inner of ( P[k-1], P[k+1]  ),
			/// in other words, <see cref="geometry.planar.grad_.skid.co_.angular_.convex.vsPoint.be_.ISubtend"/>
			///



			// Choose one such point P[j] such that the line from P[k] to P[j] is fully within the polygon. (
			//just choose the point Pj in the interior of the triangle which is furthes to Pk−1Pk+1 ( closest to Pk ) along the axis orthogonal to Pk−1Pk+1.
			//		If an edge of the polygon were to cross over the line segment PkPj
			// and interrupt our path, then one endpoint of that edge would have to be even further to Pk−1Pk+1 (closer to Pk ), which is a contradiction.
			//		)

			/// that is the chord above.


			//Now, cut our polygon in two along the line segment P[k]P[j] (by assumption, j
			// wasn't k−1 or k+1
			//, so these two pieces really are nontrivial polygons).

			//AB will be on one of these two pieces; consider the other piece. By the inductive hypothesis, that piece has an ear disjoint from PkPj. But that ear is also an ear of the original polygon and is not on AB, so we're done!

			///

			int chordEndElevator = chord.end >= convexCornerOffEdge ? 0 : count;
			(int begin, int end) otherHalf = (convexCornerOffEdge, chord.end + chordEndElevator);

			//(int begin, int end) thisHalf;
			//if (convexCornerOffEdge > chord.end)
			//{
			//	//thisHalf = (chord.end, convexCornerOffEdge);
			//	otherHalf = (convexCornerOffEdge, chord.end + count);

			//}
			//else
			//{
			//	//thisHalf = (chord.end, convexCornerOffEdge + count);
			//	otherHalf = (convexCornerOffEdge, chord.end);
			//}



			var edgeBeginIsInNextHalf = nilnul.num.integer.bound_._ClosedX._Has(
				otherHalf, edgeBegin + (edgeBegin < otherHalf.begin ? count : 0)
			);

			var edgeEndIsInNextHalf = nilnul.num.integer.bound_._ClosedX._Has(
				otherHalf, edgeEnd + (edgeEnd < otherHalf.begin ? count : 0)
			);

			if (edgeBeginIsInNextHalf && edgeEndIsInNextHalf)
			{
				return (_EarTip_0zone_1edgeEnd(
					sliced(
						chord.end
						,
						convexCornerOffEdge + (chord.end <= convexCornerOffEdge ? 0 : count)
					)


				) + chord.end
				) % count; ;

			}

			return (_EarTip_0zone_1edgeEnd(
					sliced(
						convexCornerOffEdge
						,
						otherHalf.end
					//chord.end + chordEndElevator
					)
				) + convexCornerOffEdge
			) % count;


			IEnumerable<Complex> sliced(int begin, int end4modulo)
			{
				for (int i = begin; i <= end4modulo; i++)
				{
					yield return gon.ElementAt(i % count);
				}
			}


		}
	}
}
