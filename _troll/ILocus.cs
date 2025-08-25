using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._troll
{
	/// <see cref="_sub.locus_.IContinuous"/>
	/// <summary>
	/// as there is a bijection between a line and a plane, a locus can be used to describe a surface. (actually it can be used to define 3d soids). We can use as a "point cloud";
	/// eg:
	///		split a real number, say: 123.456
	///		,by odd even offset from the point,:
	///			13.5
	///			2.46
	///		
	/// But the mapping is not continuous.
	/// </summary>
	/// <remarks>
	/// it can be incontinuous:
	///		<see cref="curve_.IPiecewise"/>
	///		pathological, eg:<see cref=""/>
	///		
	/// </remarks>
	/// alias:
	///		locus
	///		fn
	///		orbit
	///		
	///		planet
	///		world
	///		universe
	///		
	public interface ILocus:_sub.locus_.IContinuous
	{
	}


}
