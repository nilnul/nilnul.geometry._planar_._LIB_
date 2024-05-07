using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.trigon
{
	/// <summary>
	/// from a vertex to the a point at the oppsite edge.
	/// this will split the trigon into two trigons;
	/// </summary>
	/// <remarks>
	/// excluding:
	///		vertex
	///			,which would not cut|split the trigon into two.
	///		outer points,
	/// </remarks>
	/// alias:
	///		bisect
	///		beam
	///		splitter.
	internal interface ICevian
	{
	}
}
