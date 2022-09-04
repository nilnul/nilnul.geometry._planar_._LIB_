using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear
{
	/// <summary>
	/// when we bring some linear entities (eg: a stick, a woolen thread) into a viewer software, we are bringing each of the entity into a virtual world (embedded into a viewport of some hardware such as screen, which then sheds into our eyes).
	/// the coordinate system of the world is generally different from each coordinate system of the entity. Hence, we need to transform/reOrient the coordinate (note: transform is not morphing the object; instead, we keep the entity intact, but we would establish another new coordinate system. the new coordinates of each point would be derived from the old coordinates. )
	///				note here: transform is establish another new, not changing anything, or delete anythign (the old coordinate system is still there).
	/// transform might be:
	///		translate:
	///			the new origin is different from the old origin.
	///		reorient:
	///			in linear case, this is a negative scale.
	///				note here, when we establish a new coord system, the entity is intact, but each point would have a new coordinates, in addition to old ones.
	/// </summary>
	class Vw
	{
	}
}
