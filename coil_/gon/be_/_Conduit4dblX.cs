using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.geometry.planar.point.str_;
//using nilnul.geometry.planar.point.str_.started;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
using nilnul.obj.str.be_;

namespace nilnul.geometry.planar.coil_.gon.be_
{
	/// <summary>
	/// if two edges are incident, the two edges must be:
	///		* in opposite direction
	///		* endpoints are incident. They cannot be different in length.
	///	the cut connects two disjoint gon
	/// </summary>
	/// after removing the conduit,
	///		we may be left with:
	///			nothing. (two dots are removed along with the cut)
	///			two disjoint cycles
	///				might be one in the other
	///				or not
	///			,<see cref="facet_.gon_.conduit.INested"/>
	///			, <see cref="facet_.gon_.conduit.INested"/>.opposite|contra
	///		
	static public class _Conduit4dblX
	{
		/// <summary>
		///
		/// </summary>
		/// <param name="_arrows_froPolyDifPoints"></param>
		/// <param name="allowance"></param>
		/// <returns></returns>
		static public bool _Be_assumeCoil(
			IEnumerable<grad_.Skid4dblI> _arrows_froPolyDifPoints
			,
			double allowance = 0.001
		)
		{
			var coils = coil_.gon.to_._Coils4dblX._CoilsByRemoveDuct_0coil(
				_arrows_froPolyDifPoints.Select(g=>g.basis).ToArray()
			);

			return coils.All(
				c=> coil_.gon.be_.poly_.Cycle4dbl.Singleton.be(c.Select(g=>g.basis))
			); // either holes, or islands, or conduit.nest.

		}

		static public bool _Be_assumeCoil(IEnumerable<Point4dblI> _points_polyDif)
		{
			return _Be_assumeCoil(
				_GradsX.Grads(_points_polyDif).Select(x => new grad_.Skid4dbl(x))
			);
		}



		
	}
}