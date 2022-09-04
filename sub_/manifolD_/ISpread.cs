using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub_.manifolD_
{
	/// <summary>
	/// sweep of a curve (note the curve might be a point)
	/// 2-manifold
	///		the area might be infinite.
	///			or finite with holes, outlining points/curves
	///	including 1-manifold
	///		for example, we have digon in polygon
	///	to exluding 1-minifold, use
	///		spread_.Noncurve
	/// </summary>
	public interface ISpread
	{
	}
}
