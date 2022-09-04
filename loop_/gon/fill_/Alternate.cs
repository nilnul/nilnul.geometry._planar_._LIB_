using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.loop_.gon.fill_
{
	/*
 To determine the interiors of closed figures in the alternate mode, draw a line from the point in question to some point obviously outside the path.
	If the line crosses an odd number of path segments, the point is inside the closed region and is therefore part of the fill or clipping area.
	An even number of crossings means that the point is not in an area to be filled or clipped.	 
	 */
	/// <summary>
	/// 
	/// </summary>
	/// vs: winding
	///		which considers the direction of the path.
	class Alternate
	{
	}
}
