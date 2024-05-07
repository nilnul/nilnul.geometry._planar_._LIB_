using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curl_.link_
{
	/// <summary>
	/// (a,b,c)
	///		where b is the pivot, b!=a, b!=c
	///		and c might be equal to a.
	///	,for a!=c, <see cref="bi_.INunchaku"/>
	/// </summary>
	/// 
	/// for a=c, <see cref="cycle_.ITriangle"/>
	/// alias:
	///		elbow
	internal class IBiSkid:IPolyskid
	{
	}
}
