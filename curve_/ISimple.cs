using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_
{
	///if it's self intersect,  part of it would be a coil.
	/// if any part of it is not coil, then it is simple.
	/// <summary>
	/// donnot self-intersect. 
	/// 
	/// </summary>
	/// <remarks>
	/// cloze (cut into one end being close, one end being open) can also be made simple as long as we make the end point an open point.
	///
	/// </remarks>
	/// 
	/// vs: singular in math
	///		singular means unique tangent exists everywhere.
	///	alias:
	///		way
	///		away
	///		,hamilton
	///		,don't repeat your self: dry.
	///		,march
	///		, nonrepeat
	///		, nonecho
	///		,noreiterate
	///		,stay away
	///		,stay clear
	///		
	public interface ISimple:ICurve
	{
	}
}
