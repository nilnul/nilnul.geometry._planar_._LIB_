using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_
{
	/// <summary>
	/// the outer polygon is facade.
	/// the inner polygon is negative.
	/// the outer and the inner is injoint. (the hulls are not tangent.)
	/// </summary>
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
