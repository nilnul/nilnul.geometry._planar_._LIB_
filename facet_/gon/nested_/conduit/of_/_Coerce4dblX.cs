using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.facet_.gon.nested_.conduit.of_
{

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

			var grads = cloze_.gon._Grads4dblX._Grads_ofStarted(_gon_assumeConduit);

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
				)
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
			else
			{
				var endPointOfParentEdgeRayed = parentEdge1pointCandidate.g.basis.x > parentEdge1pointCandidate.Item1.finish.x ? parentEdge1pointCandidate.g.basis : parentEdge1pointCandidate.g.finish;

				var insideVertexes = _gon_assumeConduit.Where(
					x =>
					zone_.gon.vsPoint.has_.byRay_._StokesIfIntersected.IsInPolygon(
						x
						,
						 nilnul.geometry.planar.zone_.TriangleDbl.OfByReorient(
							child.Item2, parentEdgeRayed, endPointOfParentEdgeRayed
						)
					)
				);

				Point4dblI parentJointer = nilnul.objs_.started._MinX.Min_assumeStarted(
					insideVertexes
					,
					p => planar.tend._VarianceX.Variance(p, child.Item2)
					,
					nilnul.num.real.ComparerDbl.Singleton
				);
				parentEdge1point222 = (parentEdge1pointCandidate.g, parentJointer);
			}

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

				var parentIndex = Array.IndexOf(parentVertexesList, parentEdge1point222.Item2);

				for (int i = indexOf; i < parentVertexesList.Length; i++)
				{
					yield return parentVertexesList[i];
				}
				for (int i = 0; i < indexOf; i++)
				{
					yield return parentVertexesList[i];
				}
				yield return parentVertexesList[indexOf];

			}
			return newConduitPoints();
		}


		static public IEnumerable<Point4dblI> Of(
			facet_.gon.Nested gon
		)
		{


			(cycle_.gon_.Antiwise4dbl, Point4dblI) gon1VertexOfMaxX(
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

			var children = gon.holes.ee.ToList();
			IEnumerable<Point4dblI> merged = gon.contour.vertexes;
			while (children.Any())
			{



				var child = gon1VertexOfMaxX(gon.holes.ee);


					merged = _MergeHole(
						merged

				   ,
				   child
			   );
				children.Remove(
					child.Item1
				);

			}

			return merged;




		}

	}
}
