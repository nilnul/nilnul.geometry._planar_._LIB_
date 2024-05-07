using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// when talking about n d, the m d is often not essential when m is lt n.
	/// <summary>
	/// there is no hole.
	/// including:
	///		point,
	///		<see cref="planar.grad_.ISkid"/>
	///		,or zone
	/// excluding:
	///		circle.
	///  topologically from one point that is elastic. don't tear or glue it.
	/// </summary>
	/// <remarks>
	/// tope is a way to form high dimension object from lower dimension ones.
	///		by spreading/sweeping 1d to 2d
	///		by elevating from 2d to 3d
	///			prism
	///			conic
	///	 another way, better/clearer way,  to say <see cref="crux_.ISimple"/>
	///	 </remarks>
	/// tope
	///		like the tope in "polytope"
	/// 
	///		tope is for any dimension.
	///			 not hedron, which is for 3d only;
	///			 not -gon, which is for 2d only
	/// simplex
	/// alias:
	///		tope
	///		,	topology
	///			, tape, <see cref="tope_.IBloc"/>
	///		
	public interface ITope : crux_.ISimple/// manifold, is, many fold, and there might be a hole in it. 
	{
	}
}
