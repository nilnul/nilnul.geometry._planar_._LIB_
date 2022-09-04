using nilnul.obj.str.be_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.facet_.gon_.conduit.to_
{

	static public class _Cast4dblX
	{
		static public facet_.Gon4dbl _RemoveCuts_assumeConduit(
			Point4dblI[] vertexes
		)
		{
			var cycles = coil_.gon_.conduit.to_._Cycles4dblX._Cycles_assumeConduit(vertexes); //disjoint

			var maxes = nilnul.rel_.net_.poset.nodes_._MaximalX._Maximal_funcAssumeGt(
				cycles
				,
(vs, vs1)=>planar.cycle_.gon.co_.nonjoint.be_.torus_._Seige4dblX._Be_assumeNonjoint(vs1,vs)
			);

			if (maxes.None() )
			{
				throw new System.Exception(
					$"There is no contour in {cycles}"
				);
			}
			//if (maxes.Count() >1)
			//{
			//	throw new Exception(
			//		$"as {cycles} is disjoint, there cannot be two contours."
			//	);
			//}

			var contour=maxes.Single();

			cycles.Remove(
				 contour
			);

			///disjoint 
			return new facet_.Gon4dbl(
				contour.Select(g=>g.basis)
				,
				cycles.Select(gs=> gs.Select(g=>g.basis))
			);

		}
	

	}
}