using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._surface
{
	/// <see cref="planar._locus_.ITime"/>
	/// <summary>
	/// analog to the warp(UvMapping) funciton in 3d geometry to define a surface from bivariate, here we also take two parameter, but returns a boolean to indicate whether that point is reached/within.
	/// Note:
	///		for <see cref="cycle_.IProWinded"/>, the point is in the cycle; for <see cref="cycle_.IConWinded"/> which is a hole, the point is outer of the inner hole.
	/// </summary>
	/// <remarks>
	/// this can also be differentiable when its tgt is constant, 1 inner of the surface, and 0 outer of the surface. 
	/// But for src at the boundary, it's not differentiable
	///
	/// </remarks>
	/// in 3d, the warp function maps a surface to another; the returned is a 3d vect, not a bool
	/// 
	public interface IIsReached
	{
	}

	public interface IsReached8DblI
		:
		nilnul._ral.map.tgt.be_.IsReachedI<C>
	{
		/// <summary>
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
		//bool IsReached(C c);
	}


}
