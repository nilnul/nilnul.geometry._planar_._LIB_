using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraics_.spline_.cubic_
{
	/**
	 
	A common set of final constraints is to assume that the second derivatives are zero at the endpoints. This means that the curve is a “straight line” at the end points.
	Explicitly,

S′′1(x1)=S′′n−1(xn)==0.
	

	 */

	/// <summary>
	/// for a pair of two points among a str of points, we draw a poly curve of degree3rd, a+bx+cx^2+dx^3=y, to connect the two points such that:
	///		* for outer two points, the 2nd derivatice is 0.
	///			** the 1st derivatice is arbitrary.
	///		* for nonouter point, the derivatives of the flanking pieces must be equal. the degree2nd derivatice must be equal too.
	///	These will give you 4 constraints for the piece of spline, and the coeefficents can be pinned down.
	/// 
	/// </summary>
	public interface IOutInflect
		:
		spline_.ICubic,

		spline_.IUnnatural		//This only hold if we have two or more. If we only one piece, then there is no solution, as a cubic poly curve can have only one inflection point.

	{

	}



}
