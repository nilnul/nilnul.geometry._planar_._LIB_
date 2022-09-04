using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.contiguous.be_
{
	/// <summary>
	/// x=x(t)，y=y(t)，t∈[a,b]
	/// 若在 [a, b] 上 x'(t)，y'(t) 都存在且连续，且 x'(t)，y'(t) 不同时为零，则称曲线 x=x(t)，y=y(t), t∈[a, b] 为光滑曲线。
	///  x'(t) + i y'(t) is a complex number. We thus have a vector field, and each vector is not nil. If the vector is nil, then the next move of the curve is unknown and observer might be at lost(no enough infomation)是茫然的，是“迷向”的.
	/// </summary>
	/// <remarks>
	/// Imaging you drive a car along a road. If the road is smooth, you don't need to brake the car to a halt; you can speed up or slow down, but your car always have some momentum. If the road is not smooth, at some point, you need to brake your car to a complete halt and restart it again.
	/// Why we need introduce two derivatives rather than one? That's becuz the difference between curve and function. Curve can be nonfunction, and we need to take into account of the variation of <var>y</var>.
	/// To define that at the endpoints of a closed interval, we may make it easy to piece together a str of such curves together, like Spline.
	///  Note: differentiable curve may have some points where the derivative is nil; is this true?
	///
	/// If the 
	/// 
	/// </remarks>
	class Smooth
	{
	}
}
