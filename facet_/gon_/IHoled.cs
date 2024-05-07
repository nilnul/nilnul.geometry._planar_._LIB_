using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_.gon_
{
	/// <summary>
	/// the outer polygon is facade.
	/// the inner polygon is negative.
	/// the outer and the inner is injoint. (the hulls are not tangent.)
	/// </summary>
	/// <remarks>
	/// the hole is not necessarily circle. it can be any <see cref="IZone"/>
	/// </remarks>
	/// alias:
	///		donut
	///			for 3d
	///		holed.
	///		torus
	///
	//[Obsolete("as zone is stokes positive, so the inner is not zone")]
	 interface IHoled
	{
	}
}
