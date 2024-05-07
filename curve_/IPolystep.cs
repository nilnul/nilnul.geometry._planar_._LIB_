using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_
{
	/// <summary>
	/// a str of segs pieced together
	/// </summary>
	///alias:
	///		polyline
	///		polyseg
	///		bentline
	///		foldline

	public interface IPolystep:IPiecewise,curve_.IFinite
	{
	}
}
