using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar_.ergo_._canvas_.axis_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// in addition to the linear, which is horizon, we need a second axis. We have two options:
	///		1) vertical
	///			as in screen
	///				row-major
	///			book
	///				row-major
	///			matrix
	///				row-major
	///		1.1) why we place the screen vertically, not levelly?
	///				becuz when placed levelly, the further end would entail a small angle of view in perspective, and may incur wrong perception.
	///				when placed vertially, it's parralel to our face, to the plane on which our eyeball swirls
	///				when we read book, or a phone, we place the surface parrallel to our face.
	///		2) longitunal/perspect
	///			the surface can be placed stable on land. (minimize the gravity potence)
	///			
	///	We will choose vertical
	///		when we face a 3d object such as a cuboid, we first meansure it's width and height, and finally its furtherness along the longitude/perspective axis
	///		in line with screen.
	///
	/// alias:
	///		height
	/// </remarks>
	public interface IVertical
	{
	}
}
