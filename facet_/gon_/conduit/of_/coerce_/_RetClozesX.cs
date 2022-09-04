using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.facet_.gon_.conduit.of_.coerce_
{

	static public class _RetClozesX
	{

		/// <summary>
		/// apply the conduiting algorithm recursively.
		/// </summary>
		/// <param name="byCoil4Dbl"></param>
		/// <param name="hole"></param>
		/// <returns></returns>
		private static (IEnumerable<Point4dblI>, IEnumerable<int[]>) _MergeHole(
			(IEnumerable<Point4dblI>, List<int[]>) _gon_assumeConduit
			,
			(Antiwise4dbl, Point4dblI) child
		)
		{
			/// the hole must be inside.
			///
			// must be disjoint
			//

			var grads = cloze_.gon._Grads4dblX._Grads_ofStarted(_gon_assumeConduit.Item1);

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
			else  //the rayed is not endpoints of the rayed edge. Let's find a vertex inside 
			{
				var endPointOfParentEdgeRayed = parentEdge1pointCandidate.g.basis.x > parentEdge1pointCandidate.Item1.finish.x ? parentEdge1pointCandidate.g.basis : parentEdge1pointCandidate.g.finish;

				var insideVertexes = _gon_assumeConduit.Item1.Where(
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
					p => planar.tend._VarianceX.Variance(p, child.Item2)
					,
					nilnul.num.real.ComparerDbl.Singleton
				);
				parentEdge1point222 = (parentEdge1pointCandidate.g, parentJointer);
			}

			// now slice the pair as whole.
			//(IEnumerable<Point4dblI>,IEnumerable<IEnumerable<int>>)

			IEnumerable<Point4dblI>	newConduitPoints()
			{
				var list = new List<List<int>>();
				var vertexes2ret = new List<Point4dblI>();

				var childVertexesList = child.Item1.vertexes.ToList();
				var indexOf = childVertexesList.IndexOf(
					child.Item2
				);
				var currentClozeList = new List<int>();
				var currentVindex = 0;
				for (int i = indexOf; i < child.Item1.vertexes.Count(); i++)
				{
					vertexes2ret.Add(
childVertexesList.ElementAt(i)
					);
					currentClozeList.Add(currentVindex++);


					//yield return childVertexesList.ElementAt(i);
				}
				for (int i = 0; i < indexOf; i++)
				{
					vertexes2ret.Add(
						childVertexesList.ElementAt(i)
					);
					currentClozeList.Add(currentVindex++);

					//yield return childVertexesList.ElementAt(i);
				}



					vertexes2ret.Add(
childVertexesList.ElementAt(indexOf)
					);
					currentClozeList.Add(currentVindex++);

				//yield return childVertexesList.ElementAt(indexOf);


				list.Add(currentClozeList);

				//currentClozeList = new List<int>();

				var parentVertexesList = _gon_assumeConduit.Item1.ToArray();

				var parentIndex = Array.IndexOf(parentVertexesList, parentEdge1point222.Item2);

				for (int i = parentIndex; i < parentVertexesList.Length; i++)
				{

					vertexes2ret.Add(parentVertexesList[i]);

					//yield return parentVertexesList[i];
				}

				/// find the cloze in parent.
				/// 
				int clozeIndexInParent = 0;
				var indexCountRemained = parentIndex;  //also the offset+1
				for ( ; ; clozeIndexInParent++)
				{
					var currentClozeVcount = _gon_assumeConduit.Item2.ElementAt(clozeIndexInParent).Count();
					if (
						indexCountRemained < currentClozeVcount
					)
					{
						break;
					}
					indexCountRemained -= currentClozeVcount;
				}

				for (int i = clozeIndexInParent; i < _gon_assumeConduit.Item2.Count(); i++)
				{
					for (int j = 0; j < _gon_assumeConduit.Item2[clozeIndexInParent].Length; j++)
					{
						_gon_assumeConduit.Item2[clozeIndexInParent][j] += ( -parentIndex+ childVertexesList.Count);
					}
				}



				for (int i = 0; i < parentIndex; i++)
				{
					vertexes2ret.Add(parentVertexesList[i]);
					//yield return parentVertexesList[i];

				}


				yield return parentVertexesList[parentIndex];
				/// as a clozed polygon, we will return to the first vertex when this polygon is rendered.

			}

			return newConduitPoints();
		}


		static public IEnumerable<Point4dblI> Of(
			facet_.Gon4dbl gon
		)
		{


			///get the gon which has a vertex of the maxX. return the gon and the vertex.
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

			var children = gon.holes.ee.ToList();
			IEnumerable<Point4dblI> merged = gon.contour.vertexes;
			while (children.Any())
			{
				var child = gon1vertexOfMaxX(children);
				merged = _MergeHole(
					merged
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




		}

	}
}
