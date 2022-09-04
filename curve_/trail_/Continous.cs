using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.trail_
{
	/// <summary>
	/// in topology, nonempty and nondegenerate interval mapping to space continuously is called trail here.
	/// Importantly, a trail is not just a subset of X that "looks like" a curve, it also includes a parameterization.
	/// 
	/// 
	/// </summary>
	/// <remarks>
	/// 
	/// alias:
	///		trail
	///		track
	///		path
	///		curve
	/// </remarks>
	public interface IContinuous: point.IMoving
	{
	}
}
