using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.surface_.polygon_
{
	/// <summary>
	/// the rotation is negative.
	/// So we can either regard :
	///		1) the inner area as negative
	///		2) the outer area as infinity.
	/// </summary>
	public interface INegative
		:IPolygon
		,
		surface_.opposite_.IHole
	{
	}
}
