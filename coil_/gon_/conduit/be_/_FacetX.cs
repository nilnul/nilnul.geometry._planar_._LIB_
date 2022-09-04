using nilnul.obj.str.be_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.coil_.gon_.conduit.be_
{

	static public class _FacetX
	{
		static public bool _Be_assumeConduit(
			Point4dblI[] vertexes
		)
		{
			var cycles = coil_.gon_.conduit.to_._Cycles4dblX._Cycles_assumeConduit(vertexes); //disjoint

			var maxes = nilnul.rel_.net_.poset.nodes_._MaximalX._Maximal_funcAssumeGt(
				cycles
				,
(vs, vs1)=>planar.cycle_.gon.co_.nonjoint.be_._Torus4dblX._Be_cyclesAssumeNonjoint(vs1,vs)
			);
			if (maxes.None() )
			{
				return false;
			}

			var contour=maxes.Single();

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
			return cycles.All(
				c=> cycle_.gon.be_.stokes_.Neg.Singleton._be_assumeCycle(c)
				&&
				cycle_.gon.co_.nonjoint.be_.torus_._Seige4dblX._Be_assumeNonjoint(
					contour,c
				)
			) ;


		}
	

	}
}