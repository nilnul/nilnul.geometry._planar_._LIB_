using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.piecewise_
{
	/// <summary>
	/// definable by a series of distinct points
	/// </summary>
	public interface IPolygon:
		cloze_.IPiecewise
		,
		curve_.piecewise_.IPolystep{ }
	/// <summary>
	/// </summary>
	
}
