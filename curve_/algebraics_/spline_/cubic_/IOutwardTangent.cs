using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraics_.spline_.cubic_
{

	/// <summary>
	/// for a pair of two points among a str of points, we draw a poly curve of degree3rd, a+bx+cx^2+dx^3=y, to connect the two points such that:
	///		* for outer two points, 
	///			** the 1st derivatice is preset.
	///		* for nonouter point, the derivatives of the flanking pieces must be equal. the degree2nd derivatice must be equal too.
	///	These will give you 4 constraints for the piece of spline, and the coeefficents can be pinned down.
	///
	/// middle points have more impact than outlier points.
	/// 
	/// </summary>
	public interface IOutTangent:spline_.ICubic, spline_.INatural
	{

	}



}
