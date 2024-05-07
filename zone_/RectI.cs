using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_
{
	/// <summary>
	/// four points .
	/// 
	/// Note: Rect have directions. If direction doesn't matter, use another Eq.
	/// </summary>
	/// <remarks>
	/// this and <see cref="ITrigon"/> are the only two <see cref="IGon"/> that are promoted from under <see cref="IGon"/>;
	/// </remarks>

	public interface IRect
		:
		nilnul.geometry.planar.cycle_.gon_.quad_.convex_.IRect
		,
		zone_.gon_.parlgrm_.IOrthic
	{


	}
}
