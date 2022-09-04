using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_
{
	/// <summary>
	/// 
	/// </summary>
	/// vs:
	///		trigon
	///			which is a zone.
	///		whileas triangle is a curve.
	public interface ITriangle:cloze_.IPolygon
		,
		cloze_.piecewise_.IPolygon
		,
		IFinite
	{
	}
}
