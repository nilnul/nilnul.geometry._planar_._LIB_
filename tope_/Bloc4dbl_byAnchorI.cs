using nilnul.geometry.planar._area;
using nilnul.geometry.planar.tope_._bloc;
using nilnul.num.real.bound_;
using System.Collections.Generic;
using System.Drawing;

namespace nilnul.geometry.planar.tope_
{
	/// <summary>
	/// this is easy to follow, and hard to mistake the constraints that the point must be at the lowestMinimal corner, in case, for example, that a bloc defined by a vector, where the start point is not the lowestMinimal corner.
	/// </summary>
	public interface Bloc4dbl_byAnchorI
		:
		_bloc_.AnchorI
		,
		_bloc_.SizeI
	{

	}
}