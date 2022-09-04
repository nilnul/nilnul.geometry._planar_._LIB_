using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// curve is a continuous, directed, spanned(the length is not nil) one-dimentional straint/nonstraight line.
	/// It's ordered, and unorded curve is later defined on this as <see cref="nilnul.obj.TwinI{T}"/>: one must know order before he can ignore it.
	/// </summary>
	/// <remarks>
	/// vs trail, we keep the point.Set, but neglect:
	///		1) the timing. ie, the order of points
	///		2) the repeating of points. If a point is reached two times, such at a crossing, the point is regarded as one element.
	/// 
	/// stretch of a point.
	/// of length gt 0 or eq 0.
	/// the curve is contiguous
	///
	/// The curve shouldn't interset with it self.
	/// the length of the curve can  be infinite. for example, the plot of a function.
	///  single point is included. So in svg, a path or line can be a single point, or with two ends the same.
	///	to exclude singlePoint, use curve_.Nonpoint.
	/// 
	///  A continuous 1D set of points in 2D (or 3D)
	///  
	///  A mapping from an interval S onto the plane
	///		This means that a curve can always be parameterized by a single parameter "t", which is often the time/speed, resulting a curve named trajectory/trail.
	/// </remarks>
	/// alias: track
	///		curve
	///			'c' is also the start of <see cref="continuous"/>
	public interface ICurve :
trail_.IDimOne       //trail_.INonpoint
	{
	}
}
