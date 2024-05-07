using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.facet_.gon.to_
{

	/// recursively find chords. but vs <see cref="planar.zone_.gon_.nontri._ChordX"/> which might cut off an ear of the hull, this will always cut by the connecting line from the hole to the hull
	///
	/// <summary>
	/// <see cref="gon_.conduit.of_._Coerce4dblX"/>
	/// </summary>
	/// <remarks>
	/// for one hole case, this works fine.
	/// for more than one holes,this might result more than two parts.
	/// for cutting into at most two parts, we need to conduit the holes, zigzagly some times in order to remain  inside the hull. That is complex for us now. Let's defer it:
	///		ensure it's in hull. so zigzag conduct is needed.
	///		ensure it's on vertex, not sides
	///		ensure conduit not blocked by other holes in between.
	///		the conduit might be a smooth curve, not only polyline.
	/// </remarks>
	/// alias:
	///		bifurcate
	///		slice
	///		fissure
	///		breach
	///
	static public class _SplitToAdjacentZonesX
	{

		


		static public IEnumerable<IEnumerable<Point4dblI>> ToAdjacentZones(
			facet_.Gon4dbl gon
		)
		{

			var conduit = gon_.conduit.of_.coerce_._MinCuspX.Of(gon);

			return gon_.conduit.to_._CrackToAdjacentZonesX._ToAdjacentZones_0conduit(conduit);

		}
	}
}