using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraics_.spline_.cubic_.noninfectOut_
{
	/***********
	 Two more equations are required to compute the coefficients of Si(x). These last two constraints are arbitrary, and they can be chosen to fit the circumstances of the interpolation being performed. A common set of final constraints is to assume that the second derivatives are zero at the endpoints. This means that the curve is a “straight line” at the end points. Explicitly,

S′′1(x1)=S′′n−1(xn)==0.
	This only hold if we have two or more. If we only one piece, then there is no solution, as a cubic poly curve can have only one inflection point.

there are different ways to add the final two constraints.

		///			** this seems to result no solution as we require the two order2nd derivatives the same, and the points have to be same horizoned.

	 */

	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete("If we only one piece, then there is no solution, as a cubic poly curve can have only one inflection point.",true)]
	class TwoPoints
		:

		ICubic
	{


		public TwoPoints(
			Point4dblI start
			
			,
			Point4dblI end
			

		)
		{


		}

	}



}
