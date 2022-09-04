using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	///  the dimension is no more than 1.including:
	///		point, which is 0 in dimension
	///	cantor set, the dimension is in (0,1), would be discussed later, as a stream of <see cref="planar.ITrace"/>, not here.
	/// <summary>
	/// 0d, 1d,  excluding 2d objects.
	/// eg: some stage for a cantor set. it's directionless.
	/// </summary>
	/// <remarks>
	/// <seealso cref="nilnul.geometry.linear.IDrawable"/>
	/// excluding xD, where x is in (0,1).
	/// also exclude anything more than 1d.
	/// </remarks>
	/// alias:
	///		trace
	///			same initial as <see cref="ITrack"/>
	///				the two are all not directed.
	///				
	/// <seealso cref="linear.ITope"/>
	/// 
	/// 
	public interface ITrace//: point.ITrail
		:
		trail.IIgnoreOrder
		,
		manifold_.INil0oneDimension
	//	crux_.IPoint0curve	/// this is a connected shape, under 1d.
		//,
		//sub_.INonempty
		//,
		//IDrawable
	{
	}

}
