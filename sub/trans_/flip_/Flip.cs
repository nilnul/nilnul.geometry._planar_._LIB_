using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_.linear_.rigid_
{
	/// <summary>
	/// rotate along an axis rather than a point; hence need to be done in 3d space.
	/// note: flip can be done along any line, even a line outside the shape.
	/// alias:
	///		flip
	///		improper
	/// </summary>
	/// <remarks>
	////// we cannot do this in plane. instead we do this in cubic coordes where z=1, and we do this by rotating with plane at z=1 reamained at the plane z=1.
	/// alias:
	///		reflect
	///		reflection
	/// </remarks>
	class Flip
	{
	}
}
