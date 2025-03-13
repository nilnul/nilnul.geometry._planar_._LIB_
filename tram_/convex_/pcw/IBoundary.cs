using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tram_.convex_.pcw
{
	/// <summary>
	/// take the x -axis as the reference lead,
	/// then for each edge's chord,
	/// ,if the chord is swung about the lead in lt 90, then the edge is still convex with reference to the lead.
	/// ,if the choid is swung about the lead by 90deg, then the edge is not convex, due to the bigger peg overlapping less peg in function value. But the min point is still usable.
	/// </summary>
	/// <see cref="convex_.pcw_.rotated.IBoundary"/>
	internal class IBoundary
	{
	}
}
