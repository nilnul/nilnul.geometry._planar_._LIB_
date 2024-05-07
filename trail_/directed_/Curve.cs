using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trail_.directed_
{
	/// <summary>
	/// no intersection. but at the end, the point can be the start point; in this case, we regard the final point as hollow point, so only the start point is regarded as the moving point. countable intersection is not important for curve.
	/// could be infinite
	/// </summary>
	/// <see cref="planar.ICurve"/>
	/// nonpoint
	/// 
	public interface INonpoint
		:IDirected
	{
	}
}
