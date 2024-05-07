using nilnul.geometry.planar.drawable_.bounded;
using nilnul.obj.str.be_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.coil_.gon_.conduit
{

	/// <see cref="to_.IToHullAndHoles"/>
	/// <summary>
	/// get the hull and the holes.
	/// the hull is prowind, each hole is conwind.
	/// </summary>
	static public class _HullAndHolesX
	{

		/// <see cref="coil_.gon_.conduit.be_._FacetX"/>
		/// <see cref="coil_.gon_.conduit.be_._IslandsX"/>
		/// 
		/// <summary>
		/// </summary>
		/// <param name="vertexes"></param>
		/// <returns></returns>
		/// <exception cref="System.Exception"></exception>
		static public (List<Grad4dbl_byPointsI> hull, List<List<Grad4dbl_byPointsI>> holes) _HullWithHoles_0conduit(
			IEnumerable< Point4dblI> vertexes
		)
		{
			var cycles = coil_.gon_.conduit.to_._Cycles4dblX._Cycles_assumeConduit(vertexes); //disjoint

			var contour=cycles.First(
				c=> planar.cycle_.gon.be_.stokes_.Positive._Be_0cycle(c)
			);


//			var maxes = nilnul.rel_.net_.poset.nodes_._MaximalX._Maximal_funcAssumeGt(
//			cycles
//			,
//(vs, vs1) => planar.cycle_.gon.co_.nonjoint.be_.nest_._Seige4dblX._Be_assumeNonjoint(vs, vs1)
//		);


//			if (maxes.None())
//			{
//				throw new System.Exception(
//					$"There is no contour in {cycles}"
//				);
//			}
			//if (maxes.Count() >1)
			//{
			//	throw new Exception(
			//		$"as {cycles} is disjoint, there cannot be two contours."
			//	);
			//}

			//var contour = maxes.Single();


			cycles.Remove(
				 contour
			);

			return (contour,cycles);
		}

	
	}
}