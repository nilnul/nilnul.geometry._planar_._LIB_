using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	///	 transformation of coordinates;
	/// this is a transformation of coordinate system, not a <see cref="sub.Morph"/> of objects in a preset coordinate system.
	///
	/// eg:
	///		in modelling, a square has a coordinates.
	///		we then can shear it using a transformation. The cordiantes of eac point is changed.
	///		in the vwer's coordinates, we interpret the coordinates using a cartesian system.

	/// <summary>
	/// <see cref="geometry.planar.IVw"/>
	/// a special map from 2d to 2d.
	/// this is a transform of cordinated space to another, not one object to another, which is <see cref="geometry.planar.sub.IMorph"/> instead. trans doesnot change any thing, but morph would change an entity.
	/// some transformation can only be defined as one coordinates space to another coordinates. eg: mapping <see cref="nameof(linear.grad_.nontrivia.map_.TgtGrad4Dbl)"/> pair to another pair.
	/// </summary>
	/// <remarks>
	/// the figure's coord component is labelled as 0th, 1st, 2nd,...
	///		or: initial, medium, last
	///		in order to avoid confusion with new axis name: x, y,z.
	///
	/// 
	/// vs
	///		sub.Morph
	///			planar Trans is about the coord, while sub.Morph is about object.
	///			planr Trans is map a space to another space, while sub.Morph is in the same space.
	///
	/// alias:
	///
	///		passive rotation. <see cref="planar.drawable._morph_"/>, <see cref="planar.sub.IMorph"/>, which is active transform
	/// </remarks>
	public interface ITrans
		: planar.map_.ITrans
	{
	}

	/*
	  a world transformation and a page transformation so that you can transform (rotate, scale, translate, and so on) the items you draw

docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/types-of-coordinate-systems?view=netframeworkdesktop-4.8
One transformation, called the world transformation, converts world coordinates to page coordinates, and another transformation, called the page transformation, converts page coordinates to device coordinates.

Also note that because the unit of measure is the pixel, the device coordinates are the same as the page coordinates. If you set the unit of measure to something other than pixels (for example, inches), then the device coordinates will be different from the page coordinates.

	The world transformation, which maps world coordinates to page coordinates, is held in the Transform property of the Graphics class.
	
	The page transformation maps page coordinates to device coordinates. The Graphics class provides the PageUnit and PageScale properties for manipulating the page transformation. The Graphics class also provides two read-only properties, DpiX and DpiY, for examining the horizontal and vertical dots per inch of the display device.

	The following example draws a line from (0, 0) to (2, 1), where the point (2, 1) is 2 inches to the right and 1 inch down from the point (0, 0):


myGraphics.PageUnit = GraphicsUnit.Inch;
myGraphics.DrawLine(myPen, 0, 0, 2, 1);*/
}
