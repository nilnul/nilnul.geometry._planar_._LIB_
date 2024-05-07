using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// 
	/// this might be non-manifold.And it could be constructed by other simpler objects. So we might leave this definition deferred on others, say <see cref="zone.co_.Tangent"/>
	/// <summary>
	/// for example:
	///		8 filled
	///			the neighborhood of the intersection point is not homology to a 2d euler space. It cannot be mapped continuously(in 2d sense) to a 2d euler space.
	/// </summary>
	/// <remarks>
	///		
	/// </remarks>
	/// alias:
	/// 
	///		sweep
	///		spasmodic
	///		sprawl
	///		sporadic
	///		spew
	///		spread
	///		scattered
	///		splatter
	///		spatter
	///		splash
	public interface ISplash
		:
		manifold_.IDimTwo
		, ITrack
	{
	}
}
