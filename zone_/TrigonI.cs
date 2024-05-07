using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.zone_
{
	/// <summary>
	/// three points that are non-colinear
	/// 	/// On the front of the triangle, the vertices are specified in counter-clockwise order. http://ericsink.com/wpf3d/5_Triangles.html
	/// </summary>
	/// <remarks>
	/// if the points are in negative direction, the enclosed is the outter area, which is not a trigon;
	/// </remarks>
	public interface TrigonI
	{

		planar.point.trio.be_.tripod.vow.Ee pointTrio { get; }


	}
}
