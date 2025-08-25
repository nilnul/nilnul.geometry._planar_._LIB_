using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.roulette_.cog_.hypo_.cyc_
{
	/// <summary>
	/// the inner radius is half.
	/// The curve is a straight line back and forth. 
	/// </summary>
	/// <remarks>
	/// Thsi demostrates that Fourier Transformation can make rotations added to straight line motion.
	/// Some toy is made according to this: beads moving back and forth, forms a circ, rotating inside another big circle;
	/// </remarks>
	/// the speed is variating?
	/// ans: yes;
	/// actually, the locus of the center of the inner circle is:
	///		E(t) = e^(it)
	///	the locus of the point on the edge of the inner circle, rotating with respect to its center:
	///		E(-t)
	///	, where -t is calculated by:
	///		mark the tangent point, and rotate the inner circle, the mark will stop at Tau*1, where 1 is the radius of the inner circle; the circumference of the outer circle is Tau*2, so the mark stops at the semicircle; observing the radius of the inner circle, it's perpendicular to the outer circle at the start and the stop. the two radii form an angle which is thus the centrifugal angle of the outer circle, which is now Pi.  That means when the center rotates pi, the peripheral point rotates -pi.
	///
	/// ; adding the two vects, we get the final locus:
	///		E(t) + E(-t)
	///	, which is Discrete Fourier transform at two terms.
	///; the result can be simplified to :
	///		2Cos(t)
	///	, which is without imaginary part, hence it's moving along the real axis. The speed is  d( 2Cos(t)  ) /dt =- 2Sin(t)
	/// , as the time starts when the locus is at (1,0), so it moves towards -inf. So the speed is negative initially.
	///		
    class ITulsi
    {
    }
}
