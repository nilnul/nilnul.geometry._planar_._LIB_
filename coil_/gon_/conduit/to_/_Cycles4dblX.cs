using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.coil_.gon_.conduit.to_
{

	/// <summary>
	/// 
	/// </summary>
	/// <param name="vertexes">
	/// assume conduits means that the incident edges are all <see cref="coil_.gon.skid.co.be_.Cut"/>, or for incident edges, there are two and only two, and the two must be opposite.
	/// </param>
	/// <returns>
	/// cuts are removed. other such as:
	///		cross skids,
	///		or
	///		incident partially(or not fully)
	///
	/// disjoint coils
	/// </returns>
	static public class _Cycles4dblX
	{
		/// <summary>
		/// remove conduit
		/// </summary>
		/// <param name="vertexes">
		///coil_.gon_.Conduit;
		/// </param>
		/// <returns>disjoint cycles </returns>
		static public List<List<planar.Grad4dbl_byPointsI>> _Cycles_assumeConduit(
			IEnumerable<	Point4dblI> vertexes
		)
		{
			return nilnul.geometry.planar.coil_.gon.to_._Coils4dblX._CoilsByRemoveDuct_0coil(vertexes);

		}

		static public List<List<planar.Grad4dbl_byPointsI>> _Cycles_assumeConduit(
			Point4dblI[] vertexes
		)
		{
			return nilnul.geometry.planar.coil_.gon.to_._Coils4dblX._CoilsByRemoveDuct_0coil(vertexes);

		}


	}
}