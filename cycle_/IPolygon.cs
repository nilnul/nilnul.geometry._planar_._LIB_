using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_
{
	/// <summary>
	/// vertexes are distinct.
	/// if edges are crossed, the crossed point must be at the extrem of each edge.
	/// this implies that we at least have 3 points.
	/// </summary>
	public interface IPolygon : ICycle, coil_.IGon
	{
	}
}
