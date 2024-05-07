using nilnul.bit.func.eq_;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.facet_.gon._conduit.cuspUnordered.to_
{
	static public class _MinCuspX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="vertexes">
		/// coil_.gon
		/// </param>
		/// <returns></returns>
		/// <see cref="nilnul.geometry.planar.coil_.gon_.conduit.to_._Cycles4dblX"/>
		static public List<planar.Grad4dbl_byPointsI> _CoilsByRemoveDuct_0coil(
			IEnumerable<Point4dblI> vertexes
		)
		{

			var grads = planar.cloze_.gon._Grads4dblX._Grads_ofStarted(
				vertexes
			).ToArray();


			var r = new List<planar.Grad4dbl_byPointsI>();



			//var straits = new List<
			//	(Grad4dbl_byPointsI, Grad4dbl_byPointsI)    //always prowind (as in gon). if one two ducts share same peg, then the duct with smallest angle shall be traversed first, otherwise, the traversal would bridge the 
			//>();

			var coils = new List<List<planar.Grad4dbl_byPointsI>>();


			//var vertices8list = vertexes.ToList();

			var trailDict = new Dictionary<Grad4dbl_byPointsI, int>(
				nilnul.geometry.planar.grad.Eq4dbl.Singleton
			);
			//var trail = 0;

			var trailStack = new Stack<int>(grads.Length);


			var hullHalf =  new List<planar.Grad4dbl_byPointsI>();
			var currentCycle = hullHalf;// new List<planar.Grad4dbl_byPointsI>();

			for (int i = 0; i < grads.Length; i++)
			{
				Grad4dbl_byPoints currentEdge = grads[i];


				var opposite = grads.FindIndex(
					g => planar.grad.re_.Opposite4dbl.Singleton.re(g, currentEdge)
				);

				if (opposite == -1)
				{

					//not found
					currentCycle.Add(currentEdge);
				}
				else
				{
					// we need to cut the list
					var firstList = currentCycle.GetRange(0, opposite); // might be empty

					var secondList = currentCycle.GetRange(opposite, currentCycle.Count - opposite);

					secondList.Add(currentEdge);

					if (firstList.Any())
					{
						coils.Add(firstList);
					}

					//cycles.Add(firstList);



					var otherCoils=coils.Where(
						c=> planar.point.EqDbl.Singleton.Equals(   c.First().basis , secondList.First().basis)
					).ToArray();


					if (otherCoils.Length>1)
					{
						var firstEdge = otherCoils[0].First();

						var direction = planar.grad_.skid.co_.angular._DirectionX._Direction_0skid_1nonhinge(
										firstEdge
										,
										secondList.First().finish
								)
								;

						var t = otherCoils.Skip(1).FirstOrDefault( // it's ordered. the incoming nonstrait edge is accounted for by the outgoing nonstrait edge.
							/// for facet, the outgoing nonstrait edge wouldnot be inbetween thoses straits of the same start point.
							o => planar.grad_.skid.co_.angular._DirectionX._Direction_0skid_1nonhinge(
								firstEdge
								,
								o.First().finish
							) > direction
						);


					}
					else
					{
						coils.Add(secondList);

					}


					currentCycle = new List<Grad4dbl_byPointsI>();
				}
			}

			if (currentCycle.Any())
			{
				coils.Add(currentCycle);
			}

			{


				var trailBack = trailDict.Where(
					k => planar.grad.re_.Opposite4dbl.Singleton.re(k.Key, currentEdge)
				).Take(1);




				if (trailBack.Any())
				{

					trailDict.Remove(
						geometry.planar.grad._ExtensionsX.ToOpposite(
						currentEdge
						)
					);

					//trail -= trailBack.First().Value;

					trailStack.Pop();

					r.Add(currentEdge);

					continue;
				}


				var repeated = r.Where(
					p => planar.grad.Eq4dbl.Singleton.Equals(
						p, currentEdge
					)
				); // take the currpent point as the incoming edge,


				///whether the two needs swapped?
				///

				/// as those existant are already ordered.
				///
				/// we need to position this one.
				///

				var firstIncoming = repeated.First();
				var outgoing = repeated.First();



				//var index = r.Indexes(
				//	g => planar.grad.re_.Opposite4dbl.Singleton.re(g, grads[i])
				//);

				/// as an outgoing edge:
				///
				/// whether there are already some edge outgoing from the same point?
				///

				var outward8sameStart = r.Where(  //https://stackoverflow.com/questions/6146724/do-linqs-enumerable-methods-maintain-relative-order-of-elements#6146742
					/// order is preserved
					g =>
					{

						return planar.point.EqDbl.Singleton.Equals(
												 g.basis, currentEdge.basis
											);
					}).ToArray();

				if (outward8sameStart.Length > 1)
				{
					/// there is already two;
					///

					var firstEdge = outward8sameStart.First();

					//Grad4dbl_byPoints edge = grads.ElementAt(i);

					var direction = planar.grad_.skid.co_.angular._DirectionX._Direction_0skid_1nonhinge(
							firstEdge
							,
							currentEdge.finish
					)
					;

					var t = outward8sameStart.Skip(1).FirstOrDefault( // it's ordered. the incoming nonstrait edge is accounted for by the outgoing nonstrait edge.
						/// for facet, the outgoing nonstrait edge wouldnot be inbetween thoses straits of the same start point.
						o => planar.grad_.skid.co_.angular._DirectionX._Direction_0skid_1nonhinge(
							firstEdge
							,
							o.finish
						) > direction
					);

					if (t is null)
					{
						if (trailStack.Any())
						{
							r.Insert(
								r.Count - trailStack.Peek()
								, currentEdge
							);
						}
						else
						{
							r.Add(
								currentEdge
							);

						}

					}
					else
					{
						var indexOfNext = r.IndexOf(
							t
						);


						int currentTrail = r.Count - indexOfNext;

						trailDict.Add(currentEdge, currentTrail);



						r.Insert(
							r.Count -
							currentTrail    // count is changing
							,
							currentEdge
						);

					}
				}
				else
				{
					if (trailStack.Any())
					{
						var t = trailStack.Peek();
						r.Insert(
							r.Count -
							t    // count is changing
							,
							currentEdge
						);

					}
					else
					{
						r.Add(currentEdge);
					}
				}

			}
			/// <see cref="gon_.conduit.of_.coerce_._MinCuspX"/> logic is reused - each strait is reinserted to ensure the order.
			/// the latter stait shall be placed latter.
			///




			/// if there are already other straits pegged at the same point?
			///



			return r;
		}


		static public List<List<planar.Grad4dbl_byPointsI>> _CoilsByRemoveDuct_0coil(
			Point4dblI[] vertexes
		)
		{
			return _CoilsByRemoveDuct_0coil(
				(IEnumerable<Point4dblI>)vertexes
			);

		}

		//[Obsolete(nameof(_Coils_removeConduit))]
		//static public List<List<planar.Grad4dbl_byPointsI>> _Coils_removeConduit(
		//		Point4dblI[] vertexes
		//	)
		//{
		//	return _Coils_removeConduit(vertexes);
		//}
	}
}
