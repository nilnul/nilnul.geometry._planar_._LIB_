using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.bezier_._cubic_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// The equations independently relate x and y to the value parametric value t. Because of this splines can be extended into three dimensions (or more!) very easily.
	/// </remarks>
	public interface ParameterizedI
		
	{


		/// <summary>
		/// note:
		/// Let s denotes the distance along the path.
		/// d(s) / dt   is not even; it is bigger in the fledging, but smaller in the middle. 
		/// </summary>
		/// <param name="t">a prob as we are sampling a mid point inside the hull</param>
		/// <returns></returns>
		/// <remarks>
		/// As the parameter t varies by a fixed amount, the output points have varying arc-lengths from one to the next. This characteristic of the Bézier formula is what causes the text to be compressed or stretched along the curve.
		/// </remarks>
		Point4dblI _interpolate_assumeProb(double t);

	


	}
}
