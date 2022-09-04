using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_
{
	/// <summary>
	/// <see cref="facet_.holed_.gon_.bloc_.Holed._toClozeInControls(int)"/> when polygonized, two edges are incident.
	/// But the inner area is still roadable, but not simple, as there is a hole.
	/// </summary>
	public interface IEnclosureAtEdge
		:coil_.IGon
	{
	}
}
