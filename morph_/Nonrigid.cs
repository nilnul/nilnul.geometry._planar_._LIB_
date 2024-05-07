using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_
{

	/// <summary>
	/// morphed.
	/// We must take a nother step :
	///		1)interpret the object's coordinates as coordinates of two non-orthogonal vector as the new axis. Note: this is only interpretation; the coordinates remains unchanged.
	///		2) calcuate each point's coordinates at the vwer's world coordinate system
	///			2.1) for rigid transform such as translation:
	///				we can simply carry out the calculation at the entity's world： establish a new coordinate system, and using the new coordinates as the coordinates for the vwer's world.
	///				eg:
	///					we can establish a left-hand coordinate system, pointing x to the opposite direction. the new coordinates would be negating old ones.
	///			2.2) for nonrigid, we don't have the leeway to do this(establish the interim coord sys at the entity world). We have to map between two world.
	///				eg:
	///					for shear:
	///					we cannot establish the new interpretation at the entity's world.
	///					we have to establish two vector as the new coordinate system in the vwer's world.
	///					regard the old coordinates as new ones; (coordinates unchanged)
	///					calculate the point's coordinates at the vwer's world.
	///		
	/// </summary>
	///		<see cref="planar.sub.IMorph"/>
	/// 
	public interface INonRigid
	{
	}
}
