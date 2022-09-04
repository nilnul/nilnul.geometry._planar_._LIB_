using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub_.connected_.simple_
{
	/// <summary>
	/// any two points can be connect by a road, which is a path of some thickness (not zero width)
	/// the road is a path-connected, and every point is in a neighborhood of nonnil area. If so, road is synonym to roadable, but roadable can have holes.
	/// </summary>
	/// manifold-2d at any point.
	///		excluded point,curve.
	public interface IRoadable
		:
		ISimple,
		connected_.IRoadable
	{
	}
}
