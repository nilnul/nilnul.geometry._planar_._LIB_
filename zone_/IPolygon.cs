using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_
{
	/// <summary>
	/// 
	/// </summary>
	/// vs:
	///		<see cref="cycle_.IPolygon"/>, this has a positive winding direction such that the enclosed area is the inner part, not the outerpart, which is holed planar, not a gon;
	public interface IPolygon:
		cycle_.gon_.IAffirmative
	{
	}
}
