using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.convex.co.collision
{

	/// <summary>
	/// for polygon,
	///		for each edge, select a prediculare line, and project the polygon onto that line.
	///		see if two polygons overlap.
	///
	/// test for all axisis.
	/// 
	/// for nonpolygon,
	///		for example, circle, we can use Sat for polygon, and ad-hoc for circle.
	///		or we can convert circle to polygon.
	/// </summary>
	class ISeparatingAxisTheorem
	{
	}
}
