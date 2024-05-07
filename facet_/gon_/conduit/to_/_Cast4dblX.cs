using nilnul.obj.str.be_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.facet_.gon_.conduit.to_
{

	/// <summary>
	/// 
	/// </summary>
	static public class _Cast4dblX
	{

		/// <see cref="coil_.gon_.conduit.be_._FacetX"/>
		/// <see cref="coil_.gon_.conduit.be_._IslandsX"/>
		/// 
		/// <summary>
		/// </summary>
		/// <param name="vertexes"></param>
		/// <returns></returns>
		/// <exception cref="System.Exception"></exception>
		static public facet_.Gon4dbl _RemoveCuts_assumeConduit(
			Point4dblI[] vertexes
		)
		{
			var hull9holes = coil_.gon_.conduit._HullAndHolesX._HullWithHoles_0conduit(vertexes);

			//var cycles = coil_.gon_.conduit.to_._Cycles4dblX._Cycles_assumeConduit(vertexes); //disjoint



			///disjoint 
			return new facet_.Gon4dbl(
				hull9holes.hull.Select(g=>g.basis)
				,
				hull9holes.holes.Select(gs=> gs.Select(g=>g.basis))
			);

		}
	

	}
}