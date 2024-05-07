using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.theorem_
{
	/// <summary>
	/// For every simple polygon P, and every side AB of that polygon, P has an ear whose central vertex (the corner of gon, opposite to the chord) is neither A nor B.
	/// </summary>
	internal class IEarCorneredOffSide
	{
		/*
		 for trigon, given AB, we can have an ear, BCA, whose central vertex is C.

		suppos it holds for n-1 gon that given AB, we have an ear at the corner other than AB.

		for n-gon of vertexes P[i], where i= 0,+n
		,let's take A=P[0], B=P1

Since every polygon has at least three convex angles, */
		/// <see cref="cycle_.gon.theorem_."/>
		/// <see cref="cycle_.gon.corners.theorem_.Ge3Convex"/>
		/// <see cref="zone_.gon.corner."/>
		/*there's at least one other vertex P[k], (where k=2,3,... n-1)
 with a convex angle.
		
If it is the vertex of an ear, we're done;

		otherwise, there is at least one point within the interior of the triangle ΔP[k−1] P[k] P[k+1],  or inner of ( P[k-1], P[k+1]  ),
		*//// in other words, <see cref="geometry.planar.grad_.skid.co_.angular_.convex.vsPoint.be_.ISubtend"/>
		/*

 Choose one such point P[j] such that the line from P[k] to P[j] is fully within the polygon. (
just choose the point Pj in the interior of the triangle which is furthes to Pk−1Pk+1 ( closest to Pk ) along the axis orthogonal to Pk−1Pk+1.
		If an edge of the polygon were to cross over the line segment PkPj
 and interrupt our path, then one endpoint of that edge would have to be even further to Pk−1Pk+1 (closer to Pk ), which is a contradiction.
		)

Now, cut our polygon in two along the line segment P[k]P[j] (by assumption, j
 wasn't k−1 or k+1
, so these two pieces really are nontrivial polygons). AB will be on one of these two pieces; consider the other piece. By the inductive hypothesis, that piece has an ear disjoint from PkPj. But that ear is also an ear of the original polygon and is not on AB, so we're done!

		*/
	}
}
