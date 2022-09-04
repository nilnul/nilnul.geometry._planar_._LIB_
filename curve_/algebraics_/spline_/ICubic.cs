using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraics_.spline_
{

	/**
 
 Two more equations are required to compute the coefficients of Si(x). These last two constraints are arbitrary, and they can be chosen to fit the circumstances of the interpolation being performed.


there are different ways to add the final two constraints.

	A common set of final constraints is to assume that the second derivatives are zero at the endpoints. This means that the curve is a “straight line” at the end points. Explicitly,

S′′1(x1)=S′′n−1(xn)==0.
This only hold if we have two or more. If we only one piece, then there is no solution, as a cubic poly curve can have only one inflection point.

 */

	/// <summary>
	///
	/// 
	/// </summary>
	/// <remarks>
	/// in docs.microsoft.com/en-us/dotnet/api/system.drawing.drawing2d.graphicspath.addcurve?view=netframework-4.8
	///		spline is converted to bezier.
	/// </remarks>
	public interface ICubic:ISpline
	{

	}



	/*
	 * math.stackexchange.com/questions/1221194/cubic-splines-better-than-quadratic-splines
	 A cubic curve can twist in space (i.e. it can be non-planar). A quadratic curve is just a parabola, so it's always planar.

In real applications like graphic arts, engineering, manufacturing, nobody cares much about derivatives, they only care about curvature. And it's possible to get continuity of curvature without continuity of second derivatives (so-called G2 splines, versus C2 ones). So the C2 argument for cubics is a bit fragile.

For some applications, like design of car bodies or cams, cubic splines are not good enough, because you need continuity of the derivative of curvature (G3 continuity). So, in these applications, higher degree curves are often used.

In many situations, splines are used as approximations of more complex functions. If you use cubics, then you'll need fewer polynomial segments for a given approximation tolerance. But each segment will be more complex, so more difficult to handle in subsequent calculations. That's basically the trade-off -- number of segments versus complexity of segments.
	 ***********/

	/*
	 Cubics become valuable when you start to do 3D work. Quadratic segments are always planar; cubic segments are the lowest degree ones that can be "twisted" in space (i.e. non-planar).

People who design car exteriors generally frown on cubic splines. They like to use Bezier curves, which you can think of as splines that have only a single segment. They typically use degrees up to around 6 or 7.
	 */

	/*
	 The two most important reasons to use cubic splines instead of quadratic:

Cubic splines are C2-continuous, which is handy sometimes
Quadratic splines "ring" a lot. If you move one of the data points, it will make big changes to the whole curve all the way out to the ends. With cubic splines, if you move one of the data points the perturbations along the rest of the curve drop off quickly and decay exponentially -- with each point further away from the one you moved, the size of the change is multiplied by -0.268. (good luck finding that written down in an authoritative text, but it's true!)
	Cubic spline is popular because it is the lowest degree that allows separate control on the two end points and two end derivatives and it is also the lowest degree that allows inflection points. */
}
