using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point
{
	/// <summary>
	/// a moving point (动点) leaves a trail over time. The time is spanned(nondegenerated) interval ( an interval is implicitly  nonempty). So this is a mapping from interval to space point.
	/// 
	/// </summary>
	/// <remarks>
	/// If it's empty, it's trivia, no need to take hold of a new term. (or we can include the trivia case in a broad case)
	/// 
	/// But the time can also be going toward negInf in some case; so you can join two trail, one is going Inf, another is going Inf but regarded as going negInf
	/// alias:
	///		traject
	///		trajectory
	///		track
	///		trace
	///		trail
	///		orbit
	///		The terms trajectory and orbit both refer to the path of a body in space. Trajectory is commonly used in connection with projectiles and is often associated with paths of limited extent, i. e., paths having clearly identified initial and end points. Orbit is commonly used in connection with natural bodies (planets, moons, etc.) and is often associated with paths that are more or less indefinitely extended or of a repetitive character, like the orbit of the Moon around the Earth. //https://history.nasa.gov/conghand/traject.htm
	///
	/// vs:
	///		point.Str
	///			which is discrete.
	///			but trail is continuum.
	///	
	/// </remarks>
	public interface IMoving
	{
	}
}
