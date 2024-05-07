using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	///learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/global-and-local-transformations?view=netframeworkdesktop-4.8
	/// ,where local transformation is like this. the global transformation transforms every object, acts like a morph for all.
	/// 
	/// <summary>
	/// morph/transform an object to another object, in the same space.
	/// </summary>
	/// <remarks>
	///
	/// eg:
	///		<see cref="System.Drawing.Drawing2D.GraphicsPath"/> has a transform method that allows you to transform the data points of that path, not other objects;
	///
	/// 
	/// 
	/// vs: <see cref="nameof(planar.IMap)"/>,<see cref="nameof(planar.map_.ITrans)"/>
	///		same starting letter.
	///		map is from one space to a new space. everything inside the space is mapped into a thing in the new space.
	///		morph is from one object to a new object, in the same space
	/// </remarks>
	///
	///		we can even establish a new coordinates syste that is not orthogonal (the two axises are not perpendicular).
	///			eg: we might map a flat facet of a square in 3d onto the screen using <see cref="morph_.matrixed_.IShearOnly"/>. This is still a 2d to 2d trans, as we only transform one facet, which is 2d, from a 3d model.
	///			here the coordinates of the object in new world is the same as the coordinates in old world.
	///			But if we interpret the new world using two vectors in the old world, we can see the entity is morphed, ie, they are physically altered.
	///			In all, the steps are different from general <see cref="geometry.planar.ITrans"/>:
	///				1) establish a new world, not using the old world. such that the morph of this object doesnot impact other entities.
	///				2) the new coordinates of entity are the same as old ones
	///				3) establish a new coordinates in the old world: the two axises might be not perpendicular. map the entity in new world back into an object under this new coordinate system.  this new coordinates of the entity remains intact; but the entity would be morphed (with reference to the original world). Imaging a guy going out to town, returns with a new transformed figure.
	///				4) the 4th coordinates of the points, with respect to the old world, of the morphed object would be recalcualated.

	public interface IMorph
		:map_.IMorph
	{
	}

	/*
	 you can use the world transformation to revise the coordinate system and use local transformations to rotate and scale objects drawn on the new coordinate system.
	 */
}
