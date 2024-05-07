﻿using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.facet_.gon_._conduit.disord.of_
{

	/// re:
	///		Triangulation by Ear Clipping, 	David Eberly, Geometric Tools, Redmond WA 98052, https://www.geometrictools.com/
	///		,which is cached in _KEN_/facet_/
	///		
	/// <summary>
	/// make a conduit for each hole by adding two opposite edges;
	/// we find the conduit by:
	///		1) from the rightmost point of the hole
	///		2) ray rightmost, get the leftmost intersection with the hull;
	///		3) if the intersection is a vertex, that's what we found. return;
	///		4) find the edge for the intersection.  find the two extreme vertexes of the edge;
	///		5) 
	/// </summary>
	static public class _Coerce4dblX
	{

		/// <summary>
		/// apply the conduiting algorithm recursively.
		/// </summary>
		/// <param name="byCoil4Dbl"></param>
		/// <param name="hole"></param>
		/// <returns></returns>
		private static IEnumerable<Point4dblI> _MergeHole(
			IEnumerable<Point4dblI> _gon_assumeConduit
			,
			(Antiwise4dbl, Point4dblI) child
		)
		{
			/// the hole must be inside.
			///
			// must be disjoint
			//

			//var childEksMax = planar.point.str.to_.scalar_.EksMax.Singleton.to(
			//	_gon_assumeConduit
			//);

			var grads = cloze_.gon._Grads4dblX._Grads_ofStarted(_gon_assumeConduit)
				.ToArray() //keep the logic simple, make the debug nondistracted
				;

			///get the edge in the parent
			var parentEdge1pointCandidate = nilnul.objs_.started._MinX.Min_assumeStarted(
				grads.Select(
					g => (
						g
						,
						planar.ray_.horizon_.increase.vsGrad._NearestJoint.NearestJoint(

										child.Item2
										,
										g
						)
					)
				).ToArray()
				,
				c => c.Item2
				,
				nilnul.num.real.nuly.comp_.NulMax4Dbl.Singleton
			);

			var parentEdgeRayed = new Point4dbl(parentEdge1pointCandidate.Item2.Value, child.Item2.y);

			//((cycle_.gon_.Antiwise4dbl, Point4dblI) child, (Grad4dbl_byPointsI g, double?) parentEdge1point) hole;
			(Grad4dbl_byPointsI, Point4dblI) parentEdge1point222;

			if (
				planar.point.EqDbl.Singleton.Equals(
					parentEdgeRayed
					,
					parentEdge1pointCandidate.Item1.basis
				)
			)
			{
				//((cycle_.gon_.Antiwise4dbl, Point4dblI) child, (Grad4dbl_byPointsI g, double?) parentEdge1point)
				parentEdge1point222 = (parentEdge1pointCandidate.g, parentEdgeRayed);
				/// todo:
			}
			else if (
				planar.point.EqDbl.Singleton.Equals(
					parentEdgeRayed
					,
					parentEdge1pointCandidate.Item1.finish
				)
			)
			{
				//var
				parentEdge1point222 =
				 (parentEdge1pointCandidate.g, parentEdgeRayed);
			}
			else // if the intersection is not a vertex
			{

				var endPointOfParentEdgeRayed = parentEdge1pointCandidate.g.basis.x
					>	// we need to keep the point right to the hole; otherwise, if the point is left to the hole's rightmost, this method's underlying logic would not hold.
					parentEdge1pointCandidate.Item1.finish.x
					? parentEdge1pointCandidate.g.basis : parentEdge1pointCandidate.g.finish;

				var insideVertexes = _gon_assumeConduit.Where(
					x =>
					zone_.gon.vsPoint.has_.byRay_._StokesIfIntersected.IsInPolygon(
						x
						,
						 nilnul.geometry.planar.zone_.TriangleDbl.OfByReorient(
							child.Item2, parentEdgeRayed, endPointOfParentEdgeRayed
						)
					) != false
				);


				Point4dblI parentJointer = nilnul.objs_.started._MinX.Min_assumeStarted(
					insideVertexes
					,
					p =>(
						Math.Abs(p.y-child.Item2.y ) / (p.x -child.Item2.x) 
						,
						planar.tend._VarianceX.Variance(p, child.Item2) // if the angle is the same, we select the nearest. if there are two of the same angle and distance, either will be ok, as it is visible (a connection exists in the facet) to the hole.
					)
					,
					nilnul.num.real.co.Comp4dbl.Singleton
				);
				parentEdge1point222 = (parentEdge1pointCandidate.g, parentJointer);
			}

			return newConduitPoints();

			// now slice the pair as whole.
			IEnumerable<Point4dblI> newConduitPoints()
			{
				var childVertexesList = child.Item1.vertexes.ToList();
				var indexOf = childVertexesList.IndexOf(
					child.Item2
				);

				for (int i = indexOf; i < child.Item1.vertexes.Count(); i++)
				{
					yield return childVertexesList.ElementAt(i);
				}
				for (int i = 0; i < indexOf; i++)
				{
					yield return childVertexesList.ElementAt(i);
				}

				yield return childVertexesList.ElementAt(indexOf);

				var parentVertexesList = _gon_assumeConduit.ToArray();

				var parentIndex = Array.IndexOf(parentVertexesList, parentEdge1point222.Item2);	/// vs:<see cref="conduit.of_.coerce_._MinCuspX"/>, here we failed to select the most constricting edge.

				for (int i = parentIndex; i < parentVertexesList.Length; i++)
				{
					yield return parentVertexesList[i];
				}
				for (int i = 0; i < parentIndex; i++)
				{
					yield return parentVertexesList[i];
				}
				yield return parentVertexesList[parentIndex];
				/// as a clozed polygon, we will return to the first vertex when this polygon is rendered.

			}

		}


		static public IEnumerable<Point4dblI> Of(
			facet_.Gon4dbl gon
		)
		{


			var children = gon.holes.ee.ToList();
			IEnumerable<Point4dblI> merged = gon.contour.vertexes;
			while (children.Any())
			{
				var child = gon1vertexOfMaxX(children);
				merged = _MergeHole(
					merged.ToArray()
					,
					child
			   );
				children.Remove(
					child.Item1
				);

				/// as vertexes might shift, hence the below is not reliable
				//children.RemoveAll(
				//	x =>
				//	point.str.Eq4dbl.Singleton.Equals(
				//		x.vertexes,
				//		child.Item1.vertexes
				//	)
				//);

			}

			return merged;

			///get the gon which has a vertex of the maxX. return the gon and the vertex.
			/// this can help avoid the other end of the conduit falls upon another hole, not the hull.
			(cycle_.gon_.Antiwise4dbl, Point4dblI) gon1vertexOfMaxX(
				IEnumerable<cycle_.gon_.Antiwise4dbl> gons
			)
			{
				return nilnul.objs_.started._MaxX.Max_assumeStarted(
					gons.Select(
						e
						=> (
							e
							,
							planar.point.str.to_.scalar_.EksMax.Singleton.to(e.vertexes)
						)
					)
					,
					t => t.Item2.x
					,
					nilnul.num.real.ComparerDbl.Singleton
				);
			}




		}

	}
}