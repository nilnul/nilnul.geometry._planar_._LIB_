using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// a point of set, that is 1d, contiguous, closed, non self-intersected.
	/// To describe this, we might sample many points at the same point, or same edge. For example, we might use many grads including trivia ones to describe one edge of <see cref="cycle_.IPolygon"/>
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface ICycle : coil_.ISimple
	{
	}
}
