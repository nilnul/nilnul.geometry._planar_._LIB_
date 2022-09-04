using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.manifold_
{
	/// <summary>
	///	 no intersection for curve
	///	 no hole for sufface.
	///	eg:
	///		circle
	///			which is a manifold, as it's chartable to 1d everywhere.
	///			 it's cloze; but we can treat it as clopen: closed at one point and open at the other end
	///	 countereg:
	///		cross that is nontria
	///			intersected.
	///			it cannot be mapped to time interval uniformly continuously.
	/// </summary>
	public interface ISimple:IManifold
	{
	}
}
