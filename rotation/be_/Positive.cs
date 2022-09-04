using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.be_
{
	/// <summary>
	/// for cartesian coordinates plane, when x-positive-ray is rotating to y-positive ray, the rotation is positive.
	/// note positive is not same as counterclock, as:
	///		1) positive is relative to a coordinates plane. for computer screen, the y points downwards, so positive roatation is clockwise.
	///		2) counterclockwise is relative to the a upright person who is viewing a wall, on which there is a clock on. If the y positive upwards, counterclockwise is positive;
	///			but if the person uses a coordinating system where y points downward, for example, on computer screen, then counterclockwise is negative,
	///				and clockwise is positive.
	/// </summary>
	/// <remarks>
	/// alias:
	///		clock
	///			as the default planar coordinates system is <see cref="nameof(planar_.ergo_.canvas_.screen_.IRightHanded)"/>
	///		crank
	///			as we are right handed. So when we crank a wheel (for example a tractor), we apply the force from left to right, from top to down
	///				
	/// </remarks>
	interface IPositive
	{
	}
}
