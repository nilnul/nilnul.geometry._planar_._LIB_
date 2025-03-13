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
	/// <see cref="co.distance_.IGjkAlgorithm"/>
	/// <see cref=""/>
	/// <see cref="planar.vect.set.op_.binary_.minkowski_.Minus"/>
	/// <see cref="nilnul.geometry.planar.zone_.convex.co.be_.joint_.IGjkAlgorithm"/>
	/// 
	class ISeparatingAxisTheorem
	{
	}
}
