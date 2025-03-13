using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.roulette_.cog_
{
	/// <summary>
	/// A hypotrochoid is a roulette traced by a point attached to a circle of radius r rolling around the inside of a fixed circle of radius R, where the point is a distance d from the center of the interior circle.
	/// </summary>
	/// <remarks>
	/// rolling inside; the point might be not on the circle, but inner or outer 
	/// </remarks>
	/// <seealso cref="cycle_.ICycloid"/>
	/// alias:
	///		hypo trochoid
	///			,where hypo- means sub, under,infrm, mesa, dys, mal
	///			,where trocoid <see cref="roulette_.trochoid_"/>
	///			
	///		cycloid
	///		roulette_.ICog
	///		endo
	public interface IHypoTrochoid : cog_._epi.IInside
	{

	}
}
