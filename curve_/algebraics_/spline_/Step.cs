using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.polys_.spline_
{
	/// <summary>
	/// spline of order 0
	/// 
	/// for a pair of two points among a str of points, we try to find <var>a</var> to make a poly curve of degree0th, a=y, to connect the two points.
	/// when the two points are at the same height, we will succeed; we will fail otherwise.
	///
	/// As we are on a geometry plane, hence the x,y shall be exchangable. Thus, we can also find x=b to connect two points if they are at the same horizontal position.
	///
	/// for three points u,v,w, we can find a stepwise curve if we are lucky (u and v share same height, v and w share same horizon).
	///
	/// 
	///		
	/// </summary>
	interface IStep
	{
	}
}
