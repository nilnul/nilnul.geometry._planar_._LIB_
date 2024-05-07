using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// In essence, this is a set of points that is arranged in a 1d form, and is clozed.	/// excluding single point.
	/// This might self incident/intersect
	/// 
	/// <see cref="grad_.skid.IChain"/>
	/// </summary>
	/// <remarks>
	/// To describe it, we can use various ways, some of which might be redudant and can be reduced to an equivalent form. Eg: for <see cref="coil_.IGon"/> , we can take more points at one point, and we can also take point in the middle of a grad. To reduce, these redundant points can be removed. Here we can see that if we have n grads, we might have a n-1 polygon, as some grads form a same edge. So the gon's edge doesnot correspond to grad one by one.
	/// </remarks>
	/// alias:
	///		coil
	///			ends with "il" like <see cref="planar.ITrace"/>
	public interface ICoil :
ICurve, cloze_.ISpanned
	{
	}
}
