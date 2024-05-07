using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// map 2d to n(D) where n le 2. map 2d to 3d or more dimensions will be processed in 3d or higher dimensions, not here, as we regard 3d as an extention to this one.
	/// map doesnot change the entity, instead we establish a new coordinate system (might be lower dimenstion, generally hardware bound) for the entity. eg: screen is a 2d viewer for 3d objects.
	/// </summary>
	/// <remarks>
	/// a world to another world
	/// </remarks>
	/// <see cref="Transform"/>
	///	<seealso cref="nilnul.geometry.planar.sub.IMorph"/>
	/// alias:
	///		map
	///			vs: morph <see cref="IMorph"/>
	public interface IMap
		:IVw
	{
	}
}
