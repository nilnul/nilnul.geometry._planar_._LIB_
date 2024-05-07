using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_
{
	/// <summary>
	/// only for a boundaried surface will we talk about no hole.
	/// as for unboundaried surface, like x is in [0,1], the plane is parted into disconnected area, like the inner and outer of a donut that are disconnected.
	/// So for unbounaried surface, determining the simpleness by determining whethere the remaining are connected would be not viable.
	/// </summary>
	/// <see cref="planar.IZone"/>
	public interface ISimple
		:IFacet
	{
	}
}
