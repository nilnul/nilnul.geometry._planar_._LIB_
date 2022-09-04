using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	///  the dimension is no more than 1.including:
	///		point, which is 0 in dimension
	///	cantor set, the dimension is in (0,1), would be discussed later, as a stream of trails, not here.
	/// <summary>
	/// point or curve.
	/// point 0 curve can be sequential. 
	/// 0d, 1d,  excluding 2d objects.
	/// </summary>
	/// <remarks>
	/// <seealso cref="nilnul.geometry.linear.IDrawable"/>
	/// excluding xD, where x is in (0,1).
	/// also exclude anything more than 1d.
	/// </remarks>
	///
	/// <seealso cref="linear.ITope"/>
	/// alias:
	///		trek
	/// 
	public interface ITrail
		: sub_.IDirected

	//IDirected/// this is a connected shape, under 1d.
	//,
	//sub_.INonempty
	//,
	//IDrawable
	{
	}

}
