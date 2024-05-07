using nilnul.geometry.planar.drawable_.bounded;
using nilnul.obj.str.be_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.facet_.gon_.conduit
{

	/// <summary>
	/// get the hull
	/// </summary>
	static public class _HullX
	{

		/// <see cref="coil_.gon_.conduit.be_._FacetX"/>
		/// <see cref="coil_.gon_.conduit.be_._IslandsX"/>
		/// 
		/// <summary>
		/// </summary>
		/// <param name="vertexes"></param>
		/// <returns></returns>
		/// <exception cref="System.Exception"></exception>
		static public List<Grad4dbl_byPointsI>  _Hull_0conduit(
			IEnumerable<Point4dblI> vertexes
		)
		{
			var cycles = coil_.gon_.conduit.to_._Cycles4dblX._Cycles_assumeConduit(vertexes); //disjoint


			var contour = cycles.First(
					c => planar.cycle_.gon.be_.stokes_.Positive._Be_0cycle(c)
				);

			return contour;
		}
		static public List<Grad4dbl_byPointsI>  _Hull_0conduit(
			Point4dblI[] vertexes
		)
		{
			var cycles = coil_.gon_.conduit.to_._Cycles4dblX._Cycles_assumeConduit(vertexes); //disjoint


			var contour = cycles.First(
					c => planar.cycle_.gon.be_.stokes_.Positive._Be_0cycle(c)
				);

			return contour;
		}

	

	}
}