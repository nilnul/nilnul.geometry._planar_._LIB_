using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub_.connected_
{
	/// <summary>
	/// any two points can be connect by a road, which is a path of some thickness (not zero width)
	/// the road is a path-connected, and every point is in a neighborhood of nonnil area. If so, road is synonym to roadable, but roadable can have holes.
	/// This might nonsimple; eg: doughnut.
	/// </summary>
	/// <remarks>
	/// 	 any two points in the roadable must be in a neighborhood, which is a sub(with width and height) of the region. So region might be unbounded
	///		so two roadables sharing only one point, is not regarded as one road.
	///		two roadable sharing one edge, can be regarded as one roadable.
	///
	/// </remarks>
	public interface IRoadable
		:IConnected
	{
	}
}
