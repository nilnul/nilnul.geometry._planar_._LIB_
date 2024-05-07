using nilnul.bit.func.eq_;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.facet_.gon_._conduit.disord.to_
{
	/// <summary>
	/// untangle
	/// </summary>
	/// <see cref="nilnul.geometry.planar.coil_.gon.to_._Coils4dblX"/>
	/// <see cref="nilnul.geometry.planar.facet_.gon_.conduit.of_.coerce_._MinCuspX"/>
	/// 
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
		static public List<planar.Grad4dbl_byPointsI> _RollForward_0twirl(
			IEnumerable<Point4dblI> vertexes
		)
		{

			var grads = planar.cloze_.gon._Grads4dblX._Grads_ofStarted(
				vertexes
			).ToArray();


			var r = new List<planar.Grad4dbl_byPointsI>();




			var trailStack = new Stack<int>(grads.Length);

			var outwardStack = new Stack<Grad4dbl_byPointsI>(grads.Length);


			for (int i = 0; i < grads.Length; i++)
			{
				Grad4dbl_byPoints currentEdge = grads[i];



				var toCloze = false;
				if (outwardStack.Any())
				{
					if (planar.grad.re_.Opposite4dbl.Singleton.re(outwardStack.Peek(), currentEdge))
					{
						toCloze = true;
					}
				}

				if (
					toCloze
				//trailBack.Any()
				)
				{

					outwardStack.Pop();


					//outwards.Remove(
					//	geometry.planar.grad._ExtensionsX.ToOpposite(
					//	currentEdge
					//	)
					//);

					r.Insert(r.Count - trailStack.Pop(), currentEdge);


					continue;
				}


				///whether the two needs swapped?
				///

				/// as those existant are already ordered.
				///
				/// we need to position this one.
				///




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
												 g.basis,
												 currentEdge.basis
							);
					}).ToArray();


				if (outward8sameStart.Length > 0)
				{
					/// there is already two;
					///

					var inward1st = r.First(
g =>
					{

						return planar.point.EqDbl.Singleton.Equals(
												 g.finish,
												 currentEdge.basis
							);
					}
					);





					var direction =	planar.curl_.elbow._SwingX._Swing_0skid_1final/// for the duct, the swing is -negPi, smallest, and will be placed last. Dont use <see cref="planar.curl_.elbow.swing_._OpenCloseX._Swing_0skid_1final"/>
						(
							inward1st
							,
							currentEdge.finish
					)
					;

					var nextOutward = outward8sameStart.FirstOrDefault( // it's ordered. the incoming nonstrait edge is accounted for by the outgoing nonstrait edge.
						/// for facet, the outgoing nonstrait edge wouldnot be inbetween thoses straits of the same start point.
						o =>
//planar.curl_.elbow._SwingX._Swing_0skid_1final
planar.curl_.elbow.swing_._OpenCloseX._Swing_0skid_1final  /// before currentEdge is opposite to the inward1st, no edge can be opposite. once current edge is opposite, again no other <see cref="outward8sameStart"/> can be opposite. So here <see cref="curl_.elbow.swing_._OpenCloseX"/> or <see cref="curl_.elbow._SwingX"/> makes no difference.
						(
							inward1st
							,
							o.finish
						) < direction
					);

					if (nextOutward is null) /// always null for the one on the hull
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
							nextOutward!
						);


						//outwards.Add(currentEdge, currentTail);

						trailStack.Push(
							r.Count - indexOfNext
						);

						outwardStack.Push(
							currentEdge
						);

						r.Insert(
							indexOfNext   // count is changing
							,
							currentEdge
						);

					}
				}
				else
				{
					if (trailStack.Any())
					{
						r.Insert(
							r.Count -
							trailStack.Peek()    // count is changing
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


		static public List<planar.Grad4dbl_byPointsI> _RollForward_0twirl(
			Point4dblI[] vertexes
		)
		{
			return _RollForward_0twirl(
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
