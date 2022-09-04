using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.gon.vsPoint.be_.fill_
{
	/*
	 The Winding mode considers the direction of the path segments at each intersection. It adds one for every clockwise intersection, and subtracts one for every counterclockwise intersection. If the result is nonzero, the point is considered inside the fill or clip area.
	Note if the number is negative, say when in a negatively turning polygon, it's still considered in the fill.

	A zero count means that the point lies outside the fill or clip area.
	 */
	class ByWinding
	{
	}
}
