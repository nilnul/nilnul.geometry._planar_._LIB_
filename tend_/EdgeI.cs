using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend_
{
	/// <summary>
	/// In geometry, a line edge is a part of a line that is bounded by two distinct end points, and contains every point on the line between its endpoints. 
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// <seealso cref="nameof(ArrowI)" /> if the direction is important
	/// <seealso cref="nameof(SegI)"/> if the two points can be eq
	/// alias:
	///		seg
	///		edge
	public interface EdgeI
		:TendI
	{
		nilnul.geometry.planar.point.twin_.Dif pair { get; }
	}
}
