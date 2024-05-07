#if DEBUG

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_.conduit_.flake.of_.err_
{
	/// <summary>
	/// holes. zone but with negative winding.
	/// </summary>
	/// <remarks>
	/// we intend to connect the holes in <see cref="facet_.IGon"/> as a whole.
	/// Then make two conducts from the hull to both directions of the whole, thus cut the facet into two.
	/// But it turns out the hull can be such as U-shaped.  directly conduit holes , then the conduit can be in the central blank area of the "U". so the conduit would cross the hull, which is unintended.
	///
	/// So this approach wouldnot work.
	///
	/// We need to revert back to the x-ray cast approach:
	///		- first rightmost conduits to outside the hull
	///		- then leftmost conduits to the other side of the hull
	///	, in the end we might part the facet into more than 3 pieces, not optimal. But as said earlier, the approach in try to only cut into 2 pieces doesnot work out for now.
	/// </remarks>
	/// alias:
	///		ofHoles
	internal class IAntizones
	{
	}
}
#endif