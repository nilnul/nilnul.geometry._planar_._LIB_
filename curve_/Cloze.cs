using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_
{
	/// <summary>
	///  at the end, the point can be the start point; in this case, we regard the final point as hollow point, so only the start point is regarded as the moving point.
	/// </summary>
	/// <remarks>
	/// alias:
	///		clozure
	///		cloze
	///			clozure without "ur"
	///			完形
	///				complete the figure/curve.
	///	why it's put under curve_?
	///		1) <seealso cref="nameof(planar.ISub)"/>, cloze is still curve, which is the trail of point over a growing parameter t (often meaning the time)
	///		2) it's easy to close a curve -- just connect the end point with the start point with a dash/lineSegment
	///		3) it's natrual to implement a closue as the wrapper of a curve, and then cloze it.
	///			eg: polygon is the cloze of polyline.
	/// </remarks>
	///
	[Obsolete(nameof(IEndAtStart))]
	public interface ICloze
	{
	}
}
