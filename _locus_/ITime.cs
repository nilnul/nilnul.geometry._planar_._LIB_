using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._locus_
{
	/// <summary>
	/// if time is regarded as one dimension of the spatial, then the trail(<see cref="planar.ITrail"/>) of the point is a continuity of planes each of which is perpendicular to the time axis. On each of the plane, the point is at a new location. Only when we accumulate the point from each plane when we can see the overall trail.
	/// Thus, the time is better not regarded as one dimension of the space, but as a mapping to the real world time when a viewer is consuming the trail model.
	/// </summary>
	/// <remarks>
	/// eg:
	///		timed <see cref="planar.ITroll"/> is <see cref="planar.ITrail"/> when untimed (now 2d, without the 3rd dimension of time). We should always favor the timed model, and take that as the backbone of terminology. Untimed terms are then derived.
	/// </remarks>
	class ITime
    {
    }

}
