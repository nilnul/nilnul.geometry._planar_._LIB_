using nilnul.obj.str.be_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.coil_.gon_.conduit.be_
{

	/// <summary>
	/// the conduit can be two disjoint coil conduited by a bridge in between the two peer islands.
	/// each island is positively winded, not lagoon that is negatively winded.
	/// </summary>
	static public class _IslandsX
	{
		static public bool _Be_assumeConduit(
			Point4dblI[] vertexes
		)
		{
			var cycles = coil_.gon_.conduit.to_._Cycles4dblX._Cycles_assumeConduit(vertexes); //disjoint

			var maxes = nilnul.rel_.net_.poset.nodes_._MaximalX._Maximal_funcAssumeGt(
				cycles
				,
(vs, vs1) => planar.lop_.gon.co_.nonjoint.be_.torus_._Seige4dblX._Be_assumeNonjoint(vs, vs1)  // we need an acyclic relation
			).ToArray();

			if (maxes.None())
			{
				return false;
			}


			//var contour=maxes.Single(); thre might be multiple

			foreach (var contour in maxes)
			{
				if (
					cycle_.gon.be_.stokes_.Neg.Singleton._be_assumeCycle(
					contour
					)
				)
				{
					return false;
				}

				cycles.Remove(
					 contour
				);

			}

			return cycles.All(
				c => cycle_.gon.be_.stokes_.Neg.Singleton._be_assumeCycle(c)
				&&
				maxes.Any(
					contour=>
					cycle_.gon.co_.nonjoint.be_.nest_._Seige4dblX._Be_assumeNonjoint(
						contour, c
					)
				)
			);


		}


	}
}