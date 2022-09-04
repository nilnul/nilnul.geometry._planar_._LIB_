using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_
{
	/// <summary>
	/// in topology, (nonempty) interval mapping to space  is called trail here.
	/// Importantly, a trail is not just a subset , it also includes a parameterization.
	/// 
	/// 
	/// </summary>
	/// <remarks>
	/// a point moves. at any finite timePeriod, the displace moved is finite.
	/// the trail can self-intersect.
	/// can be infinite
	///
	/// Is every curve transformable to trail?
	/// 
	/// alias:
	///		locus
	///		trail
	///		trace
	///		orbit
	///		track
	///		path
	///		curve
	/// </remarks>
	public interface ITrail: point.IMoving
	{
	}
}
