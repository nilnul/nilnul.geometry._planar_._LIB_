using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vwer.rotation.be_._positive_.by_
{
	/// <summary>
	/// curl the palm (the 4 nonthumb fingers) such that they first follows the x axis, then y axis, to form a coil,
	/// ,then the thumb points to a direction. remember this direction, which is the cononical direction.
	///
	/// for any other rotation, let the palm (the 4 nonthumb fingers) curl along the rotation, and observer the thumb's direction. If that's the same as the canonical direction, then the rotation is positive.
	/// 
	/// <see cref="planar.rotation.be_._positive_.by_.IHand"/>
	/// </summary>
	/// <remarks>
	/// for the positive rotation, the enclosed area is the inside; for negative rotation, the enclosed is the outside. So it's rotation that determines the sign of the stokes surrounded signed area, not the other way around.
	/// </remarks>
	internal class IHand
	{
	}
}
