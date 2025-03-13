using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.drawable.hull_.convex_
{
	/// <summary>
	/// each edge cannot be moved on its normal vector to make the hull smaller.
	/// for nonstraight edge, the above holds in converging sense.
	/// </summary>
	/// <remarks>
	/// imaging a rubber band is wrapping around the flat.
	/// </remarks>
	/// alias:
	///		contour
	/// 
	internal interface IConstrict:INonconcave
	{
	}
}
