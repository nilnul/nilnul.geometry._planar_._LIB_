using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraics_.spline_
{
	/*******************
	 
	Well, actually, you can use quadratic splines for many purposes. They are used to design TrueType fonts, for example. 
	 */
	interface IQuadratic
		:IUnnatural		// this is not natural. To solve quadratic equation, we need 3 constraints. The two endian points present two; the last one shall be split into two halves. So each point shall present an additional half constraint; this can be achieved by the middle points, as the point can bring put one and shared by flanking pieces. But this cannot be achieved by the outlier point.
	{
	}
}
