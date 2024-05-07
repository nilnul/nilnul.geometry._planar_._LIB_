using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_
{
	/// <summary>
	/// the hole is not necessarily circle. it can be any <see cref="IZone"/>
	/// the outer edge is called hull; the inner is called hole;
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// alias:
	///		donut
	///			for 3d
	///		holed.
	///		torus
	///
	//[Obsolete("as zone is stokes positive, so the inner is not zone")]
	public  interface IHoled:IFacet
	{
	}
}
