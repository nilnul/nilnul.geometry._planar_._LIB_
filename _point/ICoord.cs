using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._point
{
	/// <summary>
	///  x,y,z
	///  we use single letter to imply that this :
	///		*) subject to interpretation
	///			is x horizontal,vertical, or perspective? subjective to later interpretation.
	///			the handedness is not fixed here. We can also treat the (x,y,z) as a coordinate of any handedness.
	///			Note: interpretation is is different from import.
	///			import is bring the entity into another coordinated system.
	///			interperation is taking the coordiante itself, but seeing it as different handedness. It's totally a priori.
	///		*) local.
	///			each entity in 3d model uses its own coordinate system.
	///			different entities in 3d model bring along different coordiantes into a single model/world.
	/// </summary>
	/// <see cref="_vw.CoordsSystem"/>
	class ICoord
	{
	}
}

//abscissa
//ordinate


///斜角坐标系
///		可转化到直角坐标系
